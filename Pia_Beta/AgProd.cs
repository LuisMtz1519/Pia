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

        private void btn_reg_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "INSERT INTO Productos(clave, Nombre_Producto, Tipo_de_Producto, Existencia, Precio) VALUES('" + txt_Id.Text + "','" + txt_name.Text + "','" + txt_tipo.Text + "','" + txt_exist.Text + "','" + txt_prec.Text + "');";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            comando.ExecuteNonQuery();
            conexion.Close();

            MessageBox.Show("Se han Insertado los datos Correctamente");
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
