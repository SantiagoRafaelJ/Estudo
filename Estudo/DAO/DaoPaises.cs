using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo.Models.DAO
{
    internal class DaoPaises : Dao
    {

        public override string Salvar(object obj)
        {
            Paises oPais = (Paises)obj;

            using (SqlConnection cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    int codigo;

                    if (oPais.Codigo == 0)
                    {
                        const string sql =
                            "INSERT INTO Paises (pais, sigla, ddi, moeda) " +
                            "OUTPUT INSERTED.ID " +
                            "VALUES (@pais, @sigla, @ddi, @moeda)";

                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametros(cmd, oPais);
                            codigo = (int)cmd.ExecuteScalar();
                        }
                    }
                    else
                    {
                        const string sql =
                            "UPDATE Paises SET pais = @pais, sigla = @sigla, ddi = @ddi, moeda = @moeda " +
                            "WHERE ID = @codigo";

                        using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                        {
                            AdicionarParametros(cmd, oPais);
                            cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oPais.Codigo;

                            if (cmd.ExecuteNonQuery() == 0)
                                throw new InvalidOperationException("País não encontrado para alteração");
                        }

                        codigo = oPais.Codigo;
                    }

                    tx.Commit();
                    oPais.Codigo = codigo;
                    return codigo.ToString();
                }
                catch
                {
                    tx.Rollback();
                    throw;
                }
            }
        }


        private static void AdicionarParametros(SqlCommand cmd, Paises oPais)
        {
            cmd.Parameters.Add("@pais", SqlDbType.VarChar, 50).Value = oPais.Pais;
            cmd.Parameters.Add("@sigla", SqlDbType.VarChar, 3).Value = oPais.Sigla;
            cmd.Parameters.Add("@ddi", SqlDbType.VarChar, 5).Value = oPais.Ddi;
            cmd.Parameters.Add("@moeda", SqlDbType.VarChar, 5).Value = oPais.Moeda;
        }


        public override string CarregarObj(object obj)
        {
            Paises oPais = (Paises)obj;

            const string sql =
                "SELECT id, pais, sigla, ddi, moeda, codUsu, datCad, ultAlt " +
                "FROM Paises WHERE id = @codigo";
            try
            {
                using (SqlConnection cnn = Banco.AbrirBD())
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oPais.Codigo;

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                            return "Codigo de Pais não Encontrado!";

                        oPais.Codigo = dr.GetInt32(dr.GetOrdinal("id"));
                        oPais.Pais = dr.GetString(dr.GetOrdinal("pais"));
                        oPais.Sigla = dr.GetString(dr.GetOrdinal("sigla"));
                        oPais.Ddi = dr.GetString(dr.GetOrdinal("ddi"));
                        oPais.Moeda = dr.GetString(dr.GetOrdinal("moeda"));
                        oPais.CodUsu = dr.GetInt32(dr.GetOrdinal("codUsu"));
                        oPais.DatCad = dr.GetDateTime(dr.GetOrdinal("datCad"));
                        oPais.UltAlt = dr.GetDateTime(dr.GetOrdinal("ultAlt"));
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
            string sql = "SELECT ID, PAIS, SIGLA, DDI, MOEDA FROM paises";
            var lista = new List<Object>();

            using (SqlConnection cnn = Banco.AbrirBD())


                try
                {
                    if (cnn.State != System.Data.ConnectionState.Open)
                        cnn.Open();

                    using (var cmd = new SqlCommand(sql, cnn))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            lista.Add(new Paises(
                                Convert.ToInt32(dr["ID"]),
                                dr["pais"].ToString(),
                                dr["sigla"].ToString(),
                                dr["ddi"].ToString(),
                                dr["moeda"].ToString()));
                        }
                    }
                }
                finally
                {
                    cnn.Close();
                }
            return lista;
        }
        public override string Excluir(object obj)
        {
            Paises oPais = (Paises)obj;

            using (SqlConnection cnn = Banco.AbrirBD())
            using (SqlTransaction tx = cnn.BeginTransaction())
            {
                try
                {
                    const string sql = "DELETE FROM Paises WHERE id = @codigo";

                    using (SqlCommand cmd = new SqlCommand(sql, cnn, tx))
                    {
                        cmd.Parameters.Add("@codigo", SqlDbType.Int).Value = oPais.Codigo;

                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            tx.Rollback();
                            return "País não encontrado para exclusão!";
                        }
                    }

                    tx.Commit();
                    return "";
                }
                catch (SqlException ex)
                {
                    tx.Rollback();

                    if (ex.Number == 547)
                        return "Não é possível excluir: o país está sendo usado por estados.";

                    return "Erro de banco de dados " + ex.Message;
                }
            }
        }
    }
}
