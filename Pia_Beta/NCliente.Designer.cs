namespace Pia_Beta
{
    partial class NCliente
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
            label1 = new Label();
            txt_name = new TextBox();
            label2 = new Label();
            txt_apellido = new TextBox();
            label3 = new Label();
            txt_dire = new TextBox();
            txt_tel = new TextBox();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            btn_reg = new Button();
            btn_close = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 72);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 9;
            label1.Text = "Nombres";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(196, 73);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(165, 23);
            txt_name.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(59, 160);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 11;
            label2.Text = "Apellidos";
            // 
            // txt_apellido
            // 
            txt_apellido.Location = new Point(196, 161);
            txt_apellido.Name = "txt_apellido";
            txt_apellido.Size = new Size(165, 23);
            txt_apellido.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(56, 325);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 13;
            label3.Text = "Telefono";
            // 
            // txt_dire
            // 
            txt_dire.Location = new Point(196, 236);
            txt_dire.Name = "txt_dire";
            txt_dire.Size = new Size(165, 23);
            txt_dire.TabIndex = 16;
            // 
            // txt_tel
            // 
            txt_tel.Location = new Point(196, 322);
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(165, 23);
            txt_tel.TabIndex = 18;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(56, 235);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 17;
            label5.Text = "Direccion";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.clientes1;
            pictureBox1.Location = new Point(405, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 313);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btn_reg
            // 
            btn_reg.Location = new Point(405, 395);
            btn_reg.Name = "btn_reg";
            btn_reg.Size = new Size(121, 26);
            btn_reg.TabIndex = 20;
            btn_reg.Text = "Registrar";
            btn_reg.UseVisualStyleBackColor = true;
            btn_reg.Click += btn_reg_Click;
            // 
            // btn_close
            // 
            btn_close.Location = new Point(586, 395);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(121, 26);
            btn_close.TabIndex = 21;
            btn_close.Text = "Cerrar";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // NCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(747, 457);
            Controls.Add(btn_close);
            Controls.Add(btn_reg);
            Controls.Add(pictureBox1);
            Controls.Add(txt_tel);
            Controls.Add(label5);
            Controls.Add(txt_dire);
            Controls.Add(txt_apellido);
            Controls.Add(label3);
            Controls.Add(txt_name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NCliente";
            Text = "NCliente";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txt_name;
        private Label label2;
        private TextBox txt_apellido;
        private Label label3;
        private TextBox txt_dire;
        private TextBox txt_tel;
        private Label label5;
        private PictureBox pictureBox1;
        private Button btn_reg;
        private Button btn_close;
    }
}