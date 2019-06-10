using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class PricesConf : Form
    {
        string username;
        Controller controllerObj;
     
        public PricesConf(string x)
        {
            username = x;
          
            controllerObj = new Controller();
            InitializeComponent();
            //DataTable dt = controllerObj.GetSname(username);
            //string s = dt.Rows[0].Field<string>(0);


            DataTable dt3 = controllerObj.GetDNames();
            comboBox2.DataSource = dt3;
            comboBox2.DisplayMember = "Name";
           
            //DataTable dt2 = controllerObj.GetProducts(s);
            ////dataGridView1.DataSource = dt2;
            ////dataGridView1.Refresh();
        }
        public int TextboxValid(string s, int kind)  //kind is 0 if the s was string to be declared and 1 if it was meant to be number, problem if the int value not entereed cant take null value !!
        {
            int functionparameter = 0;
            if (s.Length == 0)
            {
                s = null;


                return functionparameter; //will be return the 0 if the textbox was empty 
            }

            else
            {
                if (kind == 1)
                {
                    if (int.TryParse(s, out functionparameter) == false)
                    {
                        functionparameter = -1;

                    }
                    if (functionparameter < 0) //negative number enetered
                    {
                        functionparameter = -1;
                    }

                }

            }
            return functionparameter;
        }
        public int ImportantNotNULL(string s)  // for important values that must be inserd
        {
            if (s.Length == 0)
                return 0;
            else
                return 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Store x = new Store(username);
            x.Show();
            this.Hide();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt3 = controllerObj.GetSname(username);
            string s3 = dt3.Rows[0].Field<string>(0);
            

            if (addsaleradio.Checked==true)
            {


                int Percentage = TextboxValid(PercentageTextbox.Text, 1);
                
                 float percent = Percentage;
                 percent = percent / 100;
               
                if (PercentageTextbox.Text == "")//validation part
                {
                    MessageBox.Show("Please, insert all values");

                }
                else if (Percentage == -1)
                {
                    MessageBox.Show("Please, Make sure you entered a correct value");
                }
                else
                {

                    int r3 = controllerObj.CheckSales(comboBox2.Text, s3);

                    if (r3 == 0)
                    {


                        int r = controllerObj.InsertSale(Percentage, comboBox2.Text, s3);

                        if (r > 0)
                        {




                            int r2 = controllerObj.Addsale(percent, comboBox2.Text, s3);
                            if (r2 > 0)
                            {
                                MessageBox.Show("Sale Added successfully and Prices updated");

                            }
                            else
                            {
                                MessageBox.Show("Error Occured while updating prices");
                            }
                        }
                    }
                    else
                        MessageBox.Show("There is already sale on this department");
                }
            }
            if (removesaleradio.Checked == true)
            {

               
                int r = controllerObj.CheckSales(comboBox2.Text, s3);

                    if (r >0 )
                    {
                       

                        int Percentage = controllerObj.GetPercent(comboBox2.Text,s3);
                        float percent = Percentage;
                        percent = percent / 100;
                        int r3 = controllerObj.DeleteSale(comboBox2.Text, s3);
                        int r2 = controllerObj.Removesale(percent, comboBox2.Text, s3);
                        if (r2 > 0 && r3>0)
                        {
                            MessageBox.Show("Sale Removed successfully");
                           
                        }
                        else
                        {
                            MessageBox.Show("Error Occured while updating prices");
                        }
                    }
                    else
                        MessageBox.Show("There is not sale on this department");
                

            }
            if (increasepriceradio.Checked == true)
            {


                int Percentage = TextboxValid(PercentageTextbox.Text, 1);


                if (PercentageTextbox.Text == "")//validation part
                {
                    MessageBox.Show("Please, insert all values");

                }
                else if (Percentage == -1)
                {
                    MessageBox.Show("Please, Make sure you entered a correct value");
                }
                else
                {

                    int r = controllerObj.CheckSales(comboBox2.Text, s3);

                    if (r == 0)
                    {
                        DialogResult res = MessageBox.Show("Do you want to increase the prices of Department " + comboBox2.Text + " with " + Percentage + " %",
                                 "Edu Store Application",
                                MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question,
                                 MessageBoxDefaultButton.Button2);
                        if (res == DialogResult.Yes)
                        {


                            float percent = Percentage;
                            percent = percent / 100;
                            int r2 = controllerObj.Incprice(percent, comboBox2.Text, s3);
                            if (r2 > 0)
                            {
                                MessageBox.Show("You Have increased the prices with " + Percentage + " %");

                            }
                            else
                            {
                                MessageBox.Show("Error Occured while updating prices");
                            }
                        }
                    }

                    else
                        MessageBox.Show("There is a sale on this department please remove it first");


                }

            }

                if (removesaleradio.Checked == false && addsaleradio.Checked == false && increasepriceradio.Checked == false)
                {
                    MessageBox.Show("Please Select a Radio Button according to function you want");
                }

                this.SalesStatisticsforownersTableAdapter.Fill(this.DataSet1.SalesStatisticsforowners, s3);
                this.reportViewer1.RefreshReport();
            
        }

        private void AddSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.SalesStatisticsforowners' table. You can move, or remove it, as needed.
            DataTable dt = controllerObj.GetSname(username);
            string s = dt.Rows[0].Field<string>(0);
            this.SalesStatisticsforownersTableAdapter.Fill(this.DataSet1.SalesStatisticsforowners,s);

            this.reportViewer1.RefreshReport();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void removesaleradio_CheckedChanged(object sender, EventArgs e)
        {
            if (removesaleradio.Checked == true)
            {
                label4.Visible = false;
                PercentageTextbox.Visible = false;
            }
            if (removesaleradio.Checked == false)
            {
                label4.Visible = true;
                PercentageTextbox.Visible = true;
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
