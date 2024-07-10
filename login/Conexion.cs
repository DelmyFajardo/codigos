using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace login
{
    internal class Conexion
    {

        private MySqlConnection connection;
        private string cadenaConexion;

        public Conexion()
        {
            /* cadenaConexion = "Database=" + database + 
             ";DataSource = " + serve
             ";User Id = " + user +
             "; Password ="+password;
             */
            connection = new MySqlConnection(cadenaConexion);
        }

        public MySqlConnection getConnection()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return connection;


        }

    }
}
