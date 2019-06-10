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
    public partial class AssignOrderEmp : Form
    {
        string username;
        Controller controllerObj;
        public AssignOrderEmp(string x)
        {
            username = x;
            controllerObj = new Controller();
            InitializeComponent();

            DataTable dt = controllerObj.GetSname(username);
            string s = dt.Rows[0].Field<string>(0);
            DataTable dt2 = controllerObj.Get_Notass_Orders(s);
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();

            comboBox2.DataSource = dt2;
            comboBox2.DisplayMember = "O_ID";
            comboBox2.ValueMember = "O_ID";

            DataTable dt3 = controllerObj.GetEmployees(s);
            dataGridView2.DataSource = dt3;
            dataGridView2.Refresh();

            comboBox1.DataSource = dt3;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "SSN";


             this.OrdersStatisticsTableAdapter.Fill(this.DataSet1.OrdersStatistics,s);

            this.reportViewer1.RefreshReport();
            }

        private void button2_Click(object sender, EventArgs e)
        {
            Store x = new Store(username);
            x.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (comboBox1.Text == "")//validation part
            {
                MessageBox.Show("Please, insert all values");
            }
            else if (comboBox2.Text == "")
            {

                MessageBox.Show("There is No Un Assigned Orders");
            }
            else
            {



                int r = controllerObj.AssignEmployee(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(comboBox2.SelectedValue.ToString()));
                if (r > 0)
                {
                    MessageBox.Show("Employee Assigned successfully");
                    DataTable dt = controllerObj.GetSname(username);
                    string s = dt.Rows[0].Field<string>(0);
                    DataTable dt2 = controllerObj.Get_Notass_Orders(s);
                    dataGridView1.DataSource = dt2;
                    dataGridView1.Refresh();
                    comboBox2.DataSource = dt2;
                    comboBox2.DisplayMember = "O_ID";
                    comboBox2.ValueMember = "O_ID";
                    if (dataGridView1.Rows.Count == 0)
                    {
                        MessageBox.Show("You Have Assigned All Orders To Employees");

                    }
                    DataTable dt3 = controllerObj.GetEmployees(s);
                    dataGridView2.DataSource = dt3;
                    dataGridView2.Refresh();

                    this.OrdersStatisticsTableAdapter.Fill(this.DataSet1.OrdersStatistics, s);

                    this.reportViewer1.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Error Occured while Assigning");
                }
            }

        }

        private void AssignOrderEmp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.OrdersStatistics' table. You can move, or remove it, as needed.
           
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
