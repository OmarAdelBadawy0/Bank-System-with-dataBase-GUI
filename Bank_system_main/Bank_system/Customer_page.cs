using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_system
{
    public partial class Customer_page : Form
    {
        public int ssn;
        
        public Customer_page(int ssn)
        {
            InitializeComponent();
            this.ssn = ssn;
            request_loan_page1.Hide();
            update_customer_page1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           request_loan_page1.Show();
            button1.Hide();
        }

        private void request_loan_page1_Load(object sender, EventArgs e)
        {

        }

        private void Customer_page_Load(object sender, EventArgs e)
        {
            Functions getb = new Functions();
            label4.Text = ssn.ToString();
            label2.Text = getb.getBalance(ssn).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update_customer_page1.ssn = ssn;
            update_customer_page1.Show();
            button1.Hide() ;
            button2.Hide();

        }
    }
}
