using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.IO;
using ClosedXML.Excel;
using System.Reflection;

namespace NHCPMS
{
    public partial class Bank : Form
    {
        MySqlConnection connection = new
MySqlConnection("datasource=localhost;username=root;database=ellie_nhcpms;password=;");
        public Bank()
        {
            InitializeComponent();
            fill_gridview();
            timer1.Start();
        }
        public void search()
        {
            //Lets rap every thing into a try and catch block
            try
            {//for search button
                string constring = "datasource=localhost;port=3306;username=root;";// this string is a path to our database
                MySqlConnection conDatabase = new MySqlConnection(constring);//connection to our database
                MySqlCommand cmdDatabase = new MySqlCommand("Select * from ellie_nhcpms.bank where account_no='" + textBox1.Text + "' ;", conDatabase);//query selects from database

                MySqlDataAdapter sda = new MySqlDataAdapter();//object for data adapter
                sda.SelectCommand = cmdDatabase;//holds data from database
                DataTable dbDataset = new DataTable();//object for data table
                sda.Fill(dbDataset);//holds data from data adapter
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbDataset;//this gets data from datatable to data source
                dataGridView1.DataSource = bSource;//puts data to datagrid
                sda.Update(dbDataset);//updates data adapter
                conDatabase.Close();//closes connection



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }


        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] imageBt = null;
                FileStream fstream = new FileStream(this.textBox9.Text, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                imageBt = br.ReadBytes((int)fstream.Length);



                string myConnection = "datasource=localhost;port=3306;username=root;";
                string Query = "insert into ellie_nhcpms.bank(account_no,holders_name,bank,acc_type,next_of_kin,phone_no,gender,age,occupation,balance,acc_status,supervisor,date,photo,time) values('" + this.textBox1.Text + "','" + this.textBox2.Text + "','" + this.comboBox1.Text + "','" + this.comboBox2.Text + "','" + this.textBox4.Text + "','" + this.textBox3.Text + "','" + this.comboBox4.Text + "','" + this.textBox8.Text + "','" + this.textBox7.Text + "','" + this.textBox5.Text + "','" + this.comboBox3.Text + "','" + this.textBox6.Text + "','" + this.dateTimePicker1.Text + "',@IMG,'" + label5.Text + "') ;";

                MySqlConnection mycon = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand(Query, mycon);

                MySqlDataReader myReader;

                mycon.Open();
                //just after our connection add this code for image functionality
                SelectCommand.Parameters.Add(new MySqlParameter("@IMG", imageBt));
                //end of img
                myReader = SelectCommand.ExecuteReader();
                MessageBox.Show("Data has been saved");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox7.Text = "";
                textBox6.Text = "";
                textBox8.Text = "";
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                comboBox4.Text = "";
                
                fill_gridview();
                while (myReader.Read())
                {


                }


                mycon.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.pnp)|*.png|All Files(*.*)|*.*";
            dlg.Title = "Select picture";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picLoc = dlg.FileName.ToString();
                textBox9.Text = picLoc;
                pictureBox1.ImageLocation = picLoc;

            }
        }

        private void textBox2_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Please Enter characters Values Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            //char ch = e.KeyChar;
            //if (!char.IsLetter(ch) && ch != 8)
            //{

            //    e.Handled = true;
            //    MessageBox.Show("Enter Letters Only");

            //} 
        }
        public static string GetUniqueKey(int maxSize)
        {
            char[] chars = new char[100000000];
            chars =
            "0123456789".ToCharArray();
            byte[] data = new byte[1];
            RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();
            crypto.GetNonZeroBytes(data);
            data = new byte[maxSize];
            crypto.GetNonZeroBytes(data);
            StringBuilder result = new StringBuilder(maxSize);
            foreach (byte b in data)
            {
                result.Append(chars[b % (chars.Length)]);
            }
            return result.ToString();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8)
            //{
            //    e.Handled = false;

            //}
            //else
            //{
            //    MessageBox.Show("Please Enter Number Values Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            //    e.Handled = true;
            //}
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {

                e.Handled = true;
                MessageBox.Show("Please Enter Number Values Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);

            }   

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {

                e.Handled = true;
                MessageBox.Show("Enter Letters Only");

            } 
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {

                e.Handled = true;
                MessageBox.Show("Enter Letters Only");

            } 
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsLetter(ch) && ch != 8)
            {

                e.Handled = true;
                MessageBox.Show("Enter Letters Only");

            } 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "AC-000" + GetUniqueKey(10);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {

                e.Handled = true;
                MessageBox.Show("Please Enter Number Values Only");

            }   

        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {

                e.Handled = true;
                MessageBox.Show("Please Enter Number Values Only");

            }   

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are sure want to cancel ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                Close();
            }
        }
        public void fill_gridview()
        {

            //Lets rap every thing into a try and catch block
            try
            {
                string constring = "datasource=localhost;port=3306;username=root;";
                MySqlConnection conDatabase = new MySqlConnection(constring);
                MySqlCommand cmdDatabase = new MySqlCommand("Select account_no,holders_name,bank,acc_type,next_of_kin,phone_no,gender,age,occupation,balance,acc_status,supervisor,date,photo,time from ellie_nhcpms.bank ;", conDatabase);
                MySqlDataAdapter sda = new MySqlDataAdapter();
                sda.SelectCommand = cmdDatabase;
                DataTable dbDataset = new DataTable();
                sda.Fill(dbDataset);
                BindingSource bSource = new BindingSource();
                bSource.DataSource = dbDataset;
                dataGridView1.DataSource = bSource;
                sda.Update(dbDataset);
                conDatabase.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }


        }

        public void load_databasevalues()
        {
            ////Lets rap every thing into a try and catch block
            //try
            //{
            //    string myConnection = "datasource=localhost;port=3306;username=root;";
            //    MySqlConnection mycon = new MySqlConnection(myConnection);
            //    MySqlCommand SelectCommand = new MySqlCommand("Select * from ellie_nhcpms.bank ", mycon);
            //    MySqlDataReader myReader;

            //    mycon.Open();
            //    myReader = SelectCommand.ExecuteReader();

            //    while (myReader.Read())
            //    {
            //        string user_name = myReader.GetString("username");
            //        string pass = myReader.GetString("password");
            //        string idval = myReader.GetString("id").ToString();
            //        comboBox1.Items.Add(idval);


            //    }


            //    mycon.Close();



            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);


            //}



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;database=ellie_nhcpms;";
                string Query = "delete from ellie_nhcpms.bank  where account_no ='" + this.textBox1.Text + "'  ;";

                MySqlConnection mycon = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand(Query, mycon);

                MySqlDataReader myReader;

                mycon.Open();
                myReader = SelectCommand.ExecuteReader();
                MessageBox.Show("Data has been deleted");
                while (myReader.Read())
                {


                }
                fill_gridview();

                mycon.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);


            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            search();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // comboBox1 is readonly
            e.SuppressKeyPress = true;

        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            // comboBox2  is readonly
            e.SuppressKeyPress = true;
        }

        private void comboBox4_KeyDown(object sender, KeyEventArgs e)
        {
            // comboBox4 is readonly
            e.SuppressKeyPress = true;
        }

        private void comboBox3_KeyDown(object sender, KeyEventArgs e)
        {
            // comboBox3 is readonly
            e.SuppressKeyPress = true;
        }

        private void comboBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Creating DataTable
            DataTable dt = new DataTable();

            //Adding the Columns
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }

            //Adding the Rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }

            //Exporting to Excel
            string folderPath = "C:\\Excel\\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (XLWorkbook wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "Customers");
                wb.SaveAs(folderPath + "DataGridViewExport.xlsx");
            }
        }
    }
}
