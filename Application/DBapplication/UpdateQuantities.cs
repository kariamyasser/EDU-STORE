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
  
    public partial class UpdateQuantities : Form
    {
        string username;
        Controller controllerObj;
        int source;
        

        public UpdateQuantities(int x,string s)
        {
             username = s;
            source = x;
            controllerObj = new Controller();
            InitializeComponent();


            if (x == 0)
            {

                reportViewer2.Visible = false;
                DataTable dt = controllerObj.GetSname(username);
                string sW = dt.Rows[0].Field<string>(0);
                DataTable dt2 = controllerObj.GetProducts(sW);
                dataGridView1.DataSource = dt2;
                dataGridView1.Refresh();
                this.ProductQuantitiesTableAdapter.Fill(this.DataSet1.ProductQuantities, sW);

                this.reportViewer1.RefreshReport();
            }
            if (x == 1)
            {
                reportViewer1.Visible = false;
                label1.Text = "UPDATE BOOK QUANTITIES";
                label2.Text = "Quantity";
                label3.Text = "Book ID";
                DataTable dt = controllerObj.GetSname(username);
                string sww = dt.Rows[0].Field<string>(0);
                DataTable dt2 = controllerObj.GetBooks(sww);
                dataGridView1.DataSource = dt2;
                dataGridView1.Refresh();
                this.BookQuantitiesTableAdapter.Fill(this.DataSet1.BookQuantities,sww);
                this.reportViewer2.RefreshReport();
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

                if (textBox1.Text == "" || textBox2.Text == "")//validation part
                {
                    MessageBox.Show("Please, insert all values");
                }
                else
                {
                    DataTable dt3 = controllerObj.GetSname(username);
                    string s3 = dt3.Rows[0].Field<string>(0);
                      bool flag = true;
                    int q;
                    int.TryParse(textBox1.Text, out q); if (q == 0) flag = false;
                    int.TryParse(textBox2.Text, out q); if (q == 0) flag = false;

                    if (flag == true)
                    {
                        int r = controllerObj.UpdateProduct(int.Parse(textBox1.Text.ToString()), int.Parse(textBox2.Text.ToString()));
                        if (r > 0)
                        {
                            MessageBox.Show("Product Update successfully");

                            DataTable dt = controllerObj.GetSname(username);
                            string s = dt.Rows[0].Field<string>(0);
                            DataTable dt2 = controllerObj.GetProducts(s);
                            dataGridView1.DataSource = dt2;
                            dataGridView1.Refresh();
                            this.ProductQuantitiesTableAdapter.Fill(this.DataSet1.ProductQuantities, s);

                            this.reportViewer1.RefreshReport();
                        }
                        else
                            MessageBox.Show("Product Update Failed");
                    }
                    else
                        MessageBox.Show("Please insert correct data ");
                }

            }
            if (source == 1)
            {

                if (textBox1.Text == "" || textBox2.Text == "" )
                {
                    MessageBox.Show("Please, insert all values");
                }
                else
                {
                    DataTable dt = controllerObj.GetSname(username);
                    string s = dt.Rows[0].Field<string>(0);
                       bool flag = true;
                    int q;
                    int.TryParse(textBox1.Text, out q); if (q == 0) flag = false;
                    int.TryParse(textBox2.Text, out q); if (q == 0) flag = false;

                    if (flag == true)
                    {
                        int r = controllerObj.UpdateBook(int.Parse(textBox1.Text.ToString()), int.Parse(textBox2.Text.ToString()));
                        if (r > 0)
                        {
                            MessageBox.Show("Book updated successfully");

                            DataTable dt3 = controllerObj.GetSname(username);
                            string s2 = dt3.Rows[0].Field<string>(0);
                            DataTable dt2 = controllerObj.GetBooks(s2);
                            dataGridView1.DataSource = dt2;
                            dataGridView1.Refresh();
                            this.BookQuantitiesTableAdapter.Fill(this.DataSet1.BookQuantities, s2);
                            this.reportViewer2.RefreshReport();
                        }

                        else
                            MessageBox.Show("Book Update Failed");
                    }
                    else
                        MessageBox.Show("Please Insert Correct Data");
                }
            }
        






        }

        private void UpdateQuantities_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSet1.BookQuantities' table. You can move, or remove it, as needed.
           
            // TODO: This line of code loads data into the 'DataSet1.ProductQuantities' table. You can move, or remove it, as needed.
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }










    }
}
