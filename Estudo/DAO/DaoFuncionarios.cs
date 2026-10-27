using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Models.DAO
{
    internal class DaoFuncionario : Dao
    {
        public override string Salvar(object obj)
        {
            Funcionario oFuncionario = (Funcionario)obj;

            using (SqlConnection cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    int codigo;

                    if (oFuncionario.Codigo == 0)
                    {
                        const string sql =
                            "INSERT INTO Funcionario (numCnh, datCnh, mat, salBase, aCidade, numDep, dataValidade, cep, oCargo) " +
                            "OUTPUT INSERTED.codigo " +
                            "VALUES (@numCnh, @datCnh, @mat, @salBase, @aCidade, @numDep, @dataValidade, @cep, @oCargo)";

                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametros(cmd, oFuncionario);
                            codigo = (int)cmd.ExecuteScalar();
                        }
                    }
                    else
                    {
                        const string sql =
                            "UPDATE Funcionario SET numCnh = @numCnh, datCnh = @datCnh, mat = @mat, salBase = @salBase, " +
                            "aCidade = @aCidade, numDep = @numDep, dataValidade = @dataValidade, cep = @cep, oCargo = @oCargo " +
                            "WHERE codigo = @codigo";

                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametros(cmd, oFuncionario);
                            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oFuncionario.Codigo;

                            if (cmd.ExecuteNonQuery() == 0)
                                throw new InvalidOperationException("Funcionário não encontrado para alteração");
                        }

                        codigo = oFuncionario.Codigo;
                    }

                    tx.Commit();
                    oFuncionario.Codigo = codigo;
                    return codigo.ToString();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        private static void AdicionarParametros(SqlCommand cmd, Funcionario oFuncionario)
        {
            cmd.Parameters.Add("@numCnh", SqlDbType.VarChar, 20).Value = oFuncionario.NumCnh;
            cmd.Parameters.Add("@datCnh", SqlDbType.VarChar, 10).Value = oFuncionario.DatCnh;
            cmd.Parameters.Add("@mat", SqlDbType.VarChar, 20).Value = oFuncionario.Mat;
            cmd.Parameters.Add("@salBase", SqlDbType.VarChar, 20).Value = oFuncionario.SalBase;
            cmd.Parameters.Add("@aCidade", SqlDbType.Int).Value = oFuncionario.ACidade.Codigo;
            cmd.Parameters.Add("@numDep", SqlDbType.Int).Value = oFuncionario.NumDep;
            cmd.Parameters.Add("@dataValidade", SqlDbType.DateTime).Value = oFuncionario.DataValidade;
            cmd.Parameters.Add("@cep", SqlDbType.VarChar, 9).Value = oFuncionario.Cep;
            cmd.Parameters.Add("@oCargo", SqlDbType.Int).Value = oFuncionario.OCargo.Codigo;
        }

        public override string CarregarObj(object obj)
        {
            Funcionario oFuncionario = (Funcionario)obj;
            int idCidade;
            int idCargo;

            const string sql =
                "SELECT codigo, numCnh, datCnh, mat, salBase, numDep, dataValidade, cep, " +
                "aCidade, oCargo, codUsu, datCad, ultAlt " +
                "FROM Funcionario WHERE codigo = @codigo";
            try
            {
                using (SqlConnection cnn = Banco.AbrirBD())
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oFuncionario.Codigo;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return "Codigo de Funcionario não Encontrado!";

                        oFuncionario.Codigo = dr.GetInt32(dr.GetOrdinal("codigo"));
                        oFuncionario.NumCnh = dr.GetString(dr.GetOrdinal("numCnh"));
                        oFuncionario.DatCnh = dr.GetString(dr.GetOrdinal("datCnh"));
                        oFuncionario.Mat = dr.GetString(dr.GetOrdinal("mat"));
                        oFuncionario.SalBase = dr.GetString(dr.GetOrdinal("salBase"));
                        oFuncionario.NumDep = dr.GetInt32(dr.GetOrdinal("numDep"));
                        oFuncionario.DataValidade = dr.GetDateTime(dr.GetOrdinal("dataValidade"));
                        oFuncionario.Cep = dr.GetString(dr.GetOrdinal("cep"));
                        oFuncionario.CodUsu = dr.GetInt32(dr.GetOrdinal("codUsu"));
                        oFuncionario.DatCad = dr.GetDateTime(dr.GetOrdinal("datCad"));
                        oFuncionario.UltAlt = dr.GetDateTime(dr.GetOrdinal("ultAlt"));
                        idCidade = dr.GetInt32(dr.GetOrdinal("aCidade"));
                        idCargo = dr.GetInt32(dr.GetOrdinal("oCargo"));
                    }
                }

                oFuncionario.ACidade = new Cidades();
                oFuncionario.ACidade.Codigo = idCidade;
                string erro = new DaoCidades().CarregarObj(oFuncionario.ACidade);

                if (erro != "")
                    return erro;

                oFuncionario.OCargo = new Cargo();
                oFuncionario.OCargo.Codigo = idCargo;
                return new DaoCargo().CarregarObj(oFuncionario.OCargo);
            }
            catch (SqlException ex)
            {
                return "Erro de banco de dados " + ex.Message;
            }
        }
        public override List<object> CarregarColecao()
        {
            return null;
        }
        public override List<object> Pesquisar(object obj)
        {
            return null;
        }
        public override string Excluir(object obj)
        {
            Funcionario oFuncionario = (Funcionario)obj;

            using (SqlConnection cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    const string sql = "DELETE FROM Funcionario WHERE codigo = @codigo";

                    using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                    {
                        cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oFuncionario.Codigo;

                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            tx.Rollback();
                            return "Funcionário não encontrado para exclusão!";
                        }
                    }

                    tx.Commit();
                    return "";
                }
                catch (SqlException ex)
                {
                    tx.Rollback();

                    if (ex.Number == 547)
                        return "Não é possível excluir: o funcionário está sendo usado em outros registros.";

                    return "Erro de banco de dados " + ex.Message;
                }
            }
        }
    }
}