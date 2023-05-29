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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_customer nw= new Login_customer();
            nw.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login_employee nw= new Login_employee();
            nw.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login_admin nw= new Login_admin();
            nw.Show();
        }
    }
}
