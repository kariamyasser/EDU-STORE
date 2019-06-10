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
    public partial class NewEmp : Form
    {
        string username;
        Controller controllerObj;
        public NewEmp(string x)
        {
            username = x;
            controllerObj = new Controller();
            
            InitializeComponent();
            DataTable dt = controllerObj.GetSname(username);
            string s = dt.Rows[0].Field<string>(0);
            DataTable dt2 = controllerObj.GetEmployees(s);
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();
        }

        private void NewEmp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Store x = new Store(username);
            x.Show();
            this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" )//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {
                DataTable dt3 = controllerObj.GetSname(username);
                string s3 = dt3.Rows[0].Field<string>(0);
                string hashpass = CheckPassword_Hash(textBox3.Text);
                 bool flag = true;
                    int q;
                    int.TryParse(textBox4.Text, out q); if (q == 0) flag = false;


                    if (flag == true)
                    {
                        int r = controllerObj.InsertEmployee(textBox1.Text.ToString(), textBox2.Text.ToString(), hashpass, int.Parse(textBox4.Text.ToString()), s3);
                        if (r > 0)
                        {
                            MessageBox.Show("Employee inserted successfully");

                            DataTable dt = controllerObj.GetSname(username);
                            string s = dt.Rows[0].Field<string>(0);
                            DataTable dt2 = controllerObj.GetEmployees(s);
                            dataGridView1.DataSource = dt2;
                            dataGridView1.Refresh();
                        }
                        else
                            MessageBox.Show("Insertion Failed");
                    }
                    else
                        MessageBox.Show("Please Insert Correct Data");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
