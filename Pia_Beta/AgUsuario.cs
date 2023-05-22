using MySql.Data.MySqlClient;
using Pia_Beta.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Crud.Order.Types;
using System.Xml;

namespace Pia_Beta
{
    public partial class AgUsuario : Form
    {
        public AgUsuario()
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

        private void AgUsuario_Load(object sender, EventArgs e)
        {
            cmb_rol.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_reg_Click(object sender, EventArgs e)
        {
            if (CamposEstanLlenos())
            {
                MySqlConnection conexion = bd_conexion.ConectarBD();
                conexion.Open();

                string sql = "INSERT INTO Usuarios(usuario_log, contraseña, nombres, apellidos, direccion, ciudad, correo, telefono, rol) VALUES ('" + txt_usr.Text + "','" + txt_contraseña.Text + "','" + txt_name.Text + "','" + txt_ape.Text + "','" + txt_dir.Text + "','" + txt_city.Text + "','" + txt_mail.Text + "','" + txt_tel.Text + "', '" + cmb_rol.Text + "'); ";
                MySqlCommand comando = new MySqlCommand(sql, conexion);

                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("El usuario: " + txt_usr.Text + " Se ha registrado correctamente");
            }
            else
            {
                MessageBox.Show("Todos los campos deben de estar llenos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void txt_usr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
            {
                MessageBox.Show("El Nombre de usuario no debe de contener espacios", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                e.Handled = true;
            }
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

        private void txt_city_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && e.KeyChar != '\b')
            {
                MessageBox.Show("No permite Ingresar Caracteres Numericos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void txt_contraseña_TextChanged(object sender, EventArgs e)
        {
            txt_contraseña.UseSystemPasswordChar = true;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (txt_contraseña.UseSystemPasswordChar)
            {
                txt_contraseña.UseSystemPasswordChar = false;
                img_pass.Image = Properties.Resources.esconder;
            }
            else
            {
                txt_contraseña.UseSystemPasswordChar = true;
                img_pass.Image = Properties.Resources.show;
            }
        }
    }
}
