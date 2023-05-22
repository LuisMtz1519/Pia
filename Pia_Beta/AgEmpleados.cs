using MySql.Data.MySqlClient;
using Pia_Beta.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Pia_Beta
{
    public partial class AgEmpleados : Form
    {
        public AgEmpleados()
        {
            InitializeComponent();
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "INSERT INTO Empleados(nombres,apellidos, direccion, ciudad, correo, telefono) VALUES('" + txt_name.Text + "','" + txt_ape.Text + "','" + txt_dir.Text + "','" + txt_city.Text + "','" + txt_mail.Text + "','" + txt_tel.Text + "' );";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            comando.ExecuteNonQuery();
            conexion.Close();

            MessageBox.Show("Se han Insertado los datos Correctamente de: " + txt_name.Text + " " + txt_ape);

            txt_name.Clear();
            txt_ape.Clear();
            txt_dir.Clear();
            txt_city.Clear();
            txt_mail.Clear();
            txt_tel.Clear();

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                MessageBox.Show("No permite Ingresar Caracteres Numericos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_ape_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                MessageBox.Show("No permite Ingresar Caracteres Numericos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_dir_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                MessageBox.Show("Solo Permite Caracteres Numericos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_mail_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                MessageBox.Show("No permite Ingresar Caracteres Numericos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
    }
}
