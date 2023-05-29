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
    public partial class View_customers : Form
    {
        public View_customers()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void View_customers_Load(object sender, EventArgs e)
        {
            Functions view = new Functions();
            view.Viewcustomer(dataGridView1);
        }
    }
}
