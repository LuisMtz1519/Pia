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
    public partial class ventas : Form
    {
        public ventas()
        {
            InitializeComponent();
        }

        private void ventas_Load(object sender, EventArgs e)
        {
            lbl_usr.Text = sesion_log.nombres + " " + sesion_log.apellidos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* string clave = txt_clave.Text;
            CProductos ctrl = new CProductos();
            string respuesta = ctrl.cons_prod(clave);*/
        }
    }
}
