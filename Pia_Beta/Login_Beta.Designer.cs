namespace Pia_Beta
{
    partial class Login_Beta
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            lbUsr = new TextBox();
            LbContraseña = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            btn_login = new Button();
            label1 = new Label();
            btn_cerrar = new PictureBox();
            btn_min = new PictureBox();
            lbl_lastlogin = new LinkLabel();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btn_min).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_beta;
            pictureBox1.Location = new Point(104, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(116, 73);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.usuario;
            pictureBox2.Location = new Point(38, 174);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(35, 29);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Contraseña;
            pictureBox3.Location = new Point(38, 234);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(35, 34);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            // 
            // lbUsr
            // 
            lbUsr.BackColor = Color.FromArgb(34, 36, 49);
            lbUsr.BorderStyle = BorderStyle.None;
            lbUsr.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbUsr.ForeColor = Color.White;
            lbUsr.Location = new Point(78, 177);
            lbUsr.Name = "lbUsr";
            lbUsr.Size = new Size(164, 18);
            lbUsr.TabIndex = 3;
            lbUsr.Text = "Usuario";
            lbUsr.Enter += lbUsr_Enter;
            lbUsr.KeyPress += lbUsr_KeyPress;
            lbUsr.Leave += lbUsr_Leave;
            // 
            // LbContraseña
            // 
            LbContraseña.BackColor = Color.FromArgb(34, 36, 49);
            LbContraseña.BorderStyle = BorderStyle.None;
            LbContraseña.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            LbContraseña.ForeColor = Color.White;
            LbContraseña.Location = new Point(76, 240);
            LbContraseña.Name = "LbContraseña";
            LbContraseña.Size = new Size(164, 18);
            LbContraseña.TabIndex = 4;
            LbContraseña.Text = "Contraseña";
            LbContraseña.TextChanged += LbContraseña_TextChanged;
            LbContraseña.Enter += LbContraseña_Enter;
            LbContraseña.Leave += LbContraseña_Leave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Location = new Point(76, 197);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 1);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Location = new Point(76, 258);
            panel2.Name = "panel2";
            panel2.Size = new Size(144, 1);
            panel2.TabIndex = 6;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(34, 36, 49);
            btn_login.Cursor = Cursors.Hand;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.FromArgb(4, 170, 109);
            btn_login.Location = new Point(118, 316);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(89, 30);
            btn_login.TabIndex = 7;
            btn_login.Text = "Ingresar";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(69, 102);
            label1.Name = "label1";
            label1.Size = new Size(190, 20);
            label1.TabIndex = 0;
            label1.Text = "LIVE OAK PUNTO DE VENTA";
            // 
            // btn_cerrar
            // 
            btn_cerrar.Image = Properties.Resources.cerrar;
            btn_cerrar.Location = new Point(306, 12);
            btn_cerrar.Name = "btn_cerrar";
            btn_cerrar.Size = new Size(13, 15);
            btn_cerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btn_cerrar.TabIndex = 9;
            btn_cerrar.TabStop = false;
            btn_cerrar.Click += btn_cerrar_Click;
            // 
            // btn_min
            // 
            btn_min.Image = Properties.Resources.minimizar;
            btn_min.Location = new Point(287, 12);
            btn_min.Name = "btn_min";
            btn_min.Size = new Size(13, 15);
            btn_min.SizeMode = PictureBoxSizeMode.Zoom;
            btn_min.TabIndex = 10;
            btn_min.TabStop = false;
            btn_min.Click += btn_min_Click;
            // 
            // lbl_lastlogin
            // 
            lbl_lastlogin.AutoSize = true;
            lbl_lastlogin.LinkColor = Color.FromArgb(4, 170, 109);
            lbl_lastlogin.Location = new Point(124, 373);
            lbl_lastlogin.Name = "lbl_lastlogin";
            lbl_lastlogin.Size = new Size(83, 15);
            lbl_lastlogin.TabIndex = 11;
            lbl_lastlogin.TabStop = true;
            lbl_lastlogin.Text = "Login Anterior";
            lbl_lastlogin.LinkClicked += lbl_lastlogin_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(267, 399);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 12;
            label2.Text = "V B1.0";
            // 
            // Login_Beta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(331, 428);
            Controls.Add(label2);
            Controls.Add(lbl_lastlogin);
            Controls.Add(btn_min);
            Controls.Add(btn_cerrar);
            Controls.Add(label1);
            Controls.Add(btn_login);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(LbContraseña);
            Controls.Add(lbUsr);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login_Beta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login_Beta";
            MouseDown += Login_Beta_MouseDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_cerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btn_min).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private TextBox lbUsr;
        private TextBox LbContraseña;
        private Panel panel1;
        private Panel panel2;
        private Button btn_login;
        private Label label1;
        private PictureBox btn_cerrar;
        private PictureBox btn_min;
        private LinkLabel lbl_lastlogin;
        private Label label2;
    }
}