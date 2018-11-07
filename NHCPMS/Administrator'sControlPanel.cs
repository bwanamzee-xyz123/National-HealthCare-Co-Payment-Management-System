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
    public partial class Administrator_sControlPanel : Form
    {
        public Administrator_sControlPanel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            changepassword c = new changepassword();
            c.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Directorlogin d = new Directorlogin();
            d.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           Doctor_s_Login w =new Doctor_s_Login();
            w.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Accounts_login q= new Accounts_login();
            q.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Superuser s =new Superuser();
            s.Show();
        }
    }
}
