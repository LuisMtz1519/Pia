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
    public partial class LoginPrin : Form
    {
        public LoginPrin()
        {
            InitializeComponent();
        }
        private void usrtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                MessageBox.Show("El Id Es Solo de numeros");
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void passtxt_TextChanged(object sender, EventArgs e)
        {
            passtxt.UseSystemPasswordChar = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (usrtxt.Text == "1899692")
            {
                if (passtxt.Text == "7ufelhmo")
                {
                    MessageBox.Show("Bienvenido al sistema" + usrtxt.Text);
                    Form1 mainmenu = new Form1();
                    mainmenu.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("El Usuario No Existe");
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Apariencia Beta del Login" + "\nAlgunas Funciones no estan disponibles aun");
            Login_Beta mainmenu = new Login_Beta();
            mainmenu.Show();
            this.Hide();
        }

        private void bntCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
