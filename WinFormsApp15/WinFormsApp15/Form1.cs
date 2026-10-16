namespace WinFormsApp15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullanici;
            kullanici = Convert.ToString(textBox1.Text);
            if (kullanici == "okul@okul.com")
            {
                MessageBox.Show("Kullanici sisteme kayitli");
            }
            else { MessageBox.Show("Kullanici sisteme kayitli degil"); }
        }
    }
}
