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
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            label7.Hide();
            label10.Hide();
            label8.Hide();
            label9.Hide();
        }

        

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Form1 x = new Form1();
            progressBar1.Visible = true;

            this.progressBar1.Value = this.progressBar1.Value + 1;
            if (this.progressBar1.Value == 10)
            {
                label11.Text = ".............";
                label12.Text = " 20% Complete...";
            }
            else if (this.progressBar1.Value == 20)
            {
                label7.Show();
                label11.Text = "Please wait...";
                label12.Text = "30% Complete...";
            }
            else if (this.progressBar1.Value == 30)
            {
                label11.Text = "Please wait...";
                label12.Text = "40% Complete...";
            }
            else if (this.progressBar1.Value == 40)
            {
                label10.Show();
                label9.Show();
                label8.Show();
                label11.Text = "Please wait...";
                label12.Text = "50% Complete...";
            }
            else if (this.progressBar1.Value == 60)
            {
                
                label11.Text = "Please wait...";
                label12.Text = "60% Complete...";
            }
            else if (this.progressBar1.Value == 70)
            {
                label11.Text = "Please wait...";
                label12.Text = "70% Complete...";
            }
            else if (this.progressBar1.Value == 80)
            {
                label11.Text = "Preparing system.....";
                label12.Text = "80% Complete...";
            }
            else if (this.progressBar1.Value == 90)
            {
                
                label11.Text = "Checking Database...";
                label12.Text = "90% Complete...";

            }
            else if (this.progressBar1.Value == 91)
            {


                
                label1.Text = "Checking Database...";
                label3.Text = "94% Complete...";
            }
            else if (this.progressBar1.Value == 95)
            {
                label11.Text = "Connecting to Database..";
                label12.Text = "95% Complete...";

            }
            else if (this.progressBar1.Value == 98)
            {
                label11.Text = "Finished..";
                label12.Text = "100% Complete...";

            }
            else if (this.progressBar1.Value == 100)
            {

                x.Show();
                timer1.Enabled = false;
                this.Hide();
            }
        }

        
    }
}
