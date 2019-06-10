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
    public partial class Login : Form
    {
         private bool _loggedin = false;
        private Controller controllerObj; // A Reference of type Controller 
                                          // (Initially NULL; NO Controller Object is created yet)     

        public Login()
        {

            InitializeComponent();
             controllerObj = new Controller(); // Create the Controler Object
        }


          private string  CheckPassword_Hash(string password)
        {
            const string salt = "r4Nd0m_5A1t";  //They are concatenated to the password to protects against rainbow table attacks.
            HashAlgorithm algorithm = new SHA256Managed();
            string passwordandsalt = password + salt;
            string hashed = Convert.ToBase64String(algorithm.ComputeHash(Encoding.UTF8.GetBytes(passwordandsalt)));
            return hashed ;    //The Hash should be stored in the DB
                                                                                //Hashes needs a lot of time to be reversed (Brute Force, Dictionary Attacks, Rainbow Tables, etc.)
                                                                                //So even if they are stolen from the database, 
                                                                     //you should have enough time to notify users to change it
                                                                                //before the attacker can use them.
          }
        private void CustomerPasswordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = true;
        }

        private void NewCustomerButton_Click(object sender, EventArgs e)
        {
            NewCustomer x = new NewCustomer();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = textBox1.Text;
            string password = textBox2.Text;
            password = CheckPassword_Hash(password);
            string query;
            if (radioButton1.Checked == true)
            {
                //Query the DB to check for username/password
               
                query = "SELECT username from Admin where username = '" + username + "' and password='" + password + "';";
              

               int privlg = controllerObj.CheckPassword_Basic(query);
               if (privlg > 0) // Successful Login
               {
                   _loggedin = true;

                   textBox1.Clear();
                   textBox2.Clear();
                   Admin x = new Admin(textBox1.Text);
                   x.Show();
                   this.Hide();
               }
               else
               {
                   MessageBox.Show("Wrong username or password");
               }     

            }
            if (radioButton2.Checked == true)
            {
                //Query the DB to check for username/password
                query = "SELECT name from Store where username = '" + username + "' and password='" + password + "';";

                int privlg = controllerObj.CheckPassword_Basic(query);
                if (privlg > 0) // Successful Login
                {
                    _loggedin = true;

                    textBox1.Clear();
                    textBox2.Clear();
                    this.Hide();
                    Store x = new Store(username);
                    x.Show();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }     


            }
            if (radioButton3.Checked == true)
            {
                //Query the DB to check for username/password
                query = "SELECT cu_id from Customer where username = '" + username + "' and password='" + password + "';";

                int privlg = controllerObj.CheckPassword_Basic(query);
                if (privlg > 0) // Successful Login
                {
                    _loggedin = true;

                    textBox1.Clear();
                    textBox2.Clear();
                    this.Hide();
                    Menu x = new Menu(username);
                    x.Show();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }     

            }



            if (radioButton4.Checked == true)
            {
                //Query the DB to check for username/password
                query = "SELECT name from Employee where Username= '" + username + "' and password='" + password + "';";

                int privlg = controllerObj.CheckPassword_Basic(query);
                if (privlg > 0) // Successful Login
                {
                    _loggedin = true;

                    textBox1.Clear();
                    textBox2.Clear();
                    this.Hide();
                    Employee x = new Employee(username);
                    x.Show();
                }
                else
                {
                    MessageBox.Show("Wrong username or password");
                }


            }
         

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            button1.Enabled = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
