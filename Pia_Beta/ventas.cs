﻿using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI.Relational;
using Pia_Beta.Clases;
using System.Drawing.Printing;
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
using System.Drawing.Text;

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
            tabla_ventas.Enabled = false;
            this.lbltotal2.Visible = false;
            this.lbl_tk0.Visible = false;
            this.lbl_tk1.Visible = false;
            this.lbl_tk2.Visible = false;
            this.lbl_tk3.Visible = false;
            this.txt_pagocon.Visible = false;
            this.txt_cambio.Visible = false;
            this.btn_cancel.Visible = false;
            this.Btn_imprimir.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_cant.Text))
            {
                MessageBox.Show("No ha ingresado la cantidad");
            }
            else
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
            if (string.IsNullOrWhiteSpace(txt_clave.Text))
            {
                MessageBox.Show("No ha ingresado la clave o la clave no existe");
            }
            else
            {
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
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tabla_ventas.RowCount > 1)
            {
                this.lbltotal2.Visible = true;
                this.lbl_tk0.Visible = true;
                this.lbl_tk1.Visible = true;
                this.lbl_tk2.Visible = true;
                this.lbl_tk3.Visible = true;
                this.txt_pagocon.Visible = true;
                this.txt_cambio.Visible = true;
                this.btn_cancel.Visible = true;
                this.Btn_imprimir.Visible = true;
            }
            else
            {
                MessageBox.Show("No ha registrado ninguna venta");
            }
        }

        private void txt_pagocon_TextChanged(object sender, EventArgs e)
        {
            decimal valortotal, valorpagocon;
            bool total = decimal.TryParse(lbltotal2.Text, out valortotal);
            bool pagocon = decimal.TryParse(txt_pagocon.Text, out valorpagocon);

            if (total && pagocon)
            {
                decimal resultado = valorpagocon - valortotal;

                txt_cambio.Text = resultado.ToString();
            }
        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_pagocon.Text))
            {
                MessageBox.Show("Ingrese el efectivo para continuar");
            }
            else
            {
                printDocument1 = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printDocument1.PrinterSettings = ps;
                printDocument1.PrintPage += Imprimir;
                printDocument1.Print();
            }
        }

        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            string time = DateTime.Now.ToLongDateString();
            DateTime horaActual = DateTime.Now;
            string horaExacta = horaActual.ToString("hh:mm:ss:tt");
            Font font = new Font("Arial", 11);
            int ancho = 350;
            int y = 20;

            e.Graphics.DrawString("=============TICKET=============", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("============LIVE OAK============", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("FECHA: " + time, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Hora: " + horaExacta, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Te atendio: " + lbl_usr.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("================================", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("============Productos===========", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            foreach (DataGridViewRow row in tabla_ventas.Rows)
            {
                e.Graphics.DrawString(row.Cells[1].Value + " " + row.Cells[2].Value + " " + row.Cells[3].Value + " " + row.Cells[4].Value, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            }

            e.Graphics.DrawString("===============================", font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Total: $" + lbltotal2.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Efectivo: $" + txt_pagocon.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));
            e.Graphics.DrawString("Su Cambio: $" + txt_cambio.Text, font, Brushes.Black, new RectangleF(0, y += 20, ancho, 20));

            e.Graphics.DrawString("===GRACIAS POR SU COMPRA===", font, Brushes.Black, new RectangleF(0, y += 24, ancho, 20));
            MessageBox.Show("Compra Generada Correctamente \n Su Ticket Se Ha Generado Correctamente\n a la hora: "+horaExacta, "Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabla_ventas.Rows.RemoveAt(tabla_ventas.SelectedRows[0].Index);
        }

        private void txt_cant_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}




