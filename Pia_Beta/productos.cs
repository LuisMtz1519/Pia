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
    public partial class Inventarios : Form
    {
        public Inventarios()
        {
            InitializeComponent();
        }

        private void Inventarios_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "(SELECT * FROM productos)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable table = new DataTable();
            adapter.Fill(table);
            tablainv.DataSource = table;
            conexion.Close();
        }

        private void btn_Agg_Click(object sender, EventArgs e)
        {
            AgProd mainmenu = new AgProd();
            mainmenu.Show();
        }

        private void btn_Del_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = bd_conexion.ConectarBD();
            if (tablainv.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(tablainv.SelectedRows[0].Cells[0].Value);

                // Crear la consulta para eliminar el registro con el ID seleccionado (ajustar el nombre de la tabla y columna según su configuración)
                string sql = "DELETE FROM Productos WHERE IdProducto='" + selectedId + "';";

                // Abrir la conexión y ejecutar la consulta
                conexion.Open();
                MySqlCommand command = new MySqlCommand(sql, conexion);
                command.ExecuteNonQuery();
                conexion.Close();

                // Actualizar el DataGridView
                tablainv.Rows.RemoveAt(tablainv.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }

            /*
            MySqlConnection conexion = bd_conexion.ConectarBD();
            // Obtener el valor de la columna del ID (ajustar el nombre y índice de la columna según su configuración)
            int selectedId = Convert.ToInt32(tablainv.SelectedRows[0].Cells[0].Value);

            // Crear la consulta para eliminar el registro con el ID seleccionado (ajustar el nombre de la tabla y columna según su configuración)
            string sql = "DELETE FROM Productos WHERE IdProducto='" + selectedId + "';";

            // Abrir la conexión y ejecutar la consulta
            conexion.Open();
            MySqlCommand command = new MySqlCommand(sql, conexion);
            command.ExecuteNonQuery();
            conexion.Close();

            // Actualizar el DataGridView
            tablainv.Rows.RemoveAt(tablainv.SelectedRows[0].Index);*/



            /*MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "DELETE FROM productos WHERE IdProducto='" + selectedId + "';";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                reader = comando.ExecuteReader();
                reader.Close();
                tablainv.Rows.Clear();
                tablainv.Refresh();
                MessageBox.Show("Se Han eliminado correctamente los registros Seleccionados");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "(SELECT * FROM Productos)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable table = new DataTable();
            adapter.Fill(table);
            tablainv.DataSource = table;
            conexion.Close();
        }
    }
}