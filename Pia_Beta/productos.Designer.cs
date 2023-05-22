namespace Pia_Beta
{
    partial class Inventarios
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
            btn_Agg = new Button();
            btn_Del = new Button();
            panel1 = new Panel();
            button1 = new Button();
            tablainv = new DataGridView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablainv).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btn_Agg
            // 
            btn_Agg.Location = new Point(54, 34);
            btn_Agg.Name = "btn_Agg";
            btn_Agg.Size = new Size(127, 38);
            btn_Agg.TabIndex = 0;
            btn_Agg.Text = "Agregar Productos";
            btn_Agg.UseVisualStyleBackColor = true;
            btn_Agg.Click += btn_Agg_Click;
            // 
            // btn_Del
            // 
            btn_Del.Location = new Point(234, 34);
            btn_Del.Name = "btn_Del";
            btn_Del.Size = new Size(127, 38);
            btn_Del.TabIndex = 1;
            btn_Del.Text = "Eliminar Productos";
            btn_Del.UseVisualStyleBackColor = true;
            btn_Del.Click += btn_Del_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btn_Del);
            panel1.Controls.Add(btn_Agg);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 97);
            panel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(408, 34);
            button1.Name = "button1";
            button1.Size = new Size(127, 38);
            button1.TabIndex = 2;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // tablainv
            // 
            tablainv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablainv.Location = new Point(54, 139);
            tablainv.Name = "tablainv";
            tablainv.RowTemplate.Height = 25;
            tablainv.Size = new Size(736, 269);
            tablainv.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.inventario;
            pictureBox1.Location = new Point(103, 442);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.la_gestion_del_inventario;
            pictureBox2.Location = new Point(561, 442);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(194, 165);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Inventarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(847, 619);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(tablainv);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inventarios";
            Text = "Inventarios";
            Load += Inventarios_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tablainv).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Agg;
        private Button btn_Del;
        private Panel panel1;
        private DataGridView tablainv;
        private Button button1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}