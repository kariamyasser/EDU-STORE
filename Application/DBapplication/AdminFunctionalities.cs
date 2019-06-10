using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace DBapplication
{
    public partial class AdminFunctionalities : Form
    {
        string username;
        private int source;
        Controller controllerObj;
        private string CheckPassword_Hash(string password)
        {
            const string salt = "r4Nd0m_5A1t";  //They are concatenated to the password to protects against rainbow table attacks.
            HashAlgorithm algorithm = new SHA256Managed();
            string passwordandsalt = password + salt;
            string hashed = Convert.ToBase64String(algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordandsalt)));
            return hashed;    //The Hash should be stored in the DB
            //Hashes needs a lot of time to be reversed (Brute Force, Dictionary Attacks, Rainbow Tables, etc.)
            //So even if they are stolen from the database, 
            //you should have enough time to notify users to change it
            //before the attacker can use them.
        }
        public AdminFunctionalities(int x,string user)
        {
            username = user;
            source = x;
            controllerObj = new Controller();
            InitializeComponent();
            if (x == 1)
            {
                label1.Text = "ADD STORE";
                label2.Text = "Store Name :";
                label3.Text = "Address :";
                label3.Show();
                label4.Show();
                label5.Show();
                textBox2.Show();
                textBox3.Show();
                textBox4.Show();
                DataTable dt = controllerObj.GetStores();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();

            }
            if (x == 2)
            {
                label1.Text = "REMOVE STORE";
                label2.Text = "Store Name :";
                DataTable dt = controllerObj.GetStores();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();

            }

            if (x == 3)
            {

                label1.Text = "ASSIGN PRINT ORDER PRICE";
                label2.Text = "Printing Order ID :";
                label4.Text = "Price (dollars) : ";
                label4.Show();
                textBox3.Show();
                label5.Text = "Price (points) : ";
                label5.Show();
                textBox4.Show();
                DataTable dt = controllerObj.GetPrintOrders();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();

            }

            if (x == 4)
            {

                label1.Text = "ADD ADMIN";
                label2.Text = "Username :";
                label3.Text = "Password :";
                label3.Show();
                textBox2.Show();
                DataTable dt = controllerObj.GetAdmins();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();

            }

            if (x == 5)
            {

                label1.Text = "REMOVE ADMIN";
                label2.Text = "Username :";
                DataTable dt = controllerObj.GetAdmins();
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();

            }

            if (x == 6)
            {

                label1.Text = "CHANGE PASSWORD";

                label2.Text = "Old Password :";
                label3.Text = "New Password :";
             
                label3.Show();
                textBox2.Show();
                dataGridView1.Hide();
            }
        }

        private void AdminFunctionalities_Load(object sender, EventArgs e)
        {

        


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Admin x = new Admin(username);
            x.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x=source;
            if (x == 1)
            {
                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")//validation part
                {
                    MessageBox.Show("Please, insert all values");
                }
                else
                {
                    int r = controllerObj.AddStore(textBox1.Text.ToString(), textBox2.Text.ToString(), textBox3.Text.ToString(),textBox4.Text.ToString());
                    if (r > 0)
                    {
                        MessageBox.Show("Store inserted successfully");
                        DataTable dt = controllerObj.GetStores();
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();
                    }
                    else
                        MessageBox.Show("Insertion Failed");
                }
            }
            if (x == 2)
            {
                if (textBox1.Text == "" )//validation part
                {
                    MessageBox.Show("Please, insert all values");
                }
                else
                {
                    int r = controllerObj.RemoveStore(textBox1.Text.ToString());
                    if (r > 0)
                    {
                        MessageBox.Show("Store Removed successfully");
                        DataTable dt = controllerObj.GetStores();
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();
                    }
                    else
                        MessageBox.Show("Removal Failed");
                }
            }

            if (x == 3)
            {
                if (textBox1.Text == "")//validation part
                {
                    MessageBox.Show("Please, insert all values");
                }
                else
                {
                    int cv, cvv, cvvv;
                    int.TryParse(textBox1.Text, out cv);
                    int.TryParse(textBox3.Text, out cvv);
                    int.TryParse(textBox4.Text, out cvvv);
                    if (cv != 0 && cvv != 0 && cvvv != 0)
                    {
                        int r = controllerObj.AssignPrint(textBox1.Text.ToString(), textBox3.Text.ToString(), textBox4.Text.ToString());
                        if (r > 0)
                        {
                            MessageBox.Show("Price Assigned successfully");
                            DataTable dt = controllerObj.GetPrintOrders();
                            dataGridView1.DataSource = dt;
                            dataGridView1.Refresh();
                        }
                        else
                            MessageBox.Show("Assigning Failed");

                    }
                    else
                        MessageBox.Show("Please enter correct values");

                }
            }
            if (x == 4)
            {
                if (textBox1.Text == "" || textBox2.Text == "" )//validation part
                {
                    MessageBox.Show("Please, insert all values");
                }
                else
                {
                    string passhashedold = CheckPassword_Hash(textBox2.Text);
                    int r = controllerObj.AddAdmin(textBox1.Text.ToString(), passhashedold);
                    if (r > 0)
                    {
                        MessageBox.Show("Admin inserted successfully");
                        DataTable dt = controllerObj.GetAdmins();
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();
                    }
                    else
                        MessageBox.Show("Insertion Failed");
                }
            }

            if (x == 5)
            {
                if (textBox1.Text == "")//validation part
                {
                    MessageBox.Show("Please, insert all values");
                }
                else if (textBox1.Text == "Admin1")
                {
                    MessageBox.Show("You Can't Remove Main Admin");
                }
                else
                {
                    int r = controllerObj.RemoveAdmin(textBox1.Text.ToString());
                    if (r > 0)
                    {
                        MessageBox.Show("Admin Removed successfully");
                        DataTable dt = controllerObj.GetAdmins();
                        dataGridView1.DataSource = dt;
                        dataGridView1.Refresh();
                    }
                    else
                        MessageBox.Show("Removal Failed");
            }
            }

            if (x == 6)
            {


                string passhashedold = CheckPassword_Hash(textBox1.Text);

                if (textBox1.Text == "" || textBox2.Text == "" )//validation part
                {
                    MessageBox.Show("Please, insert all values");
                }

                else
                {
                    string query;
                    query = "SELECT username from Admin where username = '" + username + "' and password='" + passhashedold + "';";
            


                    int privlg = controllerObj.CheckPassword_Basic(query);
                    if (privlg > 0)
                    {
                        string passhashed=CheckPassword_Hash(textBox2.Text);
                        int r = controllerObj.UpdateAdminPass(username,passhashed );
                        if (r > 0)
                        {
                            MessageBox.Show("Password updated successfully");
                           
                        }
                    }
                    else
                    {

                        MessageBox.Show("Please make sure you entered right OldPassward");

                    }
                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }




}
