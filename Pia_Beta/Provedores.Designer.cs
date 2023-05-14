namespace Pia_Beta
{
    partial class Provedores
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
            tablaprov = new DataGridView();
            button3 = new Button();
            button1 = new Button();
            btn_Eliminar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)tablaprov).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tablaprov
            // 
            tablaprov.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaprov.Location = new Point(12, 127);
            tablaprov.Name = "tablaprov";
            tablaprov.RowTemplate.Height = 25;
            tablaprov.Size = new Size(776, 311);
            tablaprov.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(388, 38);
            button3.Name = "button3";
            button3.Size = new Size(116, 39);
            button3.TabIndex = 2;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(62, 38);
            button1.Name = "button1";
            button1.Size = new Size(116, 39);
            button1.TabIndex = 0;
            button1.Text = "Nuevo Proveedor";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(222, 38);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(116, 39);
            btn_Eliminar.TabIndex = 1;
            btn_Eliminar.Text = "Eliminar Proveedor";
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
            panel1.Size = new Size(800, 100);
            panel1.TabIndex = 6;
            // 
            // Provedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(800, 450);
            Controls.Add(tablaprov);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Provedores";
            Text = "Provedores";
            Load += Provedores_Load;
            ((System.ComponentModel.ISupportInitialize)tablaprov).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tablaprov;
        private Button button3;
        private Button button1;
        private Button btn_Eliminar;
        private Panel panel1;
    }
}