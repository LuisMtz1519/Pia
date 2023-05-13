using MySql.Data.MySqlClient;
using Pia_Beta.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pia_Beta
{
    public partial class NCliente : Form
    {
        public NCliente()
        {
            InitializeComponent();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "INSERT INTO Clientes(Nombre, Apellido, Direccion, Telefono) VALUES('" + txt_name.Text + "','" + txt_apellido.Text + "','" + txt_dire.Text + "','" + txt_tel.Text + "');";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            comando.ExecuteNonQuery();
            conexion.Close();

            MessageBox.Show("Se han Insertado los datos Correctamente del client@ " + txt_name.Text + " " + txt_apellido.Text);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
