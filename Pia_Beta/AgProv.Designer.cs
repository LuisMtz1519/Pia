namespace Pia_Beta
{
    partial class AgProv
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
            txt_tel = new TextBox();
            label5 = new Label();
            txt_dir = new TextBox();
            txt_rzn = new TextBox();
            label3 = new Label();
            txt_name = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txt_correo = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btn_close
            // 
            btn_close.Location = new Point(603, 398);
            btn_close.Name = "btn_close";
            btn_close.Size = new Size(121, 26);
            btn_close.TabIndex = 47;
            btn_close.Text = "Cerrar";
            btn_close.UseVisualStyleBackColor = true;
            btn_close.Click += btn_close_Click;
            // 
            // btn_reg
            // 
            btn_reg.Location = new Point(422, 398);
            btn_reg.Name = "btn_reg";
            btn_reg.Size = new Size(121, 26);
            btn_reg.TabIndex = 46;
            btn_reg.Text = "Registrar";
            btn_reg.UseVisualStyleBackColor = true;
            btn_reg.Click += btn_reg_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.proveedor;
            pictureBox1.Location = new Point(443, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(281, 313);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 45;
            pictureBox1.TabStop = false;
            // 
            // txt_tel
            // 
            txt_tel.Location = new Point(214, 303);
            txt_tel.Name = "txt_tel";
            txt_tel.Size = new Size(165, 23);
            txt_tel.TabIndex = 44;
            txt_tel.KeyPress += txt_tel_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(77, 222);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 43;
            label5.Text = "Direccion";
            // 
            // txt_dir
            // 
            txt_dir.Location = new Point(214, 223);
            txt_dir.Name = "txt_dir";
            txt_dir.Size = new Size(165, 23);
            txt_dir.TabIndex = 42;
            // 
            // txt_rzn
            // 
            txt_rzn.Location = new Point(214, 139);
            txt_rzn.Name = "txt_rzn";
            txt_rzn.Size = new Size(165, 23);
            txt_rzn.TabIndex = 40;
            txt_rzn.KeyPress += txt_rzn_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(77, 302);
            label3.Name = "label3";
            label3.Size = new Size(63, 20);
            label3.TabIndex = 39;
            label3.Text = "Telefono";
            // 
            // txt_name
            // 
            txt_name.Location = new Point(214, 58);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(165, 23);
            txt_name.TabIndex = 38;
            txt_name.KeyPress += txt_name_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(77, 139);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 37;
            label2.Text = "Razon Social";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(77, 58);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 35;
            label1.Text = "Nombre";
            // 
            // txt_correo
            // 
            txt_correo.Location = new Point(214, 377);
            txt_correo.Name = "txt_correo";
            txt_correo.Size = new Size(165, 23);
            txt_correo.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(77, 377);
            label4.Name = "label4";
            label4.Size = new Size(51, 20);
            label4.TabIndex = 41;
            label4.Text = "Correo";
            // 
            // AgProv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(800, 450);
            Controls.Add(btn_close);
            Controls.Add(btn_reg);
            Controls.Add(pictureBox1);
            Controls.Add(txt_tel);
            Controls.Add(label5);
            Controls.Add(txt_dir);
            Controls.Add(label4);
            Controls.Add(txt_rzn);
            Controls.Add(label3);
            Controls.Add(txt_name);
            Controls.Add(label2);
            Controls.Add(txt_correo);
            Controls.Add(label1);
            Name = "AgProv";
            Text = "AgProv";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_close;
        private Button btn_reg;
        private PictureBox pictureBox1;
        private TextBox txt_tel;
        private Label label5;
        private TextBox txt_dir;
        private TextBox txt_rzn;
        private Label label3;
        private TextBox txt_name;
        private Label label2;
        private Label label1;
        private TextBox txt_correo;
        private Label label4;
    }
}