using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace DBapplication
{
    public partial class NewCustomer : Form
    {
       
        Controller controllerObj;

        public NewCustomer()

        {
            controllerObj = new Controller();
            InitializeComponent();
        }

        private void AddNewCustomerButton_Click(object sender, EventArgs e)
        {
            int namecheck = CheckName(CustomerUserNameTextBox.Text);
            int usercheck = usernamecheck(UserNameTextBox.Text);
            int D=0;
            if (usercheck != -1)
            {
                 D = controllerObj.CheckName(UserNameTextBox.Text);
            }

            int phone = PhoneCheck(PhoneTextBox.Text);
            int passcheckk = passcheck( PasswordTextBox.Text );
            int age2 = agecheck(AgeTextBox.Text);
            int cr2 = crcheck(CRTextBox.Text);

            if (usercheck == -1)
            {
                MessageBox.Show("Enter Valid User Name ");
            }
            else if (namecheck == -1)
            {
                MessageBox.Show("Enter Valid Name");
            }
            else if (phone == -1)
            {
                MessageBox.Show("Enter Valid Phone");

            }
            else if (passcheckk == -1)
            {
                MessageBox.Show("Enter Valid Password");
            }
            else if (D != 0)
            {
                MessageBox.Show("User Name is Taken");
            }
            else
            {


                string password = CheckPassword_Hash(PasswordTextBox.Text);


                int r = controllerObj.insert_customer(CustomerUserNameTextBox.Text, UserNameTextBox.Text, EmailTextBox.Text, Int32.Parse(PhoneTextBox.Text), age2, password, AdressTextBox.Text, cr2);
                string Cuser = UserNameTextBox.Text;


                if (r == 1)
                {
                    int CID = controllerObj.GetCUID(Cuser);
                    int s = controllerObj.insert_shopping(CID);
                    if (s == 1)
                    {
                        MessageBox.Show("Welcome to the application");
                    }

                }
                else
                {
                    MessageBox.Show("Failed");
                }

            }



            



        }
        int agecheck(string age)
        {
            Int32 r=0;

            Int32.TryParse(age, out r);
            return r;
        }
        int crcheck(string cr)
        {
            Int32 r = 0;

            Int32.TryParse(cr, out r);
            return r;
        }

        int CheckName(string name)
        {
            if (name.Length == 0)
            {
                return -1;
            }
            return 1;
        }
        int usernamecheck(string user)
        {
            if (user.Length == 0)
            {
                return -1;
            }
            return 1;
        }
        int PhoneCheck(string phone)
        {
            int k = 1;
            Int32.TryParse(phone, out k);
            if (k!=0)
            {
                return 1;
            }
            return -1;


        }
        int passcheck(string pass)
        {
            if (pass.Length == 0)
            {
                return -1;
            }
            return 1;
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

  

        private void NewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackNewCustomerButton_Click(object sender, EventArgs e)
        {
         
            this.Hide();
        }
    }
}
