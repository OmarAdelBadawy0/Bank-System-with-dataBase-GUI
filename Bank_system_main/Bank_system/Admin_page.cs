using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bank_system
{
    public partial class Admin_page : Form
    {
        public Admin_page()
        {
            InitializeComponent();
            add_bank1.Hide();
            add_branch1.Hide();
            //Functions showAdmin = new Functions();
            //showAdmin.showAdminPage(id);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Admin_page_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            add_bank1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Hide();
            button2.Hide();
            add_branch1.Show();
        }
    }
}
