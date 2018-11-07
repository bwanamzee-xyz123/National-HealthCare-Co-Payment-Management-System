using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NHCPMS
{
    public partial class Insertkey : Form
    {
        public Insertkey()
        {
            InitializeComponent();
        }

        private void Insertkey_Load(object sender, EventArgs e)
        {
            ToolTip toolTip1 = new ToolTip();
            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            //...Tooltip for Users ControlBox...//
            toolTip1.SetToolTip(this.pictureBox1, "Subit Product Key");
        }

       

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default["activationKey"].Equals(textBox1.Text))
            {
                //MessageBox.Show(Properties.Settings.Default["isActivated"].ToString());
                Properties.Settings.Default["isActivated"] = "True";
                Properties.Settings.Default.Save();
                if (Properties.Settings.Default["isActivated"].Equals("True"))
                {
                    MessageBox.Show("Product Key Accepted,Thank You", "Activation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    Welcome frm = new Welcome();
                    frm.ShowDialog();
                }
                else
                {

                }
            }
            else
            {
                MessageBox.Show("Invalid Product Key, Try Again or Contact SMBisoft Technology Solutions\nVoice: +92256705230742", "Activation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
