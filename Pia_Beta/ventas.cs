using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            txt_art.Enabled = false;
            txt_precio.Enabled = false;
            txt_cambio.Enabled = false;
            Vista_prev.Enabled = false;
            tabla_ventas.Enabled = false;
            this.lbltotal2.Visible = false;
            this.lbl_tk0.Visible = false;
            this.lbl_tk1.Visible = false;
            this.lbl_tk2.Visible = false;
            this.lbl_tk3.Visible = false;
            this.lbl_tk4.Visible = false;
            this.txt_pagocon.Visible = false;
            this.txt_cambio.Visible = false;
            this.btn_cancel.Visible = false;
            this.btn_prev.Visible = false;
            this.Btn_imprimir.Visible = false;
            this.Vista_prev.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            DataGridViewRow file = new DataGridViewRow();
            file.CreateCells(tabla_ventas);
            file.Cells[0].Value = txt_clave.Text;
            file.Cells[1].Value = txt_art.Text;
            file.Cells[2].Value = txt_precio.Text;
            file.Cells[3].Value = txt_cant.Text;
            file.Cells[4].Value = Convert.ToDouble(txt_precio.Text) * Convert.ToDouble(txt_cant.Text);
            tabla_ventas.Rows.Add(file);

            total();

        }

        private void total()
        {
            double suma = 0;
            foreach (DataGridViewRow fila in tabla_ventas.Rows)
            {
                // Asegúrate de comprobar que la celda no esté vacía antes de sumar
                if (fila.Cells[4].Value != null)
                {
                    double valorCelda = Convert.ToDouble(fila.Cells[4].Value);
                    suma += valorCelda;
                    lbltotal.Text = suma.ToString();
                    lbltotal2.Text = suma.ToString();
                }
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            string clave = txt_clave.Text;

            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "(SELECT clave, Nombre_Producto, Precio FROM Productos Where clave = @clave)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("clave", clave);
            MySqlDataReader reader = comando.ExecuteReader();

            if (reader.Read())
            {
                txt_art.Text = reader["Nombre_Producto"].ToString();
                txt_precio.Text = reader["Precio"].ToString();
            }
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.lbltotal2.Visible = true;
            this.lbl_tk0.Visible = true;
            this.lbl_tk1.Visible = true;
            this.lbl_tk2.Visible = true;
            this.lbl_tk3.Visible = true;
            this.lbl_tk4.Visible = true;
            this.txt_pagocon.Visible = true;
            this.txt_cambio.Visible = true;
            this.btn_cancel.Visible = true;
            this.btn_prev.Visible = true;
            this.Btn_imprimir.Visible = true;
            this.Vista_prev.Visible = true;

            decimal valortotal, valorpagocon;
            bool total = decimal.TryParse(lbltotal2.Text, out valortotal);
            bool pagocon = decimal.TryParse(txt_pagocon.Text, out valorpagocon);

            if (total && pagocon)
            {
                decimal resultado = valorpagocon - valortotal;

                // Puedes mostrar el resultado en un Label o hacer lo que desees con él
                txt_cambio.Text = resultado.ToString();
            }
        }
    }
}
