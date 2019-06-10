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
    public partial class StoreOrders : Form
    {
        string username;
        Controller controllerObj;
        public StoreOrders(string sn)
        {
            controllerObj = new Controller();
            username=sn;
           
           
            InitializeComponent();
          
        }

        private void StoreOrders_Load(object sender, EventArgs e)
        {
            string storename;
            DataTable dt = controllerObj.GetSname(username);
            storename = dt.Rows[0].Field<string>(0);

            // TODO: This line of code loads data into the 'DataSet1.StoreOrders' table. You can move, or remove it, as needed.
            this.StoreOrdersTableAdapter.Fill(this.DataSet1.StoreOrders,storename);

            this.reportViewer1.RefreshReport();
        }

        private void Back_Click(object sender, EventArgs e)
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
