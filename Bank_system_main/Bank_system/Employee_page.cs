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
    public partial class Employee_page : Form
    {
        public Employee_page()
        {
            InitializeComponent();
            add_customer_search1.Hide();
        }

        private void Employee_page_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            add_customer_search1.Show();
            button1.Hide();
            button2.Hide();
            button3.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Loan_page nw= new Loan_page();
            nw.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            View_customers nw= new View_customers();
            nw.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewAllLoansDetails nw= new ViewAllLoansDetails();
            nw.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Manage_loans mange = new Manage_loans();
            mange.Show();
        }
    }
}
