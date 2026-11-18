using Estudo.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Models.DAO
{
    internal class DaoCidades : Dao
    {
        public override string Salvar(object obj)
        {
            Cidades oCidade = (Cidades)obj;

            using (SqlConnection cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    int codigo;

                    if (oCidade.Codigo == 0)
                    {
                        const string sql =
                            "INSERT INTO Cidades (cidade, ddd, idEstado) " +
                            "OUTPUT INSERTED.ID " +
                            "VALUES (@cidade, @ddd, @idEstado)";

                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametros(cmd, oCidade);
                            codigo = (int)cmd.ExecuteScalar();
                        }
                    }
                    else
                    {
                        const string sql =
                            "UPDATE Cidades SET cidade = @cidade, ddd = @ddd, idEstado = @idEstado " +
                            "WHERE ID = @codigo";

                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametros(cmd, oCidade);
                            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oCidade.Codigo;

                            if (cmd.ExecuteNonQuery() == 0)
                                throw new InvalidOperationException("Cidade não encontrada para alteração");
                        }

                        codigo = oCidade.Codigo;
                    }

                    tx.Commit();
                    oCidade.Codigo = codigo;
                    return codigo.ToString();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }


        private static void AdicionarParametros(SqlCommand cmd, Cidades oCidade)
        {
            cmd.Parameters.Add("@cidade", SqlDbType.VarChar, 50).Value = oCidade.Cidade;
            cmd.Parameters.Add("@ddd", SqlDbType.VarChar, 3).Value = oCidade.Ddd;
            cmd.Parameters.Add("@idEstado", SqlDbType.Int).Value = oCidade.OEstado.Codigo;
        }
        public override string CarregarObj(object obj)
        {
            Cidades oCidade = (Cidades)obj;
            int idEstado;

            const string sql =
                "SELECT id, cidade, ddd, idEstado, CodigoUsuario, DataCadastro, DataAlteracao " +
                "FROM Cidades WHERE id = @codigo";
            try
            {
                using (SqlConnection cnn = Banco.AbrirBD())
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oCidade.Codigo;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return "Codigo de Cidade não Encontrado!";

                        oCidade.Codigo = dr.GetInt32(dr.GetOrdinal("id"));
                        oCidade.Cidade = dr.GetString(dr.GetOrdinal("cidade"));
                        oCidade.Ddd = dr.GetString(dr.GetOrdinal("ddd"));
                        oCidade.CodUsu = dr.GetInt32(dr.GetOrdinal("CodigoUsuario"));
                        oCidade.DatCad = dr.GetDateTime(dr.GetOrdinal("DataCadastro"));
                        oCidade.UltAlt = dr.GetDateTime(dr.GetOrdinal("DataAlteracao"));
                        idEstado = dr.GetInt32(dr.GetOrdinal("idEstado"));
                    }
                }

                oCidade.OEstado = new Estados();
                oCidade.OEstado.Codigo = idEstado;
                return new DaoEstados().CarregarObj(oCidade.OEstado);
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
            string sql = "SELECT c.ID, c.CIDADE, c.DDD, c.IDESTADO, e.ESTADO, c.CodigoUsuario, c.DataCadastro, c.DataAlteracao FROM Cidades c INNER JOIN Estados e ON e.ID = c.IDESTADO";
            var lista = new List<Object>();

            using (SqlConnection cnn = Banco.AbrirBD())
            try
            {

                    using (var cmd = new SqlCommand(sql, cnn))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Cidades aCidade = new Cidades();
                            aCidade.Codigo = Convert.ToInt32(dr["ID"]);
                            aCidade.Cidade = dr["CIDADE"].ToString();
                            aCidade.Ddd = dr["DDD"].ToString();
                            aCidade.OEstado.Codigo = Convert.ToInt32(dr["IDESTADO"]);
                            aCidade.OEstado.Estado = dr["ESTADO"].ToString();

                            lista.Add(aCidade);
                        }
                    }
            }
            finally
            {

            }
            return lista;
        }
        public override string Excluir(object obj)
        {
            Cidades oCidade = (Cidades)obj;

            using (SqlConnection cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    const string sql = "DELETE FROM Cidades WHERE id = @codigo";

                    using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                    {
                        cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oCidade.Codigo;

                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            tx.Rollback();
                            return "Cidade não encontrada para exclusão!";
                        }
                    }

                    tx.Commit();
                    return "";
                }
                catch (SqlException ex)
                {
                    tx.Rollback();

                    if (ex.Number == 547)
                        return "Não é possível excluir: a cidade está sendo usada por funcionários.";

                    return "Erro de banco de dados " + ex.Message;
                }
            }
        }
    }
   }
