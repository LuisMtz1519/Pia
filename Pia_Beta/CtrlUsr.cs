using MySql.Data.MySqlClient;
using Pia_Beta.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pia_Beta
{
    public partial class CtrlUsr : Form
    {
        public CtrlUsr()
        {
            InitializeComponent();
        }

        private void CtrlUsr_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "(SELECT * FROM usuarios)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable table = new DataTable();
            adapter.Fill(table);
            tablaempleados.DataSource = table;
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "(SELECT * FROM usuarios)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable table = new DataTable();
            adapter.Fill(table);
            tablaempleados.DataSource = table;
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgUsuario mainmenu = new AgUsuario();
            mainmenu.Show();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = bd_conexion.ConectarBD();
            if (tablaempleados.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(tablaempleados.SelectedRows[0].Cells[0].Value);

                // Crear la consulta para eliminar el registro con el ID seleccionado (ajustar el nombre de la tabla y columna según su configuración)
                string sql = "DELETE FROM Usuarios WHERE Usr_Id='" + selectedId + "';";

                // Abrir la conexión y ejecutar la consulta
                conexion.Open();
                MySqlCommand command = new MySqlCommand(sql, conexion);
                command.ExecuteNonQuery();
                conexion.Close();

                // Actualizar el DataGridView
                tablaempleados.Rows.RemoveAt(tablaempleados.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar o la fila seleccionada no tiene registros");
            }
        }
    }
}
