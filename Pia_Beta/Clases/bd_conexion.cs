using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pia_Beta.Clases
{
    internal class bd_conexion
    {
        public static MySqlConnection ConectarBD()
        {
            string servidor = "localhost";
            string bd = "bd_pia";
            string user = "root";
            string contraseña = "admin1519";
            string puerto = "3306";

            string cadenaconex = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id =" + user + ";" + "password=" + contraseña + ";" + "database=" + bd + ";";

            MySqlConnection conex = new MySqlConnection(cadenaconex);

            return conex;
        }
    }
}
