namespace Pia_Beta
{
    partial class RegCompra
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
            lbl_totpag = new Label();
            label3 = new Label();
            txt_pagocon = new TextBox();
            txt_cambio = new TextBox();
            label4 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            richTextBox1 = new RichTextBox();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label6 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(126, 23);
            label1.Name = "label1";
            label1.Size = new Size(157, 31);
            label1.TabIndex = 0;
            label1.Text = "Total A Pagar";
            // 
            // lbl_totpag
            // 
            lbl_totpag.AutoSize = true;
            lbl_totpag.Font = new Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_totpag.ForeColor = Color.White;
            lbl_totpag.Location = new Point(183, 71);
            lbl_totpag.Name = "lbl_totpag";
            lbl_totpag.Size = new Size(56, 31);
            lbl_totpag.TabIndex = 1;
            lbl_totpag.Text = "0.00";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(62, 178);
            label3.Name = "label3";
            label3.Size = new Size(87, 24);
            label3.TabIndex = 2;
            label3.Text = "Pago Con";
            // 
            // txt_pagocon
            // 
            txt_pagocon.Location = new Point(158, 178);
            txt_pagocon.Name = "txt_pagocon";
            txt_pagocon.Size = new Size(153, 23);
            txt_pagocon.TabIndex = 3;
            // 
            // txt_cambio
            // 
            txt_cambio.Location = new Point(158, 260);
            txt_cambio.Name = "txt_cambio";
            txt_cambio.Size = new Size(153, 23);
            txt_cambio.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(62, 260);
            label4.Name = "label4";
            label4.Size = new Size(95, 24);
            label4.TabIndex = 4;
            label4.Text = "Su Cambio";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(34, 36, 40);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(richTextBox1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(395, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 394);
            panel1.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(62, 115);
            label5.Name = "label5";
            label5.Size = new Size(83, 20);
            label5.TabIndex = 7;
            label5.Text = "Vista Previa";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(9, 138);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(184, 177);
            richTextBox1.TabIndex = 3;
            richTextBox1.Text = "";
            // 
            // button3
            // 
            button3.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(24, 335);
            button3.Name = "button3";
            button3.Size = new Size(154, 34);
            button3.TabIndex = 2;
            button3.Text = "Imprimir";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(24, 68);
            button2.Name = "button2";
            button2.Size = new Size(154, 34);
            button2.TabIndex = 1;
            button2.Text = "Generar Vista Previa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Narrow", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(24, 20);
            button1.Name = "button1";
            button1.Size = new Size(154, 34);
            button1.TabIndex = 0;
            button1.Text = "Cancelar";
            button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(151, 71);
            label6.Name = "label6";
            label6.Size = new Size(26, 31);
            label6.TabIndex = 7;
            label6.Text = "$";
            // 
            // RegCompra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(34, 36, 49);
            ClientSize = new Size(595, 394);
            Controls.Add(label6);
            Controls.Add(panel1);
            Controls.Add(txt_cambio);
            Controls.Add(label4);
            Controls.Add(txt_pagocon);
            Controls.Add(label3);
            Controls.Add(lbl_totpag);
            Controls.Add(label1);
            Name = "RegCompra";
            Text = "RegCompra";
            Load += RegCompra_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbl_totpag;
        private Label label3;
        private TextBox txt_pagocon;
        private TextBox txt_cambio;
        private Label label4;
        private Panel panel1;
        private RichTextBox richTextBox1;
        private Button button3;
        private Button button2;
        private Button button1;
        private Label label5;
        private Label label6;
    }
}