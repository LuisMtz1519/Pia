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
        string id_sel = "";
        int sel;
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
            id_sel = tablainv.Rows[sel].Cells[0].Value.ToString();
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "DELETE FROM productos WHERE IdProducto='" + id_sel + "';";
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
            }
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