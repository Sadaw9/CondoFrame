using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace frontPage
{
    class Conexao
    {
        private static string connString = @"Provider=Microsoft.Ace.OLEDB.12.0;Data Source=base_tcc (1).accdb";

        private static OleDbConnection conn = null;

        public static OleDbConnection obterConexao()

        {
            conn = new OleDbConnection(connString);

            try
            {
                conn.Open();
            }
            catch (Exception ex)

            {
                conn = null;
                MessageBox.Show("Conexão não estabelecida!!" + ex);
            }

            return conn;

        }
        public static void fecharConexao()

        {

            if (conn != null)

            {

                conn.Close();

            }
        }
    }
}
