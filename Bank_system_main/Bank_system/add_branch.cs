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
    public partial class Add_branch : UserControl
    {
        public Add_branch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions addbranch = new Functions();
            addbranch.AddBranch(int.Parse(textBox1.Text), int.Parse(textBox2.Text), textBox3.Text.ToString(), int.Parse(textBox4.Text));
            MessageBox.Show("Added successfuly");
        }
    }
}
