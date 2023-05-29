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
    public partial class Add_customer_search1 : UserControl
    {
        public Add_customer_search1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions search = new Functions();

            
            if (search.customerIsExist(int.Parse(textBox1.Text)))
            {
                Add_user_account nw= new Add_user_account(int.Parse(textBox1.Text));
                nw.Show();
            }
        }
    }
}
