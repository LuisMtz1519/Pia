using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pia_Beta.Clases
{
    internal class CProductos
    {
        public productos cons_prod(string clave)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "SELECT clave, Nombre_Producto, Tipo_De_Producto, Existencia, Precio FROM Productos WHERE clave LIKE @clave";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@clave", clave);

            reader = comando.ExecuteReader();

            productos prod = null;
            while (reader.Read())
            {
                prod.Clave = reader["clave"].ToString();
                prod.Nombre_Producto1 = reader["Nombre_Producto"].ToString();
                prod.Tipo_de_Producto1 = reader["Tipo_De_Producto"].ToString();
                prod.Existencia1 = int.Parse(reader["Existencia"].ToString());
                prod.Precio1 = int.Parse(reader["Precio"].ToString());
            }
            return prod;
        }
    }
}
