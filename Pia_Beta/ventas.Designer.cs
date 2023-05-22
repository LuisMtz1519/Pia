namespace Pia_Beta
{
    partial class ventas
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
            label1 = new Label();
            txt_clave = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            label6 = new Label();
            lbl_usr = new Label();
            label5 = new Label();
            lbltotal = new Label();
            label3 = new Label();
            button4 = new Button();
            label2 = new Label();
            button2 = new Button();
            txt_precio = new TextBox();
            tabla_ventas = new DataGridView();
            Clve = new DataGridViewTextBoxColumn();
            Art = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Cant = new DataGridViewTextBoxColumn();
            Sub = new DataGridViewTextBoxColumn();
            txt_art = new TextBox();
            label4 = new Label();
            button3 = new Button();
            txt_cant = new TextBox();
            label7 = new Label();
            panel2 = new Panel();
            label8 = new Label();
            Btn_imprimir = new Button();
            btn_cancel = new Button();
            lbl_tk0 = new Label();
            txt_cambio = new TextBox();
            lbltotal2 = new Label();
            lbl_tk3 = new Label();
            lbl_tk1 = new Label();
            txt_pagocon = new TextBox();
            lbl_tk2 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabla_ventas).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(32, 38);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 0;
            label1.Text = "Codigo Producto";
            // 
            // txt_clave
            // 
            txt_clave.Location = new Point(153, 38);
            txt_clave.Name = "txt_clave";
            txt_clave.Size = new Size(218, 23);
            txt_clave.TabIndex = 1;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(456, 84);
            button1.Name = "button1";
            button1.Size = new Size(138, 36);
            button1.TabIndex = 2;
            button1.Text = "Agregar Producto";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(lbl_usr);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lbltotal);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 531);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 84);
            panel1.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(678, 28);
            label6.Name = "label6";
            label6.Size = new Size(38, 46);
            label6.TabIndex = 14;
            label6.Text = "$";
            // 
            // lbl_usr
            // 
            lbl_usr.AutoSize = true;
            lbl_usr.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_usr.ForeColor = Color.White;
            lbl_usr.Location = new Point(56, 49);
            lbl_usr.Name = "lbl_usr";
            lbl_usr.Size = new Size(0, 20);
            lbl_usr.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(71, 8);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 12;
            label5.Text = "Te Atiende";
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Font = new Font("Arial Narrow", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lbltotal.ForeColor = Color.White;
            lbltotal.Location = new Point(712, 28);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(83, 46);
            lbltotal.TabIndex = 11;
            lbltotal.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(722, 8);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 10;
            label3.Text = "Total";
            // 
            // button4
            // 
            button4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(514, 17);
            button4.Name = "button4";
            button4.Size = new Size(141, 54);
            button4.TabIndex = 0;
            button4.Text = "Cobrar";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(321, 92);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 8;
            label2.Text = "Cantidad";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(62, 476);
            button2.Name = "button2";
            button2.Size = new Size(104, 27);
            button2.TabIndex = 10;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // txt_precio
            // 
            txt_precio.Location = new Point(153, 131);
            txt_precio.Name = "txt_precio";
            txt_precio.Size = new Size(151, 23);
            txt_precio.TabIndex = 11;
            // 
            // tabla_ventas
            // 
            tabla_ventas.AllowUserToDeleteRows = false;
            tabla_ventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla_ventas.Columns.AddRange(new DataGridViewColumn[] { Clve, Art, Precio, Cant, Sub });
            tabla_ventas.Location = new Point(32, 172);
            tabla_ventas.Name = "tabla_ventas";
            tabla_ventas.ReadOnly = true;
            tabla_ventas.RowTemplate.Height = 25;
            tabla_ventas.Size = new Size(593, 270);
            tabla_ventas.TabIndex = 14;
            // 
            // Clve
            // 
            Clve.HeaderText = "Clave";
            Clve.Name = "Clve";
            Clve.ReadOnly = true;
            // 
            // Art
            // 
            Art.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Art.HeaderText = "Articulo";
            Art.Name = "Art";
            Art.ReadOnly = true;
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.Name = "Precio";
            Precio.ReadOnly = true;
            // 
            // Cant
            // 
            Cant.HeaderText = "Cantidad";
            Cant.Name = "Cant";
            Cant.ReadOnly = true;
            // 
            // Sub
            // 
            Sub.HeaderText = "Subtotal";
            Sub.Name = "Sub";
            Sub.ReadOnly = true;
            // 
            // txt_art
            // 
            txt_art.Location = new Point(153, 89);
            txt_art.Name = "txt_art";
            txt_art.Size = new Size(151, 23);
            txt_art.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(72, 134);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 15;
            label4.Text = "Precio";
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(456, 30);
            button3.Name = "button3";
            button3.Size = new Size(138, 36);
            button3.TabIndex = 17;
            button3.Text = "Buscar Producto";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_cant
            // 
            txt_cant.Location = new Point(401, 92);
            txt_cant.Name = "txt_cant";
            txt_cant.Size = new Size(31, 23);
            txt_cant.TabIndex = 18;
            txt_cant.KeyPress += txt_cant_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(62, 89);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 19;
            label7.Text = "Articulos";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 36, 40);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(Btn_imprimir);
            panel2.Controls.Add(btn_cancel);
            panel2.Controls.Add(lbl_tk0);
            panel2.Controls.Add(txt_cambio);
            panel2.Controls.Add(lbltotal2);
            panel2.Controls.Add(lbl_tk3);
            panel2.Controls.Add(lbl_tk1);
            panel2.Controls.Add(txt_pagocon);
            panel2.Controls.Add(lbl_tk2);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(643, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 531);
            panel2.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(49, 0);
            label8.Name = "label8";
            label8.Size = new Size(104, 20);
            label8.TabIndex = 23;
            label8.Text = "TICKET VENTA";
            // 
            // Btn_imprimir
            // 
            Btn_imprimir.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Btn_imprimir.Location = new Point(22, 275);
            Btn_imprimir.Name = "Btn_imprimir";
            Btn_imprimir.Size = new Size(154, 34);
            Btn_imprimir.TabIndex = 20;
            Btn_imprimir.Text = "Cobrar - Imprimir";
            Btn_imprimir.UseVisualStyleBackColor = true;
            Btn_imprimir.Click += Btn_imprimir_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancel.Location = new Point(23, 220);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(154, 34);
            btn_cancel.TabIndex = 18;
            btn_cancel.Text = "Cancelar";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // lbl_tk0
            // 
            lbl_tk0.AutoSize = true;
            lbl_tk0.Font = new Font("Arial Narrow", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tk0.ForeColor = Color.White;
            lbl_tk0.Location = new Point(36, 50);
            lbl_tk0.Name = "lbl_tk0";
            lbl_tk0.Size = new Size(38, 46);
            lbl_tk0.TabIndex = 17;
            lbl_tk0.Text = "$";
            // 
            // txt_cambio
            // 
            txt_cambio.Location = new Point(23, 176);
            txt_cambio.Name = "txt_cambio";
            txt_cambio.Size = new Size(153, 23);
            txt_cambio.TabIndex = 9;
            // 
            // lbltotal2
            // 
            lbltotal2.AutoSize = true;
            lbltotal2.Font = new Font("Arial Narrow", 30F, FontStyle.Bold, GraphicsUnit.Point);
            lbltotal2.ForeColor = Color.White;
            lbltotal2.Location = new Point(70, 50);
            lbltotal2.Name = "lbltotal2";
            lbltotal2.Size = new Size(83, 46);
            lbltotal2.TabIndex = 16;
            lbltotal2.Text = "0.00";
            // 
            // lbl_tk3
            // 
            lbl_tk3.AutoSize = true;
            lbl_tk3.Font = new Font("Arial Narrow", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tk3.ForeColor = Color.White;
            lbl_tk3.Location = new Point(47, 149);
            lbl_tk3.Name = "lbl_tk3";
            lbl_tk3.Size = new Size(95, 24);
            lbl_tk3.TabIndex = 8;
            lbl_tk3.Text = "Su Cambio";
            // 
            // lbl_tk1
            // 
            lbl_tk1.AutoSize = true;
            lbl_tk1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tk1.ForeColor = Color.White;
            lbl_tk1.Location = new Point(80, 30);
            lbl_tk1.Name = "lbl_tk1";
            lbl_tk1.Size = new Size(40, 20);
            lbl_tk1.TabIndex = 15;
            lbl_tk1.Text = "Total";
            // 
            // txt_pagocon
            // 
            txt_pagocon.Location = new Point(23, 123);
            txt_pagocon.Name = "txt_pagocon";
            txt_pagocon.Size = new Size(153, 23);
            txt_pagocon.TabIndex = 7;
            txt_pagocon.TextChanged += txt_pagocon_TextChanged;
            txt_pagocon.KeyPress += txt_pagocon_KeyPress;
            // 
            // lbl_tk2
            // 
            lbl_tk2.AutoSize = true;
            lbl_tk2.Font = new Font("Arial Narrow", 15F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tk2.ForeColor = Color.White;
            lbl_tk2.Location = new Point(55, 96);
            lbl_tk2.Name = "lbl_tk2";
            lbl_tk2.Size = new Size(87, 24);
            lbl_tk2.TabIndex = 6;
            lbl_tk2.Text = "Pago Con";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += Imprimir;
            // 
            // ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(843, 615);
            Controls.Add(panel2);
            Controls.Add(label7);
            Controls.Add(txt_cant);
            Controls.Add(button3);
            Controls.Add(txt_art);
            Controls.Add(label4);
            Controls.Add(tabla_ventas);
            Controls.Add(txt_precio);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(txt_clave);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Location = new Point(181, 25);
            Name = "ventas";
            Text = "ventas";
            Load += ventas_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tabla_ventas).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_clave;
        private Button button1;
        private Panel panel1;
        private Button button4;
        private Label label2;
        private Button button2;
        private Label label3;
        private Label lbl_usr;
        private Label label5;
        private TextBox txt_precio;
        private TextBox txt_art;
        private Label label4;
        private Label label6;
        private Button button3;
        private TextBox txt_cant;
        private Label label7;
        private DataGridViewTextBoxColumn Clve;
        private DataGridViewTextBoxColumn Art;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Cant;
        private DataGridViewTextBoxColumn Sub;
        public Label lbltotal;
        private Panel panel2;
        private Label lbl_tk0;
        private TextBox txt_cambio;
        public Label lbltotal2;
        private Label lbl_tk3;
        private Label lbl_tk1;
        private TextBox txt_pagocon;
        private Label lbl_tk2;
        private Button Btn_imprimir;
        private Button btn_cancel;
        private Label label8;
        private System.Drawing.Printing.PrintDocument printDocument1;
        public DataGridView tabla_ventas;
    }
}