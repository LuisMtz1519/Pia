namespace Pia_Beta
{
    partial class AgProd
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
            btn_close = new Button();
            btn_reg = new Button();
            pictureBox1 = new PictureBox();
            txt_prec = new TextBox();
            label5 = new Label();
            txt_exist = new TextBox();
            txt_tipo = new TextBox();
            label3 = new Label();
            txt_name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txt_Id = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.Location = new Point(603, 387);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(121, 26);
            btn_close.TabIndex = 34;
            btn_close.Text = "Cerrar";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btn_reg
            // 
            btn_reg.Location = new Point(422, 387);
            btn_reg.Name = "btn_reg";
            btn_reg.Size = new Size(121, 26);
            btn_reg.TabIndex = 33;
            btn_reg.Text = "Registrar";
            btn_reg.UseVisualStyleBackColor = true;
            btn_reg.Click += btn_reg_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.foto21;
            pictureBox1.Location = new Point(422, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 338);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // txt_prec
            // 
            txt_prec.Location = new Point(213, 331);
            txt_prec.Name = "txt_prec";
            txt_prec.Size = new Size(165, 23);
            txt_prec.TabIndex = 31;
            txt_prec.KeyPress += txt_prec_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(76, 248);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 30;
            label5.Text = "Existencia";
            // 
            // txt_exist
            // 
            txt_exist.Location = new Point(213, 249);
            txt_exist.Name = "txt_exist";
            txt_exist.Size = new Size(165, 23);
            txt_exist.TabIndex = 29;
            txt_exist.KeyPress += txt_exist_KeyPress;
            // 
            // txt_tipo
            // 
            txt_tipo.Location = new Point(213, 169);
            txt_tipo.Name = "txt_tipo";
            txt_tipo.Size = new Size(165, 23);
            txt_tipo.TabIndex = 27;
            txt_tipo.KeyPress += txt_tipo_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(76, 330);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 26;
            label3.Text = "Precio";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(213, 103);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(165, 23);
            txt_name.TabIndex = 25;
            txt_name.KeyPress += txt_name_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(76, 168);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 24;
            label2.Text = "Tipo Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(76, 103);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 22;
            label1.Text = "Nombre Producto";
            // 
            // txt_Id
            // 
            txt_Id.Location = new Point(213, 37);
            txt_Id.Name = "txt_Id";
            txt_Id.Size = new Size(165, 23);
            txt_Id.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(76, 37);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 28;
            label4.Text = "clave";
            // 
            // AgProd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(800, 450);
            Controls.Add(btn_close);
            Controls.Add(btn_reg);
            Controls.Add(pictureBox1);
            Controls.Add(txt_prec);
            Controls.Add(label5);
            Controls.Add(txt_exist);
            Controls.Add(label4);
            Controls.Add(txt_tipo);
            Controls.Add(label3);
            Controls.Add(txt_name);
            Controls.Add(label2);
            Controls.Add(txt_Id);
            Controls.Add(label1);
            Name = "AgProd";
            Text = "AgProd";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_close;
        private Button btn_reg;
        private PictureBox pictureBox1;
        private TextBox txt_prec;
        private Label label5;
        private TextBox txt_exist;
        private TextBox txt_tipo;
        private Label label3;
        private TextBox txt_name;
        private Label label2;
        private Label label1;
        private TextBox txt_Id;
        private Label label4;
    }
}