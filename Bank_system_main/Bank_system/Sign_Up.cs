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
    public partial class Sign_Up : UserControl
    {
        public Sign_Up()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sign_up_employee singUpEmp = new Sign_up_employee();
            singUpEmp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sign_up_customer nw= new Sign_up_customer();
            nw.Show();
        }

        private void Sign_Up_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sign_up_admin nw= new Sign_up_admin();
            nw.Show();
        }
    }
}
