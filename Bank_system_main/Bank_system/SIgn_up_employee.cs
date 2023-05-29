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
    public partial class Sign_up_employee : Form
    {
        public Sign_up_employee()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions add = new Functions();
            add.AddEmployee(int.Parse(textBox1.Text), textBox2.Text.ToString(), textBox4.Text.ToString(), textBox3.Text.ToString());
            MessageBox.Show("The Employee is added successfuly :)");
        }
    }
}
