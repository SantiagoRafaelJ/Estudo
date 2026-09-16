using System;
using System.Collections.Generic;
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
            string ok = "", sql="";
            if (oPais.Codigo == 0) // novo, incluido
            {
                sql = "insert into Paises(pais, sigla, ddi, moeda) values(@pais, @sigla, @ddi, @moeda)";
            }
            else  // alteração, já existe
            {
                sql = "update Paises set pais = @pais, sigla = @sigla, ddi = @ddi, moeda = @moeda where codigo = @codigo";
            }
            using (SqlCommand cmd = new SqlCommand(sql, cnn))
            {
                cmd.Parameters.AddWithValue("@pais", oPais.Pais);
                cmd.Parameters.AddWithValue("@sigla", oPais.Sigla);
                cmd.Parameters.AddWithValue("@sigla", oPais.Ddi);
                cmd.Parameters.AddWithValue("@moeda", oPais.Moeda);
                cmd.Parameters.AddWithValue("@codigo", oPais.Codigo);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "Select @@IDENTITY";
                ok = cmd.ExecuteScalar().ToString();
            }
                return ok;
        }
        public override string CarregarObj(object obj)
        {
            return null;
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
            Paises oPais = (Paises)obj;
            string ok = "", 

            return null;
        }
    }
}
