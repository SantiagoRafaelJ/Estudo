using Estudo.Models.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.DAO
{
    internal class DaoEstados : Dao
    {
        public DaoEstados() 
        {
            
        }
        public override string Salvar(object obj)
        {
            Estados oEstado = (Estados)obj;

            using (SqlConnection cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    int codigo;

                    if (oEstado.Codigo == 0)
                    {
                        const string sql =
                            "INSERT INTO Estados (estado, uf, idPais) " +
                            "OUTPUT INSERTED.ID " +
                            "VALUES (@estado, @uf, @idPais)";

                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametros(cmd, oEstado);
                            codigo = (int)cmd.ExecuteScalar();
                        }
                    }
                    else
                    {
                        const string sql =
                            "UPDATE Estados SET estado = @estado, uf = @uf, idPais = @idPais" +
                            "WHERE ID = @codigo";

                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametros(cmd, oEstado);
                            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oEstado.Codigo;

                            if (cmd.ExecuteNonQuery() == 0)
                                throw new InvalidOperationException("Estado não encontrado para alteração");
                        }

                        codigo = oEstado.Codigo;
                    }

                    tx.Commit();
                    oEstado.Codigo = codigo;
                    return codigo.ToString();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }

        private static void AdicionarParametros(SqlCommand cmd, Estados oEstado)
        {
            cmd.Parameters.Add("@estado", SqlDbType.VarChar, 50).Value = oEstado.Estado;
            cmd.Parameters.Add("@uf", SqlDbType.VarChar, 3).Value = oEstado.Uf;
            cmd.Parameters.Add("@idPais", SqlDbType.Int).Value = oEstado.OPais.Codigo;

        }


        public override string CarregarObj(object obj)
        {
            Estados oEstado = (Estados)obj;
            int idPais;

            const string sql =
                "SELECT id, estado, uf, idPais, codUsu, datCad, ultAlt " +
                "FROM Estados WHERE id = @codigo";
            try
            {
                using (SqlConnection cnn = Banco.AbrirBD())
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oEstado.Codigo;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return "Codigo de Estado não Encontrado!";

                        oEstado.Codigo = dr.GetInt32(dr.GetOrdinal("id"));
                        oEstado.Estado = dr.GetString(dr.GetOrdinal("estado"));
                        oEstado.Uf = dr.GetString(dr.GetOrdinal("uf"));
                        oEstado.CodUsu = dr.GetInt32(dr.GetOrdinal("CodigoUsuario"));
                        oEstado.DatCad = dr.GetDateTime(dr.GetOrdinal("DataCadastro"));
                        oEstado.UltAlt = dr.GetDateTime(dr.GetOrdinal("DataAlteracao"));
                        idPais = dr.GetInt32(dr.GetOrdinal("idPais"));
                    }
                }

                oEstado.OPais = new Paises();
                oEstado.OPais.Codigo = idPais;
                return new DaoPaises().CarregarObj(oEstado.OPais);
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
            string sql = "SELECT e.ID, e.ESTADO, e.UF, e.IDPAIS, p.PAIS, e.CodigoUsuario, e.DataCadastro, e.DataAlteracao FROM Estados e INNER JOIN Paises p ON p.ID = e.IDPAIS";
            var lista = new List<Object>();

            using (SqlConnection cnn = Banco.AbrirBD())
                try
                {


                    using (var cmd = new SqlCommand(sql, cnn))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Estados oEstado = new Estados();
                            oEstado.Codigo = Convert.ToInt32(dr["ID"]);
                            oEstado.Estado = dr["ESTADO"].ToString();
                            oEstado.Uf = dr["UF"].ToString();
                            oEstado.OPais.Codigo = Convert.ToInt32(dr["IDPAIS"]);
                            oEstado.OPais.Pais = dr["PAIS"].ToString();

                            lista.Add(oEstado);
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
            Estados oEstado = (Estados)obj;

            using (SqlConnection cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    const string sql = "DELETE FROM Estados WHERE id = @codigo";

                    using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                    {
                        cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oEstado.Codigo;

                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            tx.Rollback();
                            return "Estado não encontrado para exclusão!";
                        }
                    }

                    tx.Commit();
                    return "";
                }
                catch (SqlException ex)
                {
                    tx.Rollback();
                    
                    if (ex.Number == 547)
                        return "Não é possível excluir: o estado está sendo usado por cidades.";

                    return "Erro de banco de dados " + ex.Message;
                }
            }
        }
    }
}
