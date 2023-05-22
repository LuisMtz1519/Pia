namespace Pia_Beta
{
    partial class LoginPrin
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
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            passtxt = new TextBox();
            usrtxt = new TextBox();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(311, 144);
            label2.Name = "label2";
            label2.Size = new Size(108, 25);
            label2.TabIndex = 15;
            label2.Text = "Contraseña";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(311, 65);
            label1.Name = "label1";
            label1.Size = new Size(77, 25);
            label1.TabIndex = 14;
            label1.Text = "Usuario";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(469, 249);
            button1.Name = "button1";
            button1.Size = new Size(152, 32);
            button1.TabIndex = 13;
            button1.Text = "Ingresar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // passtxt
            // 
            passtxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            passtxt.Location = new Point(425, 144);
            passtxt.Name = "passtxt";
            passtxt.Size = new Size(217, 33);
            passtxt.TabIndex = 12;
            passtxt.TextChanged += passtxt_TextChanged;
            // 
            // usrtxt
            // 
            usrtxt.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            usrtxt.Location = new Point(425, 67);
            usrtxt.Name = "usrtxt";
            usrtxt.Size = new Size(217, 33);
            usrtxt.TabIndex = 11;
            usrtxt.KeyPress += usrtxt_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 342);
            panel1.TabIndex = 10;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo_beta;
            pictureBox1.Location = new Point(22, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 248);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // LoginPrin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(791, 342);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(passtxt);
            Controls.Add(usrtxt);
            Controls.Add(panel1);
            Name = "LoginPrin";
            Text = "LoginPrin";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label1;
        private Button button1;
        private TextBox passtxt;
        private TextBox usrtxt;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}