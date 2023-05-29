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
    public partial class Manage_loans : Form
    {
        private Functions view = new Functions();
        public Manage_loans()
        {
            InitializeComponent();
        }

        private void Manage_loans_Load(object sender, EventArgs e)
        {
            
            view.ViewLoansControl(dataGridView1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions change = new Functions();
            change.changeLoanStatus(int.Parse(textBox1.Text), "accepted");
            view.ViewLoans(dataGridView1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Functions change = new Functions();
            change.changeLoanStatus(int.Parse(textBox1.Text), "rejected");
            view.ViewLoans(dataGridView1);
        }
    }
}
