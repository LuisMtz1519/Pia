﻿namespace Pia_Beta
{
    partial class clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            btn_Eliminar = new Button();
            panel1 = new Panel();
            button3 = new Button();
            tablaclientes = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaclientes).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(62, 38);
            button1.Name = "button1";
            button1.Size = new Size(115, 25);
            button1.TabIndex = 0;
            button1.Text = "Nuevo Cliente";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(232, 38);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(114, 25);
            btn_Eliminar.TabIndex = 1;
            btn_Eliminar.Text = "Eliminar Cliente";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_Eliminar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 100);
            panel1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(407, 38);
            button3.Name = "button3";
            button3.Size = new Size(114, 25);
            button3.TabIndex = 2;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tablaclientes
            // 
            tablaclientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaclientes.Location = new Point(30, 137);
            tablaclientes.Name = "tablaclientes";
            tablaclientes.RowTemplate.Height = 25;
            tablaclientes.Size = new Size(779, 215);
            tablaclientes.TabIndex = 5;
            // 
            // clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(847, 619);
            Controls.Add(tablaclientes);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "clientes";
            Text = "clientes";
            Load += clientes_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablaclientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button btn_Eliminar;
        private Panel panel1;
        private DataGridView tablaclientes;
        private Button button3;
    }
}