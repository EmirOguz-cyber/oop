namespace WinFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi;
            sayi = Convert.ToInt16(textBox1.Text);
            if(sayi % 2 == 0)
            {
                MessageBox.Show("cift");
            }
            if(sayi % 2 == 1)
            {
                MessageBox.Show("tek");
            }
        }
    }
}
