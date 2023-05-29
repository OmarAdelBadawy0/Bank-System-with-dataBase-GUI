namespace Bank_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            sign_Up1.Hide();
            login1.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sign_Up1.Show();
            button1.Hide();
            button2.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            login1.Show();
            button1.Hide();
            button2.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}