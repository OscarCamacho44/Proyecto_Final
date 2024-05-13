using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Interfaz_Alex_Borrador
{
    class ConexionInicio
    {
        public static MySqlConnection conexioninicio()
        {
            string servidor = "localhost";
            int puerto = 3306;
            string database = "ferreteria";
            string usuario = "root";
            string contraseña = "";
            string cadenaConexion = "Database= " + database + "; port= " + puerto + "; Data Source= " + servidor + "; User Id= " + usuario + "; Password= " + contraseña + "";

            try
            {
                MySqlConnection conexionBD = new MySqlConnection(cadenaConexion);

                return conexionBD;
            }

            catch (MySqlException ex)
            {
                Console.WriteLine("Ha ocurrido un error " + ex.Message);

                return null;
            }
        }
    }
}
