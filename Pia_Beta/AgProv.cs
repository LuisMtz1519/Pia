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
    public partial class AgProv : Form
    {
        public AgProv()
        {
            InitializeComponent();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "INSERT INTO Provedores(nombre, razonsocial, direccion, telefono, correo) VALUES('" + txt_name.Text + "','" + txt_rzn.Text + "','" + txt_dir.Text + "','" + txt_tel.Text + "','" + txt_correo.Text + "');";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            comando.ExecuteNonQuery();
            conexion.Close();

            MessageBox.Show("Se han Insertado los datos Correctamente");
            txt_name.Clear();
            txt_rzn.Clear();
            txt_dir.Clear();
            txt_tel.Clear();
            txt_correo.Clear();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
