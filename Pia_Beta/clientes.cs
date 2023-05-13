﻿using MySql.Data.MySqlClient;
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
using System.Xml.Schema;

namespace Pia_Beta
{
    public partial class clientes : Form
    {
        string id_sel = "";
        int sel;
        public clientes()
        {
            InitializeComponent();
        }

        private void clientes_Load(object sender, EventArgs e)
        {
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "(SELECT * FROM Clientes)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable table = new DataTable();
            adapter.Fill(table);
            tablaclientes.DataSource = table;
            conexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NCliente mainmenu = new NCliente();
            mainmenu.Show();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            id_sel = tablaclientes.Rows[sel].Cells[0].Value.ToString();
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "DELETE FROM Clientes WHERE idClientes='"+id_sel+"';";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                reader = comando.ExecuteReader();
                reader.Close();
                tablaclientes.Rows.Clear();
                tablaclientes.Refresh();
                MessageBox.Show("Se Han eliminado correctamente los registros Seleccionados");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection conexion = bd_conexion.ConectarBD();
            conexion.Open();

            string sql = "(SELECT * FROM Clientes)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = comando;
            DataTable table = new DataTable();
            adapter.Fill(table);
            tablaclientes.DataSource = table;
            conexion.Close();
        }
    }
}
