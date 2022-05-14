using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosasDeAccess
{
    class Conexion
    {
        public static MySqlConnection conexion()
        {
            String cadenaConexion = "Cadena de conexion";
            try
            {
                MySqlConnection connection = new MySqlConnection(cadenaConexion);
                return connection;

            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
    }  
}
