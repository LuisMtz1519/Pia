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
    }
}
