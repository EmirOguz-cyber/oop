namespace WinFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte a, b;
            a = Convert.ToByte(textBox1.Text);
            b = Convert.ToByte(textBox2.Text);
            if (a > b)
            {
                MessageBox.Show("1. sayi buyuk");
            }
            if (a < b)
            {
                MessageBox.Show("2. sayi buyuk");
            }
            if (a == b)
            {
                MessageBox.Show("iki sayi esit");
            }
        }
    }
}
