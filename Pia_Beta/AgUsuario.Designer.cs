namespace Pia_Beta
{
    partial class AgUsuario
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
            label8 = new Label();
            txt_tel = new TextBox();
            txt_mail = new TextBox();
            txt_city = new TextBox();
            txt_dir = new TextBox();
            txt_ape = new TextBox();
            txt_name = new TextBox();
            txt_usr = new TextBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmb_rol = new ComboBox();
            btn_close = new Button();
            btn_reg = new Button();
            txt_contraseña = new TextBox();
            label9 = new Label();
            img_pass = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)img_pass).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(127, 169);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 32;
            label8.Text = "Rol:";
            // 
            // txt_tel
            // 
            txt_tel.Location = new Point(488, 362);
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(187, 23);
            txt_tel.TabIndex = 31;
            txt_tel.KeyPress += txt_tel_KeyPress;
            // 
            // txt_mail
            // 
            txt_mail.Location = new Point(488, 310);
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(187, 23);
            txt_mail.TabIndex = 30;
            // 
            // txt_city
            // 
            txt_city.Location = new Point(488, 260);
            txt_city.Name = "txt_city";
            txt_city.Size = new Size(187, 23);
            txt_city.TabIndex = 29;
            txt_city.KeyPress += txt_city_KeyPress;
            // 
            // txt_dir
            // 
            txt_dir.Location = new Point(203, 366);
            txt_dir.Name = "txt_dir";
            txt_dir.Size = new Size(182, 23);
            txt_dir.TabIndex = 28;
            // 
            // txt_ape
            // 
            txt_ape.Location = new Point(203, 313);
            txt_ape.Name = "txt_ape";
            txt_ape.Size = new Size(182, 23);
            txt_ape.TabIndex = 27;
            txt_ape.KeyPress += txt_ape_KeyPress;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(203, 260);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(182, 23);
            txt_name.TabIndex = 26;
            txt_name.KeyPress += txt_name_KeyPress;
            // 
            // txt_usr
            // 
            txt_usr.Location = new Point(203, 83);
            txt_usr.Name = "txt_usr";
            txt_usr.Size = new Size(165, 23);
            txt_usr.TabIndex = 25;
            txt_usr.KeyPress += txt_usr_KeyPress;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.usuario__1_;
            pictureBox1.Location = new Point(468, 62);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(185, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(419, 365);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 23;
            label7.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(419, 309);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 22;
            label6.Text = "Correo:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(419, 259);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 21;
            label5.Text = "Ciudad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(126, 367);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 20;
            label4.Text = "Direccion:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(126, 312);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 19;
            label3.Text = "Apellidos:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(126, 259);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 18;
            label2.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(127, 83);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 17;
            label1.Text = "Usuario:";
            // 
            // cmb_rol
            // 
            cmb_rol.FormattingEnabled = true;
            cmb_rol.Items.AddRange(new object[] { "Administrador", "Usuario" });
            cmb_rol.Location = new Point(203, 166);
            cmb_rol.Name = "cmb_rol";
            cmb_rol.Size = new Size(165, 23);
            cmb_rol.TabIndex = 33;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(633, 427);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(121, 26);
            btn_close.TabIndex = 49;
            btn_close.Text = "Cerrar";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btn_reg
            // 
            btn_reg.Location = new Point(452, 427);
            btn_reg.Name = "btn_reg";
            btn_reg.Size = new Size(121, 26);
            btn_reg.TabIndex = 48;
            btn_reg.Text = "Registrar";
            btn_reg.UseVisualStyleBackColor = true;
            btn_reg.Click += btn_reg_Click;
            // 
            // txt_contraseña
            // 
            txt_contraseña.Location = new Point(203, 121);
            txt_contraseña.Name = "txt_contraseña";
            txt_contraseña.Size = new Size(165, 23);
            txt_contraseña.TabIndex = 51;
            txt_contraseña.TextChanged += txt_contraseña_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(109, 120);
            label9.Name = "label9";
            label9.Size = new Size(83, 20);
            label9.TabIndex = 50;
            label9.Text = "Contraseña:";
            // 
            // img_pass
            // 
            img_pass.Image = Properties.Resources.show;
            img_pass.Location = new Point(374, 123);
            img_pass.Name = "img_pass";
            img_pass.Size = new Size(27, 21);
            img_pass.SizeMode = PictureBoxSizeMode.Zoom;
            img_pass.TabIndex = 52;
            img_pass.TabStop = false;
            img_pass.Click += pictureBox2_Click;
            // 
            // AgUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(821, 465);
            Controls.Add(img_pass);
            Controls.Add(txt_contraseña);
            Controls.Add(label9);
            Controls.Add(btn_close);
            Controls.Add(btn_reg);
            Controls.Add(cmb_rol);
            Controls.Add(label8);
            Controls.Add(txt_tel);
            Controls.Add(txt_mail);
            Controls.Add(txt_city);
            Controls.Add(txt_dir);
            Controls.Add(txt_ape);
            Controls.Add(txt_name);
            Controls.Add(txt_usr);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AgUsuario";
            Text = "AgUsuario";
            Load += AgUsuario_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)img_pass).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label8;
        private TextBox txt_tel;
        private TextBox txt_mail;
        private TextBox txt_city;
        private TextBox txt_dir;
        private TextBox txt_ape;
        private TextBox txt_name;
        private TextBox txt_usr;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmb_rol;
        private Button btn_close;
        private Button btn_reg;
        private TextBox txt_contraseña;
        private Label label9;
        private PictureBox img_pass;
    }
}