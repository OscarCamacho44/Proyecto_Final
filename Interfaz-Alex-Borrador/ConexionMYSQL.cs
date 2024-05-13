using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_Alex_Borrador
{
    class ConexionMYSQL : Conexion
    {
        private MySqlConnection conector;
        private string Cadena;
        
        public ConexionMYSQL()
        {
            Cadena = "Database= " + database +
                "; DataSource=" + server +
                "; User Id= " + user +
                "; Password=" + password;
            

            conector = new MySqlConnection(Cadena);
            

        }
        
        public MySqlConnection GetConnection()
        {
            try
            {
                if (conector.State != System.Data.ConnectionState.Open)
                {
                    conector.Open();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
            return conector;

        }
        
    }
}

