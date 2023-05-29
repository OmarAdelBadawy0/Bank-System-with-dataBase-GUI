using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_system
{
    public partial class Sign_up_customer : Form
    {
        public Sign_up_customer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions add= new Functions();
            add.AddUser(textBox1.Text.ToString(), int.Parse(textBox2.Text), int.Parse(textBox3.Text), textBox4.Text.ToString(), textBox5.Text.ToString());
            MessageBox.Show("The Customer Saved :)");
        }
    }
}
