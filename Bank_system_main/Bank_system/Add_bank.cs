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
    public partial class Add_bank : UserControl
    {
        public Add_bank()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Functions addbank= new Functions();
            addbank.AddBank(textBox1.Text.ToString(),textBox2.Text.ToString(),int.Parse(textBox3.Text),int.Parse(textBox4.Text));
            MessageBox.Show("Added successfuly");
        }
    }
}
