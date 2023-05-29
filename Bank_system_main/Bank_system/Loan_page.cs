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
    public partial class Loan_page : Form
    {
        public Loan_page()
        {
            InitializeComponent();
        }

        private void Loan_page_Load(object sender, EventArgs e)
        {
            Functions view = new Functions();
            view.ViewLoans(dataGridView1);
        }
    }
}
