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
    public partial class PrincipalBeta : Form
    {
        string rolusr = "";
        public PrincipalBeta()
        {
            InitializeComponent();
            //CARGA DE ROLES
            rolusr = sesion_log.rol;
            if (rolusr == "Administrador")
            {
                this.ctrl_usr.Visible = true;
                this.ctr_empleados.Visible = true;
            }
            else
            {
                this.ctrl_usr.Visible = false;
                this.ctr_empleados.Visible = false;
            }
        }
        //Mover_Forma sin barra de titulo
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Live Oak Version \n Version 2.0 Beta", "Acerca De", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        private void abrirFormHija(object formhija)
        {
            if (this.contenedor.Controls.Count > 0)
                this.contenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.contenedor.Controls.Add(fh);
            this.contenedor.Tag = fh;
            fh.Show();
        }
        private void PrincipalBeta_Load(object sender, EventArgs e)
        {
            time_Beta.Enabled = true;
        }

        private void time_Beta_Tick(object sender, EventArgs e)
        {
            lb_hr.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_Restaorar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //perfil
            abrirFormHija(new Perfil());
            /*
            Perfil mainmenu = new Perfil();
            mainmenu.Show();
            */
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //ventas
            abrirFormHija(new ventas());
            /*
            ventas mainmenu = new ventas();
            mainmenu.Show();
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Clientes
            abrirFormHija(new clientes());
            /*
            clientes mainmenu = new clientes();
            mainmenu.Show();
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Inventerios
            abrirFormHija(new Inventarios());
            /*
            Inventarios mainmenu = new Inventarios();
            mainmenu.Show();
            */
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //provedores
            abrirFormHija(new Provedores());
            /*
            Provedores mainmenu = new Provedores();
            mainmenu.Show();
            */
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Login_Beta mainmenu = new Login_Beta();
            mainmenu.Visible = true;
            this.Visible = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            abrirFormHija(new Empleados());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            abrirFormHija(new CtrlUsr());
        }

        private void contenedor_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
