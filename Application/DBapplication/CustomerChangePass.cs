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
    public partial class CustomerChangePass : Form
    {
        string username;
        Controller controllerObj;
        public CustomerChangePass(string Cusername)
        {
            username = Cusername;
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CustomerChangePass_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
        }
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

        private void Changepass_Click(object sender, EventArgs e)
        {

            string passhashedold = CheckPassword_Hash(textBox1.Text);

            if (textBox1.Text == "" || textBox2.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }

            else
            {
                string query;
                query = "SELECT username from Customer where username = '" + username + "' and password='" + passhashedold + "';";
               


                int privlg = controllerObj.CheckPassword_Basic(query);
                if (privlg > 0)
                {
                    string passhashed = CheckPassword_Hash(textBox2.Text);
                    int r = controllerObj.UpdateCustomerPass(username, passhashed);
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

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
           Menu x = new Menu(username);
            x.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        }

    
}
