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
    public partial class PrincipalBeta : Form
    {
        public PrincipalBeta()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "LiveOak Punto De Venta " +
                "\n" +
                "\n Version: VB1.0" +
                "\n Beta Version"
           );
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
            Perfil mainmenu = new Perfil();
            mainmenu.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ventas mainmenu = new ventas();
            mainmenu.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clientes mainmenu = new clientes();
            mainmenu.Show();
        }
    }
}
