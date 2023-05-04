using MySql.Data.MySqlClient;

namespace Pia_Beta.Clases
{
    internal class Registro
    {
        public int registro(usuarios usuarios)
        {
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "INSERT INTO Usuarios (usr_id, usuario, contraseña, nombres, apellidos, direccion, ciudad, correo, telefono) VALUES (@usr_id, @ususario, @contraseña, @nombres, @apellidos, @direccion, @ciudad, @correo, @telefono)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@usr_id", usuarios.Usr_id);
            comando.Parameters.AddWithValue("@usuario", usuarios.Usuario);
            comando.Parameters.AddWithValue("@contraseña", usuarios.Contraseña);
            comando.Parameters.AddWithValue("@nombres", usuarios.Nombres);
            comando.Parameters.AddWithValue("@apellidos", usuarios.Apellidos);
            comando.Parameters.AddWithValue("@direccion", usuarios.Direccion);
            comando.Parameters.AddWithValue("@ciudad", usuarios.Ciudad);
            comando.Parameters.AddWithValue("@correo", usuarios.Correo);
            comando.Parameters.AddWithValue("@telefono", usuarios.Telefono);

            int resultado = comando.ExecuteNonQuery();

            return resultado;
        }

        public bool usrexistente(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "SELECT usr_id FROM Usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public usuarios usrlogin(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "SELECT usr_Id, usuario, contraseña, nombres, apellidos, direccion, ciudad, correo, telefono FROM Usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            usuarios usr = null;

            while (reader.Read())
            {
                usr = new usuarios();
                usr.Usr_id = int.Parse(reader["usr_Id"].ToString());
                usr.Contraseña = reader["contraseña"].ToString();
                usr.Nombres = reader["nombres"].ToString();
                usr.Apellidos = reader["apellidos"].ToString();
                usr.Direccion = reader["direccion"].ToString();
                usr.Ciudad = reader["ciudad"].ToString();
                usr.Correo = reader["correo"].ToString();
                usr.Telefono = reader["telefono"].ToString();
            }
            return usr;
        }
        public usuarios perfil(string usuario)
        {
            MySqlDataReader reader;
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "SELECT nombres, apellidos, direccion, ciudad, correo, telefono FROM Usuarios WHERE usuario LIKE @usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            comando.Parameters.AddWithValue("@usuario", usuario);

            reader = comando.ExecuteReader();

            usuarios usr = null;

            while (reader.Read())
            {
                usr = new usuarios();
                usr.Nombres = reader["nombres"].ToString();
                usr.Apellidos = reader["apellidos"].ToString();
                usr.Direccion = reader["direccion"].ToString();
                usr.Ciudad = reader["ciudad"].ToString();
                usr.Correo = reader["correo"].ToString();
                usr.Telefono = reader["telefono"].ToString();
            }
            return usr;
        }
    }

}
