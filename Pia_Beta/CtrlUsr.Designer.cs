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
            ((System.ComponentModel.ISupportInitialize)tablaempleados).BeginInit();
            panel1.SuspendLayout();
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
            button1.Text = "Nuevo Empleado";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // btn_Eliminar
            // 
            btn_Eliminar.Location = new Point(232, 27);
            btn_Eliminar.Name = "btn_Eliminar";
            btn_Eliminar.Size = new Size(123, 36);
            btn_Eliminar.TabIndex = 1;
            btn_Eliminar.Text = "Eliminar Empleado";
            btn_Eliminar.UseVisualStyleBackColor = true;
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
            panel1.Size = new Size(838, 100);
            panel1.TabIndex = 8;
            // 
            // CtrlUsr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(838, 464);
            Controls.Add(tablaempleados);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CtrlUsr";
            Text = "CtrlUsr";
            Load += CtrlUsr_Load;
            ((System.ComponentModel.ISupportInitialize)tablaempleados).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button3;
        private Button button1;
        private Button btn_Eliminar;
        private DataGridView tablaempleados;
        private Panel panel1;
    }
}