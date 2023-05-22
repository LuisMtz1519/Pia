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
    public partial class Provedores : Form
    {
        public Provedores()
        {
            InitializeComponent();
        }

        private void Provedores_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "(SELECT * FROM Provedores)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable table = new DataTable();
            adapter.Fill(table);
            tablaprov.DataSource = table;
            conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "(SELECT * FROM Provedores)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable table = new DataTable();
            adapter.Fill(table);
            tablaprov.DataSource = table;
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgProv mainmenu = new AgProv();
            mainmenu.Show();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = bd_conexion.ConectarBD();

            if (tablaprov.SelectedRows.Count > 0)
            {
                int selectedId = Convert.ToInt32(tablaprov.SelectedRows[0].Cells[0].Value);

                string sql = "DELETE FROM Productos WHERE IdProducto='" + selectedId + "';";
                conexion.Open();
                MySqlCommand command = new MySqlCommand(sql, conexion);
                command.ExecuteNonQuery();
                conexion.Close();

                tablaprov.Rows.RemoveAt(tablaprov.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar o la fila seleccionada no tiene registros.");
            }
        }
    }
}
