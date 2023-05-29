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
    public partial class Sign_up_admin : Form
    {
        public Sign_up_admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions AddAdmin = new Functions();
            AddAdmin.AddAdmin(int.Parse(textBox1.Text),textBox2.Text.ToString(), textBox3.Text.ToString());
            MessageBox.Show("The Admin Added Successfuly");
        }
    }
}
