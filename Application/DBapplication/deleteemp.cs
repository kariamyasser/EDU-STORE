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
    public partial class deleteemp : Form
    {
        string username;
        Controller controllerObj;
        public deleteemp(string x)
        {
            username = x;
            controllerObj = new Controller();
            InitializeComponent();
            DataTable dt = controllerObj.GetSname(username);
            string s = dt.Rows[0].Field<string>(0);


            DataTable dt3 = controllerObj.GetEmployees(s);
            dataGridView2.DataSource = dt3;
            dataGridView2.Refresh();

            comboBox1.DataSource = dt3;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "SSN";
        }

        private void deleteemp_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else
            {



                int r = controllerObj.DeleteEmp(int.Parse(comboBox1.SelectedValue.ToString()));
                if (r > 0)
                {
                    MessageBox.Show("Employee deleted successfully");
                    DataTable dt = controllerObj.GetSname(username);
                    string s = dt.Rows[0].Field<string>(0);
                  
                  
                    DataTable dt3 = controllerObj.GetEmployees(s);
                    dataGridView2.DataSource = dt3;
                    dataGridView2.Refresh();

                    comboBox1.DataSource = dt3;
                    comboBox1.DisplayMember = "Name";
                    comboBox1.ValueMember = "SSN";

                 
                }
                else
                {
                    MessageBox.Show("You Tried to Delete The Manager :) ");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Store x = new Store(username);
            x.Show();
            this.Hide();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
