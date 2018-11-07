using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace NHCPMS
{
    public partial class Payment : Form
    {
        public Payment()
        {
            InitializeComponent();
        }

        private void Payment_Load(object sender, EventArgs e)
        {
            label15.Hide();
            textBox15.Hide();
            button1.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Cash")
            {
                label15.Show();
                textBox15.Show();
                button1.Show();
                comboBox1.Text = "";
            }
            else
            {
                BankApproval b=new BankApproval();
                b.Show();
                label15.Hide();
                textBox15.Hide();
                button1.Hide();
            }
        }

       
       

        

        
    }
}
