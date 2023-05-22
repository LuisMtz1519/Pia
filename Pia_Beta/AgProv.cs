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
        private bool CamposEstanLlenos()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.Focus();
                        return false;
                    }
                }
            }
            return true;
        }
        private void btn_reg_Click(object sender, EventArgs e)
        {
            if (CamposEstanLlenos())
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
            else
            {
                MessageBox.Show("Todos los campos deben de estar llenos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                MessageBox.Show("Caracter Invalido \n Solo Permite Texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_rzn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                MessageBox.Show("Caracter Invalido \n Solo Permite Texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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
    }
}
