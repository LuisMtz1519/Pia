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
            lbl_usr = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button4 = new Button();
            tabla_ventas = new DataGridView();
            Codigo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio_U = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            label2 = new Label();
            domainUpDown1 = new DomainUpDown();
            button2 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tabla_ventas).BeginInit();
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
            txt_clave.Size = new Size(202, 23);
            txt_clave.TabIndex = 1;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(593, 32);
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
            panel1.Controls.Add(lbl_usr);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(button4);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 531);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 84);
            panel1.TabIndex = 5;
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
            label5.Location = new Point(56, 8);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 12;
            label5.Text = "Te Atiende";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(681, 28);
            label4.Name = "label4";
            label4.Size = new Size(101, 46);
            label4.TabIndex = 11;
            label4.Text = "$0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(712, 8);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 10;
            label3.Text = "Total";
            // 
            // button4
            // 
            button4.Location = new Point(514, 17);
            button4.Name = "button4";
            button4.Size = new Size(141, 54);
            button4.TabIndex = 0;
            button4.Text = "Cobrar";
            button4.UseVisualStyleBackColor = true;
            // 
            // tabla_ventas
            // 
            tabla_ventas.BackgroundColor = Color.White;
            tabla_ventas.BorderStyle = BorderStyle.None;
            tabla_ventas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tabla_ventas.Columns.AddRange(new DataGridViewColumn[] { Codigo, Descripcion, Precio_U, Cantidad, Total });
            tabla_ventas.GridColor = SystemColors.Control;
            tabla_ventas.Location = new Point(32, 85);
            tabla_ventas.Name = "tabla_ventas";
            tabla_ventas.RowTemplate.Height = 25;
            tabla_ventas.Size = new Size(785, 363);
            tabla_ventas.TabIndex = 7;
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Clave Producto";
            Codigo.Name = "Codigo";
            // 
            // Descripcion
            // 
            Descripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Descripcion.HeaderText = "Articulo";
            Descripcion.Name = "Descripcion";
            // 
            // Precio_U
            // 
            Precio_U.HeaderText = "Precio Unitario";
            Precio_U.Name = "Precio_U";
            // 
            // Cantidad
            // 
            Cantidad.HeaderText = "Cantidad";
            Cantidad.Name = "Cantidad";
            // 
            // Total
            // 
            Total.HeaderText = "Total";
            Total.Name = "Total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(387, 39);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 8;
            label2.Text = "Cantidad";
            // 
            // domainUpDown1
            // 
            domainUpDown1.Location = new Point(457, 39);
            domainUpDown1.Name = "domainUpDown1";
            domainUpDown1.Size = new Size(38, 23);
            domainUpDown1.TabIndex = 9;
            domainUpDown1.Text = "1";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(62, 478);
            button2.Name = "button2";
            button2.Size = new Size(106, 25);
            button2.TabIndex = 10;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            // 
            // ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(843, 615);
            Controls.Add(domainUpDown1);
            Controls.Add(button2);
            Controls.Add(label2);
            Controls.Add(tabla_ventas);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_clave;
        private Button button1;
        private Panel panel1;
        private Button button4;
        private DataGridView tabla_ventas;
        private Label label2;
        private DomainUpDown domainUpDown1;
        private Label label4;
        private Button button2;
        private Label label3;
        private Label lbl_usr;
        private Label label5;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio_U;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Total;
    }
}