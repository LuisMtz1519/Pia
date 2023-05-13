using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pia_Beta.Clases;

namespace Pia_Beta
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            txt_usr.Enabled = false;
            txt_name.Enabled = false;
            txt_ape.Enabled = false;
            txt_dir.Enabled = false;
            txt_city.Enabled = false;
            txt_mail.Enabled = false;
            txt_tel.Enabled = false;
            txt_rol.Enabled = false;

            txt_usr.Text = sesion_log.usuario_log;
            txt_name.Text = sesion_log.nombres;
            txt_ape.Text = sesion_log.apellidos;
            txt_dir.Text = sesion_log.direccion;
            txt_city.Text = sesion_log.ciudad;
            txt_mail.Text = sesion_log.correo;
            txt_tel.Text = sesion_log.telefono;
            txt_rol.Text = sesion_log.rol;

        }
    }
}
