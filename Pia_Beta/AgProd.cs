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
    public partial class AgProd : Form
    {
        public AgProd()
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

                string sql = "INSERT INTO Productos(clave, Nombre_Producto, Tipo_de_Producto, Existencia, Precio) VALUES('" + txt_Id.Text + "','" + txt_name.Text + "','" + txt_tipo.Text + "','" + txt_exist.Text + "','" + txt_prec.Text + "');";
                MySqlCommand comando = new MySqlCommand(sql, conexion);

                comando.ExecuteNonQuery();
                conexion.Close();

                MessageBox.Show("Se han Insertado los datos Correctamente");

                txt_Id.Clear();
                txt_name.Clear();
                txt_tipo.Clear();
                txt_exist.Clear();
                txt_prec.Clear();
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

        private void txt_exist_KeyPress(object sender, KeyPressEventArgs e)
        {
                        if (!char.IsNumber(e.KeyChar) && e.KeyChar != '\b')
            {
                MessageBox.Show("Solo Permite Caracteres Numericos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_prec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                MessageBox.Show("Caracter Invalido \n Solo permite Numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txt_tipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b')
            {
                MessageBox.Show("Caracter Invalido \n Solo Permite Texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
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
    }
}
