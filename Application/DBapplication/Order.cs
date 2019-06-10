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
    public partial class Order : Form
    {
        string username;
        int CID;
        int points;
        Controller controllerObj;
        public Order(string s,int p)
        {
            points = p;
            controllerObj = new Controller();
            InitializeComponent();   
            username = s;

            DataTable dt = controllerObj.GetCID(username);
            int ID = dt.Rows[0].Field<int>(0);
            CID =ID;
            DataTable dt2 = controllerObj.GetSC(CID);
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();
         
        
        }

        private void Order_Load(object sender, EventArgs e)
        {

        }

        private void BackOrderButton_Click(object sender, EventArgs e)
        {
            Menu x = new Menu(username);
            x.Show();
            this.Hide();
        }

        private void ConfirmOrderButton_Click(object sender, EventArgs e)
        {
           bool flag = true;
           if (MethodOfPaymentComboBox.Text == "")//validation part
           {
               MessageBox.Show("Please, insert Method of Payment");
           }

           else
           {


               if (MethodOfPaymentComboBox.Text == "Points")
               {
                   int yourpoints = controllerObj.GetCuPoints(username);
                   if (yourpoints >= points)
                   {
                       controllerObj.DecCuPoints(username,points);
                   }
                   else
                   {
                       MessageBox.Show("Im Sorry,You Dont Have Enough Points");
                       flag = false;
                   }

               }
               else
               {
                   controllerObj.IncCuPoints(username,points);



               }


               if (flag == true)
               {
                   int r1 = controllerObj.AddOrder(CID);
                   if (r1 > 0)
                   {
                       MessageBox.Show("Thank You For Using Our Application,The Item(s) Has Moved To Your Orders Section, They Will reach you as soon as possible");

                       int r2 = controllerObj.DeleteSC(CID);
                       DataTable dt2 = controllerObj.GetSC(CID);
                       dataGridView1.DataSource = dt2;
                       dataGridView1.Refresh();


                   }
                   else
                       MessageBox.Show("Order Failed");
                   int r = controllerObj.UpdateMethod(CID, MethodOfPaymentComboBox.Text.ToString());

                   CustomerOrders x = new CustomerOrders(username);
                   x.Show();
                   this.Hide();
               }
           }

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



    }
}
