namespace Pia_Beta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "LiveOak Punto De Venta " +
                "\n" +
                "\n Version: v0.1" +
                "\n Aplha Version"
                );
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_hr.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}