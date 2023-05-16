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
    }
}
