using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo
{
    internal class Banco
    {
        private static string strcnn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Funcionario\Estudo\BDGrafico_2026-05-25.mdf;Integrated Security=True";

        public static SqlConnection AbrirBD()
        {
            SqlConnection cnn = new SqlConnection(strcnn);
            cnn.Open();
            return cnn;
        }

    }
}
