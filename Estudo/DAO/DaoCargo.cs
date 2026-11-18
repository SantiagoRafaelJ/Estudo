using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Models.DAO
{
    internal class DaoCargo : Dao
    {
        public override string Salvar(object obj)
        {
            Cargo oCargo = (Cargo)obj;

            using (SqlConnection cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    int codigo;

                    if (oCargo.Codigo == 0)
                    {
                        const string sql =
                            "INSERT INTO Cargo (nome, exigeCNH, comiss) " +
                            "OUTPUT INSERTED.codigo " +
                            "VALUES (@nome, @exigeCNH, @comiss)";

                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametros(cmd, oCargo);
                            codigo = (int)cmd.ExecuteScalar();
                        }
                    }
                    else
                    {
                        const string sql =
                            "UPDATE Cargo SET nome = @nome, exigeCNH = @exigeCNH, comiss = @comiss " +
                            "WHERE codigo = @codigo";

                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametros(cmd, oCargo);
                            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oCargo.Codigo;

                            if (cmd.ExecuteNonQuery() == 0)
                                throw new InvalidOperationException("Cargo não encontrado para alteração");
                        }

                        codigo = oCargo.Codigo;
                    }

                    tx.Commit();
                    oCargo.Codigo = codigo;
                    return codigo.ToString();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        private static void AdicionarParametros(SqlCommand cmd, Cargo oCargo)
        {
            cmd.Parameters.Add("@nome", SqlDbType.VarChar, 50).Value = oCargo.Nome;
            cmd.Parameters.Add("@exigeCNH", SqlDbType.Bit).Value = oCargo.ExigeCNH;
            cmd.Parameters.Add("@comiss", SqlDbType.Float).Value = oCargo.Comiss;
        }

        public override string CarregarObj(object obj)
        {
            Cargo oCargo = (Cargo)obj;

            const string sql =
                "SELECT codigo, nome, exigeCNH, comiss, CodigoUsuario, DataCadastro, DataAlteracao" +
                "FROM Cargo WHERE codigo = @codigo";
            try
            {
                using (SqlConnection cnn = Banco.AbrirBD())
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oCargo.Codigo;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return "Codigo de Cargo não Encontrado!";

                        oCargo.Codigo = dr.GetInt32(dr.GetOrdinal("codigo"));
                        oCargo.Nome = dr.GetString(dr.GetOrdinal("nome"));
                        oCargo.ExigeCNH = dr.GetBoolean(dr.GetOrdinal("exigeCNH"));
                        oCargo.Comiss = dr.GetDouble(dr.GetOrdinal("comiss"));
                        oCargo.CodUsu = dr.GetInt32(dr.GetOrdinal("CodigoUsuario"));
                        oCargo.DatCad = dr.GetDateTime(dr.GetOrdinal("DataCadastro"));
                        oCargo.UltAlt = dr.GetDateTime(dr.GetOrdinal("UltimaAlteracao"));
                    }
                }
                return "";
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
            Cargo oCargo = (Cargo)obj;

            using (SqlConnection cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    const string sql = "DELETE FROM Cargo WHERE codigo = @codigo";

                    using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                    {
                        cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oCargo.Codigo;

                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            tx.Rollback();
                            return "Cargo não encontrado para exclusão!";
                        }
                    }

                    tx.Commit();
                    return "";
                }
                catch (SqlException ex)
                {
                    tx.Rollback();

                    if (ex.Number == 547)
                        return "Não é possível excluir: o cargo está sendo usado por funcionários.";

                    return "Erro de banco de dados " + ex.Message;
                }
            }
        }
    }
}