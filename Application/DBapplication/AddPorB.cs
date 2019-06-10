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
    public partial class AddPorB : Form
    {
       
        static int PID = 10;
        static int BID = 10;
        string username;
        Controller controllerObj;
        int source;
        public AddPorB(int x,string user)
        {
            username = user;
            source = x;
            controllerObj = new Controller();
            InitializeComponent();
            if (x == 0)
            {
               
                label1.Text = "Description : ";
                label2.Text = "Quantity : ";
                label3.Text = "Price Dollars : ";
                label4.Text = "Price Points : ";
        
                label5.Text = "Department";
                label8.Text = "ADD PRODUCT";
                textBox5.Hide();
                DataTable dt = controllerObj.GetSname(username);
                string s = dt.Rows[0].Field<string>(0);
                DataTable dt2 = controllerObj.GetProducts(s);
                dataGridView1.DataSource = dt2;
                dataGridView1.Refresh();
                DataTable dt3 = controllerObj.GetDNames();

                comboBox1.DataSource = dt3;
                comboBox1.DisplayMember = "";
                comboBox1.ValueMember = "Name";
            }
            if (x == 1)
            {
                label1.Text = "Name";
                label2.Text = "Author";
                label3.Text = "Quantity : ";
                label4.Text = "Price Dollars : ";
                label5.Text = "Price Points : ";
                comboBox1.Hide();
                label8.Text = "ADD BOOK";

                DataTable dt = controllerObj.GetSname(username);
                 string s = dt.Rows[0].Field<string>(0);
                DataTable dt2 = controllerObj.GetBooks(s);
                dataGridView1.DataSource = dt2;
                dataGridView1.Refresh();

            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Store x = new Store(username);
            x.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (source == 0)
            {

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || comboBox1.Text == "")//validation part
                {
                    MessageBox.Show("Please, insert all values");
                }
                else
                {
                    DataTable dt3 = controllerObj.GetSname(username);
                    string s3 = dt3.Rows[0].Field<string>(0);
                    bool flag = true;
                    int q;
                    int.TryParse(textBox2.Text, out q); if (q == 0) flag = false;
                    int.TryParse(textBox3.Text, out q); if (q == 0) flag = false;
                    int.TryParse(textBox4.Text, out q); if (q == 0) flag = false;

                    if (flag == true)
                    {
                        int r = controllerObj.InsertProduct(textBox1.Text.ToString(), int.Parse(textBox2.Text.ToString()), int.Parse(textBox3.Text.ToString()), int.Parse(textBox4.Text.ToString()), s3, comboBox1.Text.ToString());
                        if (r > 0)
                        {
                            MessageBox.Show("Product inserted successfully");
                            PID++;
                            DataTable dt = controllerObj.GetSname(username);
                            string s = dt.Rows[0].Field<string>(0);
                            DataTable dt2 = controllerObj.GetProducts(s);
                            dataGridView1.DataSource = dt2;
                            dataGridView1.Refresh();
                        }
                        else
                            MessageBox.Show("Insertion Failed");

                    }
                    else { MessageBox.Show("Please Insert Correct Data"); }
                }

            }
            if (source == 1)
            {

                if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")//validation part
                {
                    MessageBox.Show("Please, insert all values");
                }
                else
                {
                    DataTable dt = controllerObj.GetSname(username);
                    string s = dt.Rows[0].Field<string>(0);
                      bool flag = true;
                    int q;
                    int.TryParse(textBox5.Text, out q); if (q == 0) flag = false;
                    int.TryParse(textBox3.Text, out q); if (q == 0) flag = false;
                    int.TryParse(textBox4.Text, out q); if (q == 0) flag = false;

                    if (flag == true)
                    {
                        int r = controllerObj.InsertBook(textBox1.Text.ToString(), textBox2.Text.ToString(), int.Parse(textBox3.Text.ToString()), int.Parse(textBox4.Text.ToString()), int.Parse(textBox5.Text.ToString()), s);
                        if (r > 0)
                        {
                            MessageBox.Show("Book inserted successfully");
                            BID++;
                            DataTable dt3 = controllerObj.GetSname(username);
                            string s2 = dt3.Rows[0].Field<string>(0);
                            DataTable dt2 = controllerObj.GetBooks(s2);
                            dataGridView1.DataSource = dt2;
                            dataGridView1.Refresh();
                        }
                        else
                            MessageBox.Show("Insertion Failed");
                    }
                    else { MessageBox.Show("Please Insert Correct Data"); }
                }
            }
        }

        private void AddPorB_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
    }
}

