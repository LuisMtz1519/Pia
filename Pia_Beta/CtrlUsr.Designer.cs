namespace Pia_Beta
{
    partial class CtrlUsr
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
            button3 = new Button();
            button1 = new Button();
            btn_Eliminar = new Button();
            tablaempleados = new DataGridView();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)tablaempleados).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Location = new Point(407, 27);
            button3.Name = "button3";
            button3.Size = new Size(125, 36);
            button3.TabIndex = 2;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.Location = new Point(62, 27);
            button1.Name = "button1";
            button1.Size = new Size(119, 36);
            button1.TabIndex = 0;
            button1.Text = "Nuevo Usuario";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(232, 27);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(123, 36);
            btn_Eliminar.TabIndex = 1;
            btn_Eliminar.Text = "Eliminar Usuario";
            btn_Eliminar.UseVisualStyleBackColor = true;
            btn_Eliminar.Click += btn_Eliminar_Click;
            // 
            // tablaempleados
            // 
            tablaempleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaempleados.Location = new Point(18, 139);
            tablaempleados.Name = "tablaempleados";
            tablaempleados.RowTemplate.Height = 25;
            tablaempleados.Size = new Size(800, 259);
            tablaempleados.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_Eliminar);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 100);
            panel1.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.grupo;
            pictureBox1.Location = new Point(266, 404);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 144);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // CtrlUsr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(892, 522);
            Controls.Add(pictureBox1);
            Controls.Add(tablaempleados);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CtrlUsr";
            Text = "CtrlUsr";
            Load += CtrlUsr_Load;
            ((System.ComponentModel.ISupportInitialize)tablaempleados).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button1;
        private Button btn_Eliminar;
        private DataGridView tablaempleados;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}