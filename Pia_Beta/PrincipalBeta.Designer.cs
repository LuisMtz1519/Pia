namespace Pia_Beta
{
    partial class PrincipalBeta
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btn_cerrar = new PictureBox();
            Btn_Restaorar = new PictureBox();
            btn_min = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            button5 = new Button();
            button8 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            button7 = new Button();
            pictureBox1 = new PictureBox();
            button6 = new Button();
            time_Beta = new System.Windows.Forms.Timer(components);
            contenedor = new Panel();
            lb_hr = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Restaorar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_min).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            contenedor.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(44, 44, 44);
            panel1.Controls.Add(btn_cerrar);
            panel1.Controls.Add(Btn_Restaorar);
            panel1.Controls.Add(btn_min);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 25);
            panel1.TabIndex = 0;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // btn_cerrar
            // 
            btn_cerrar.Image = Properties.Resources.cerrar;
            btn_cerrar.Location = new Point(1008, 3);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(13, 15);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 11;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // Btn_Restaorar
            // 
            Btn_Restaorar.Image = Properties.Resources.restaurar;
            Btn_Restaorar.Location = new Point(989, 3);
            Btn_Restaorar.Name = "Btn_Restaorar";
            Btn_Restaorar.Size = new Size(13, 15);
            Btn_Restaorar.SizeMode = PictureBoxSizeMode.Zoom;
            Btn_Restaorar.TabIndex = 13;
            Btn_Restaorar.TabStop = false;
            Btn_Restaorar.Click += Btn_Restaorar_Click;
            // 
            // btn_min
            // 
            btn_min.Image = Properties.Resources.minimizar;
            btn_min.Location = new Point(970, 3);
            btn_min.Name = "btn_min";
            btn_min.Size = new Size(13, 15);
            btn_min.SizeMode = PictureBoxSizeMode.Zoom;
            btn_min.TabIndex = 12;
            btn_min.TabStop = false;
            btn_min.Click += btn_min_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(495, 0);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 9;
            label1.Text = "LIVE OAK PUNTO DE VENTA";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(34, 36, 40);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(button6);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 25);
            panel2.Name = "panel2";
            panel2.Size = new Size(178, 615);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Red;
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(0, 571);
            button5.Name = "button5";
            button5.Size = new Size(178, 42);
            button5.TabIndex = 14;
            button5.Text = "Cerrar Sesion";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button8
            // 
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 170, 109);
            button8.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 150, 109);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(0, 274);
            button8.Name = "button8";
            button8.Size = new Size(178, 42);
            button8.TabIndex = 13;
            button8.Text = "Provedores";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 170, 109);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 150, 109);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(0, 402);
            button4.Name = "button4";
            button4.Size = new Size(178, 42);
            button4.TabIndex = 11;
            button4.Text = "Control De Empleados";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 170, 109);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 150, 109);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 119);
            button3.Name = "button3";
            button3.Size = new Size(178, 42);
            button3.TabIndex = 10;
            button3.Text = "Perfil";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 170, 109);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 150, 109);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 322);
            button2.Name = "button2";
            button2.Size = new Size(178, 42);
            button2.TabIndex = 9;
            button2.Text = "Inventario";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 170, 109);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 150, 109);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 226);
            button1.Name = "button1";
            button1.Size = new Size(178, 42);
            button1.TabIndex = 8;
            button1.Text = "Clientes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button7
            // 
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 170, 109);
            button7.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 150, 109);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(0, 178);
            button7.Name = "button7";
            button7.Size = new Size(178, 42);
            button7.TabIndex = 7;
            button7.Text = "Ventas";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pruab2;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(178, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button6
            // 
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(4, 170, 109);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(4, 150, 109);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(-3, 473);
            button6.Name = "button6";
            button6.Size = new Size(178, 42);
            button6.TabIndex = 5;
            button6.Text = "Acerca De";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // time_Beta
            // 
            time_Beta.Tick += time_Beta_Tick;
            // 
            // contenedor
            // 
            contenedor.Controls.Add(lb_hr);
            contenedor.Dock = DockStyle.Right;
            contenedor.Location = new Point(173, 25);
            contenedor.Name = "contenedor";
            contenedor.Size = new Size(851, 615);
            contenedor.TabIndex = 9;
            // 
            // lb_hr
            // 
            lb_hr.AutoSize = true;
            lb_hr.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_hr.ForeColor = Color.White;
            lb_hr.Location = new Point(733, 586);
            lb_hr.Name = "lb_hr";
            lb_hr.Size = new Size(0, 20);
            lb_hr.TabIndex = 0;
            // 
            // PrincipalBeta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(1024, 640);
            Controls.Add(contenedor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1366, 768);
            MinimumSize = new Size(960, 540);
            Name = "PrincipalBeta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PrincipalBeta";
            Load += PrincipalBeta_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)Btn_Restaorar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_min).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            contenedor.ResumeLayout(false);
            contenedor.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btn_min;
        private PictureBox btn_cerrar;
        private Panel panel2;
        private Button button6;
        private Label label1;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer time_Beta;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button7;
        private PictureBox Btn_Restaorar;
        private Panel contenedor;
        private Label lb_hr;
        private Button button8;
        private Button button5;
    }
}