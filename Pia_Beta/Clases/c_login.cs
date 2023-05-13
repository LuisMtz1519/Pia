using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using static Mysqlx.Crud.Order.Types;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Pia_Beta.Clases
{
    internal class c_login
    {
        public usuarios porusuarios(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "SELECT usr_id, usuario_log, Contraseña, nombres, apellidos, direccion, ciudad, correo, telefono, rol FROM Usuarios WHERE usuario_log LIKE @usuario_log";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usuario_log", usuario);

            reader = comando.ExecuteReader();

            usuarios usr = null;
            while (reader.Read())
            {
                usr = new usuarios();
                usr.Usr_Id = int.Parse(reader["Usr_Id"].ToString());
                usr.Usuario_log = reader["usuario_log"].ToString();
                usr.Contraseña = reader["Contraseña"].ToString();
                usr.Nombres = reader["Nombres"].ToString();
                usr.Apellidos = reader["Apellidos"].ToString();
                usr.Direccion = reader["Direccion"].ToString();
                usr.Ciudad = reader["Ciudad"].ToString();
                usr.Correo = reader["Correo"].ToString();
                usr.Telefono = reader["Telefono"].ToString();
                usr.Rol = reader["Rol"].ToString();
            }
            return usr;
        }
    }
}
