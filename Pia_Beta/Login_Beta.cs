using Pia_Beta.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pia_Beta
{
    public partial class Login_Beta : Form
    {
        public Login_Beta()
        {
            InitializeComponent();
        }

        //Mover_Forma sin barra de titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //Antigua Validacion
        private void lbUsr_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Validacion para aceptar solo caracter numero
            /*if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                MessageBox.Show("El Id Es Solo de numeros");
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }*/
        }

        private void LbContraseña_TextChanged(object sender, EventArgs e)
        {
            LbContraseña.UseSystemPasswordChar = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string usuario = lbUsr.Text;
            string contraseña = LbContraseña.Text;

            try
            {
                login ctrl = new login();
                string respuesta = ctrl.controlLog(usuario, contraseña);
                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    PrincipalBeta mainmenu = new PrincipalBeta();
                    mainmenu.Visible = true;
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lbl_lastlogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPrin mainmenu = new LoginPrin();
            mainmenu.Show();
            this.Hide();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbUsr_Enter(object sender, EventArgs e)
        {
            if (lbUsr.Text == "Usuario")
            {
                lbUsr.Text = "";
            }
        }

        private void LbContraseña_Enter(object sender, EventArgs e)
        {
            if (LbContraseña.Text == "Contraseña")
            {
                LbContraseña.Text = "";
                LbContraseña.UseSystemPasswordChar = true;
            }
        }

        private void lbUsr_Leave(object sender, EventArgs e)
        {
            if (lbUsr.Text == "")
            {
                lbUsr.Text = "Usuario";
            }
        }

        private void LbContraseña_Leave(object sender, EventArgs e)
        {
            if (LbContraseña.Text == "")
            {
                LbContraseña.Text = "Contraseña";
                LbContraseña.UseSystemPasswordChar = false;
            }
        }

        private void Login_Beta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (LbContraseña.UseSystemPasswordChar)
            {
                LbContraseña.UseSystemPasswordChar = false;
                pass_img.Image = Properties.Resources.esconder;
            }
            else
            {
                LbContraseña.UseSystemPasswordChar = true;
                pass_img.Image = Properties.Resources.show;
            }
        }
    }
}
