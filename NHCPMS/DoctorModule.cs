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
    public partial class DoctorModule : Form
    {
        public DoctorModule()
        {
            InitializeComponent();
        }

        

        private void DoctorModule_Load(object sender, EventArgs e)
        {

        }

       
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.Text == "Log Out")
            {
                Application.Exit();
            }
        }
        
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////
        //codes  to display datagridviews
        private void button7_Click(object sender, EventArgs e)
        {
            // childdetails
            dataGridViewchildbirth_details.Show();
            dataGridViewprents_details.Hide();
            dataGridViewtreatment.Hide();
            health_history.Hide();
        }

        private void buttonpd_Click(object sender, EventArgs e)
        {
            //paernts details
            dataGridViewchildbirth_details.Hide();
            dataGridViewprents_details.Show();
            dataGridViewtreatment.Hide();
            health_history.Hide();
        }

        private void buttontt_Click(object sender, EventArgs e)
        {
            //treatment
            dataGridViewchildbirth_details.Hide();
            dataGridViewprents_details.Hide();
            dataGridViewtreatment.Show();
            health_history.Hide();
        }

        private void buttonhh_Click(object sender, EventArgs e)
        {
            //health history
            dataGridViewchildbirth_details.Hide();
            dataGridViewprents_details.Hide();
            dataGridViewtreatment.Hide();
            health_history.Show();
        }

        

        

        
    }
}
