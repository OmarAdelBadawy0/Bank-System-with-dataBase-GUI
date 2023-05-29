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
    public partial class Request_loan_page : UserControl
    {
        public Request_loan_page()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loantype = "null";

            if(radioButton1.Checked)
            {
                loantype= radioButton1.Text.ToString();
            }else if(radioButton2.Checked)
            {
                loantype= radioButton2.Text.ToString();
            }else if (radioButton3.Checked)
            {
                loantype= radioButton3.Text.ToString();
            }

            Functions req= new Functions();
            req.RequestLoan(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text),loantype);
        }
    }
}
