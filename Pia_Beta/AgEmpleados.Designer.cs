namespace Pia_Beta
{
    partial class AgEmpleados
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
            txt_tel = new TextBox();
            txt_mail = new TextBox();
            txt_city = new TextBox();
            txt_dir = new TextBox();
            txt_ape = new TextBox();
            txt_name = new TextBox();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btn_close = new Button();
            btn_reg = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txt_tel
            // 
            txt_tel.Location = new Point(202, 346);
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(187, 23);
            txt_tel.TabIndex = 31;
            // 
            // txt_mail
            // 
            txt_mail.Location = new Point(202, 292);
            txt_mail.Name = "txt_mail";
            txt_mail.Size = new Size(187, 23);
            txt_mail.TabIndex = 30;
            // 
            // txt_city
            // 
            txt_city.Location = new Point(202, 244);
            txt_city.Name = "txt_city";
            txt_city.Size = new Size(187, 23);
            txt_city.TabIndex = 29;
            // 
            // txt_dir
            // 
            txt_dir.Location = new Point(202, 194);
            txt_dir.Name = "txt_dir";
            txt_dir.Size = new Size(187, 23);
            txt_dir.TabIndex = 28;
            // 
            // txt_ape
            // 
            txt_ape.Location = new Point(202, 140);
            txt_ape.Name = "txt_ape";
            txt_ape.Size = new Size(187, 23);
            txt_ape.TabIndex = 27;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(202, 84);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(187, 23);
            txt_name.TabIndex = 26;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.empleado;
            pictureBox1.Location = new Point(459, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(286, 297);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(129, 345);
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
            label6.Location = new Point(133, 295);
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
            label5.Location = new Point(133, 247);
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
            label4.Location = new Point(125, 195);
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
            label3.Location = new Point(125, 139);
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
            label2.Location = new Point(125, 83);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 18;
            label2.Text = "Nombre:";
            // 
            // btn_close
            // 
            btn_close.Location = new Point(633, 424);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(121, 26);
            btn_close.TabIndex = 36;
            btn_close.Text = "Cerrar";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btn_reg
            // 
            btn_reg.Location = new Point(452, 424);
            btn_reg.Name = "btn_reg";
            btn_reg.Size = new Size(121, 26);
            btn_reg.TabIndex = 35;
            btn_reg.Text = "Registrar";
            btn_reg.UseVisualStyleBackColor = true;
            btn_reg.Click += btn_reg_Click;
            // 
            // AgEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(812, 474);
            Controls.Add(btn_close);
            Controls.Add(btn_reg);
            Controls.Add(txt_tel);
            Controls.Add(txt_mail);
            Controls.Add(txt_city);
            Controls.Add(txt_dir);
            Controls.Add(txt_ape);
            Controls.Add(txt_name);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "AgEmpleados";
            Text = "AgEmpleados";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txt_tel;
        private TextBox txt_mail;
        private TextBox txt_city;
        private TextBox txt_dir;
        private TextBox txt_ape;
        private TextBox txt_name;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_close;
        private Button btn_reg;
    }
}