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
using System.Xml.Schema;

namespace Pia_Beta
{
    public partial class clientes : Form
    {
        public clientes()
        {
            InitializeComponent();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "(SELECT * FROM Clientes)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable table = new DataTable();
            adapter.Fill(table);
            tablaclientes.DataSource = table;
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NCliente mainmenu = new NCliente();
            mainmenu.Show();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = bd_conexion.ConectarBD();
            if (tablaclientes.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(tablaclientes.SelectedRows[0].Cells[0].Value);

                // Crear la consulta para eliminar el registro con el ID seleccionado (ajustar el nombre de la tabla y columna según su configuración)
                string sql = "DELETE FROM Clientes WHERE IdClientes='" + selectedId + "';";

                // Abrir la conexión y ejecutar la consulta
                conexion.Open();
                MySqlCommand command = new MySqlCommand(sql, conexion);
                command.ExecuteNonQuery();
                conexion.Close();

                // Actualizar el DataGridView
                tablaclientes.Rows.RemoveAt(tablaclientes.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "(SELECT * FROM Clientes)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable table = new DataTable();
            adapter.Fill(table);
            tablaclientes.DataSource = table;
            conexion.Close();
        }
    }
}
