namespace Pia_Beta
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
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido_Cl = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Tel = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(68, 38);
            button1.Name = "button1";
            button1.Size = new Size(95, 25);
            button1.TabIndex = 0;
            button1.Text = "Nuevo Cliente";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(417, 38);
            button2.Name = "button2";
            button2.Size = new Size(114, 25);
            button2.TabIndex = 1;
            button2.Text = "Eliminar Cliente";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(223, 38);
            button3.Name = "button3";
            button3.Size = new Size(114, 25);
            button3.TabIndex = 2;
            button3.Text = "Modificar Cliente";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Nombre, Apellido_Cl, Direccion, Tel });
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(36, 131);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(769, 421);
            dataGridView1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 100);
            panel1.TabIndex = 4;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombres";
            Nombre.Name = "Nombre";
            Nombre.Width = 200;
            // 
            // Apellido_Cl
            // 
            Apellido_Cl.HeaderText = "Apellido";
            Apellido_Cl.Name = "Apellido_Cl";
            Apellido_Cl.Width = 200;
            // 
            // Direccion
            // 
            Direccion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Direccion.HeaderText = "Direccion";
            Direccion.Name = "Direccion";
            // 
            // Tel
            // 
            Tel.HeaderText = "Telefono";
            Tel.Name = "Tel";
            // 
            // clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(847, 619);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "clientes";
            Text = "clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido_Cl;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Tel;
        private Panel panel1;
    }
}