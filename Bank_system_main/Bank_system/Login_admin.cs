using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank_system
{
    public partial class Login_admin : Form
    {
        public Login_admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions loginadmin = new Functions();

            if (loginadmin.LoginAdmin(int.Parse(textBox1.Text), textBox2.Text.ToString()))
            {
                Admin_page nw = new Admin_page();
                nw.Show();
            }
            
        }
    }
}
