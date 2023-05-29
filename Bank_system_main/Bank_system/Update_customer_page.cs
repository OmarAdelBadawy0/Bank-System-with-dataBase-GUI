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
    public partial class Update_customer_page : UserControl
    {
        public int ssn { get; set; }
        public Update_customer_page()
        {
            InitializeComponent();
      
        }

 

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions update = new Functions();
            update.UpdateCustomer(textBox1.Text.ToString(), int.Parse(textBox2.Text), textBox3.Text.ToString(), textBox4.Text.ToString(), ssn);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Update_customer_page_Load(object sender, EventArgs e)
        {

        }
    }
}
