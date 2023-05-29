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
    public partial class Login_employee : Form
    {
        public Login_employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions loginemp = new Functions();
            if(loginemp.LoginEmp(int.Parse(textBox1.Text), textBox2.Text.ToString()))
            {
                Employee_page nw = new Employee_page();
                nw.Show();
            }
        }
    }
}
