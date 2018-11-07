using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;
using GsmComm.Server;


namespace NHCPMS
{
    public partial class BankApproval : Form
    {
        private GsmCommMain comm;
        public BankApproval()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BankApproval_Load(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("invalid port number");
                return;
            }
            comm = new GsmCommMain(comboBox1.Text, 9600, 150);
            Cursor.Current = Cursors.Default;
            bool retry;
            do
            {
                retry = false;
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    comm.Open();
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show(" connected successfully");


                }
                catch (Exception)
                {
                    Cursor.Current = Cursors.Default;
                    if (MessageBox.Show(this, "GSM  COMMUNICATION IS Not AVAILABLE", "Check", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                        retry = true;
                    else
                    {
                        return;
                    }
                }
            }
            while (retry);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SmsSubmitPdu pdu;
                byte dcs = (byte)DataCodingScheme.GeneralCoding.Alpha7BitDefault;
                pdu = new SmsSubmitPdu(smstexts.Text, textBox6.Text, dcs);
                int time = 1;
                for (int i = 0; i < time; i++)
                {
                    comm.SendMessage(pdu);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("modem is not available");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
    //        try
    //        {
    //            stringmyConnection = "datasource=localhost;port=3306;username=root;";
    //            MySqlConnectionmycon = newMySqlConnection(myConnection);
    //            MySqlCommandSelectCommand = newMySqlCommand("Select * from army.personaldetails where ArmyNo='" + a.Text + "'  ;", mycon);
    //            MySqlDataReadermyReader;

    //            mycon.Open();
    //            myReader = SelectCommand.ExecuteReader();

    //            while (myReader.Read())
    //            {

    //                //   string idno = myReader.GetString("feesid").ToString();
    //                stringuser = myReader.GetString("FirstName").ToString();
    //                stringpas = myReader.GetString("MiddleName").ToString();
    //                stringpas2 = myReader.GetString("LastName").ToString();
    //                //string pass = myReader.GetString("Dependants").ToString();
    //                stringpass4 = myReader.GetString("Rank").ToString();
    //                f.Text = user;
    //                m.Text = pas;
    //                la.Text = pas2;
    //                // nc.Text = pass;
    //                r.Text = pass4;
    //                stringyor = myReader.GetString("DateOfEntry");

    //                stringYOR = yor.Split('/').Last().Split(' ').First().ToString();

    //                stringCuryr = System.DateTime.Now.Date.Year.ToString();
    //                try
    //                {

    //                    intyr1 = Convert.ToInt16(YOR);
    //                    intyr2 = Convert.ToInt16(Curyr);

    //                    ps.Text = (yr2 - yr1).ToString() + " Years";
    //                }
    //                catch (FormatException)
    //                {
    //                }

    //                stringyoB = myReader.GetString("DateOfBirth");

    //                stringyob2 = yoB.Split('/').Last().Split(' ').First().ToString();


    //                stringcury2 = System.DateTime.Now.Date.Year.ToString();
    //                try
    //                {

    //                    intyr = Convert.ToInt16(yob2);
    //                    intyrc = Convert.ToInt16(cury2);

    //                    nc.Text = (yrc - yr).ToString() + " Years";
    //                }
    //                catch (FormatException)
    //                {
    //                }
    //            }
    //            mycon.Close();

    //        }
    //        catch (Exceptionex)
    //        {
    //            MessageBox.Show(ex.Message);
    //        }

       }
    }
}
