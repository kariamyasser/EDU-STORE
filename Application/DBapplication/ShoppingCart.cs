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
    public partial class ShoppingCart : Form
    {
        string username;
        int CID;
        int points;
        Controller controllerObj;
        public ShoppingCart(string x )
        {
            controllerObj = new Controller();
            
            InitializeComponent();
            username = x;

            DataTable dt = controllerObj.GetCID(x);
            int s = dt.Rows[0].Field<int>(0);
            CID = s;
            DataTable dt2 = controllerObj.GetSC(s);
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();
            if (dataGridView1.Rows.Count != 0)
            {
                DataTable dt3 = controllerObj.GetCost(CID);
                int d = dt3.Rows[0].Field<int>(0);
                int p = dt3.Rows[0].Field<int>(1);

                points = p;

                label4.Text = d.ToString();
                label5.Text = p.ToString();
            }

        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Menu x = new Menu(username);
            x.Show();
            this.Hide();


        }

        private void Orderbutton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("You have to add an item first to order it");

            }
            else
            {
                Order x = new Order(username,points);
                x.Show();
                this.Hide();
            }
        }

        private void ShoppingCart_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = true;
            int rowindex=0;
            try
            {
                rowindex = dataGridView1.CurrentCell.RowIndex;
            }
            catch (Exception) { flag = false; }
            if (flag == true)
            {
                string Id = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
                string itemname = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
                string storename = dataGridView1.Rows[rowindex].Cells[2].Value.ToString();
                int SID = int.Parse(Id);
                DataTable dt=controllerObj.GetItemDepartment(SID);
                if (dt == null)
                {

                    controllerObj.IncBQuantity(itemname, storename);
                }
                else
                {
                    controllerObj.IncPQuantity(itemname, storename);

                }
                int result = controllerObj.DeleteFsc(int.Parse(Id));
                if (result == 1)
                {
                    MessageBox.Show("Item Removed Successfully");



                    DataTable dt2 = controllerObj.GetSC(CID);
                    dataGridView1.DataSource = dt2;
                    dataGridView1.Refresh();
                    if (dataGridView1.Rows.Count != 0)
                    {
                        DataTable dt3 = controllerObj.GetCost(CID);
                        int d = dt3.Rows[0].Field<int>(0);
                        int p = dt3.Rows[0].Field<int>(1);
                        points = p;
                        label4.Text = d.ToString();
                        label5.Text = p.ToString();
                    }
                    else
                    {
                        label4.Text = "00 $";
                        label5.Text = "00";
                    }
                }

               
            }
        }

        
    }
}
