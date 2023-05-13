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
            tablaclientes = new DataGridView();
            button3 = new Button();
            button1 = new Button();
            btn_Eliminar = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)tablaclientes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tablaclientes
            // 
            tablaclientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaclientes.Location = new Point(26, 186);
            tablaclientes.Name = "tablaclientes";
            tablaclientes.RowTemplate.Height = 25;
            tablaclientes.Size = new Size(779, 215);
            tablaclientes.TabIndex = 7;
            // 
            // button3
            // 
            button3.Location = new Point(407, 38);
            button3.Name = "button3";
            button3.Size = new Size(114, 25);
            button3.TabIndex = 2;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(62, 38);
            button1.Name = "button1";
            button1.Size = new Size(115, 25);
            button1.TabIndex = 0;
            button1.Text = "Nuevo Proveedor";
            button1.UseVisualStyleBackColor = true;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(219, 38);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(140, 25);
            btn_Eliminar.TabIndex = 1;
            btn_Eliminar.Text = "Eliminar Proveedor";
            btn_Eliminar.UseVisualStyleBackColor = true;
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
            Controls.Add(tablaclientes);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Provedores";
            Text = "Provedores";
            ((System.ComponentModel.ISupportInitialize)tablaclientes).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView tablaclientes;
        private Button button3;
        private Button button1;
        private Button btn_Eliminar;
        private Panel panel1;
    }
}