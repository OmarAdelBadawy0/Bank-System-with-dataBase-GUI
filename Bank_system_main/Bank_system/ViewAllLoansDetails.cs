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
    public partial class ViewAllLoansDetails : Form
    {
        public ViewAllLoansDetails()
        {
            InitializeComponent();
        }

        private void ViewAllLoansDetails_Load(object sender, EventArgs e)
        {
            Functions view = new Functions();
            view.Viewloancustomeremp(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
