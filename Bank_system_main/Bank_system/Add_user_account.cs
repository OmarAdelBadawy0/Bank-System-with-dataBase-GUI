using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_system
{
    public partial class Add_user_account : Form
    {
        private int ssn;
        public Add_user_account(int ssn)
        {
            InitializeComponent();
            this.ssn = ssn;
        }

        private void Add_user_account_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions addacount = new Functions();
            addacount.AddAccount(int.Parse(textBox1.Text), ssn, int.Parse(textBox2.Text), textBox3.Text.ToString());
            MessageBox.Show("The account added successfuly :)");
        }
    }
}
