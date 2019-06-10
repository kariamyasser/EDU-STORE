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
    public partial class Employee : Form
    {
        string username;
        Controller controllerObj;
        public Employee(string us)
        {
            username = us;
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            controllerObj = new Controller();
            DataTable dt=controllerObj.GetEmpOrders(username);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("You Dont have any orders to deliever");

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login x = new Login();
            x.Show();
            this.Hide();
        }

        private void Changepass_Click(object sender, EventArgs e)
        {
            EmployeChangepass x = new EmployeChangepass(username);
            x.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (dataGridView1.Rows.Count == 0)
            {

                MessageBox.Show("You Dont have any orders to deliever");
            }
            else
            {
                try
                {
                DataGridViewRow rows = dataGridView1.SelectedRows[0];
                
                }
                catch(Exception )
                {
                    MessageBox.Show("Please Select an order to deliever first");

                    flag = false;
                }
                if (flag == true)
                {
                    DataGridViewRow row = dataGridView1.SelectedRows[0];
                    string s = row.Cells[0].Value.ToString();
                    int orderid = int.Parse(s);
                    DialogResult res = MessageBox.Show("Did you Delievere All Orders with ID " + orderid + " ?",
                "closing",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2);
                    if (res == DialogResult.Yes)
                    {
                        int r1 = controllerObj.AddPay(orderid);
                        if (r1 == 0) MessageBox.Show("foul!");
                        int r = controllerObj.DeleteTheseorder(orderid);
                        if (r != 0)
                        {
                            MessageBox.Show("Good Job!");
                            DataTable dt = controllerObj.GetEmpOrders(username);
                            dataGridView1.DataSource = dt;
                            dataGridView1.Refresh();
                        }
                        

                    }
                }
                
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }












    }
}
