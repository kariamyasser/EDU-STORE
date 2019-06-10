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
    public partial class CustomerOrders : Form
    {
        string username;
        Controller controllerObj;
        public CustomerOrders(string sn)
        {
            username = sn;
            controllerObj = new Controller();
            InitializeComponent();
            DataTable dt = controllerObj.GetCID(username);
            int s = dt.Rows[0].Field<int>(0);
            int CID;
            CID = s;
            int r = controllerObj.UpdateState(CID);
           
            //DataTable dt2 = controllerObj.GetCUOrders2(CID);

            //CUOrdersGrid.DataSource = dt2;
            //CUOrdersGrid.Refresh();
            this.CustomerOrdersTableAdapter.Fill(this.DataSet1.CustomerOrders,CID);


            this.reportViewer1.RefreshReport();
         }
    



        private void CustomerOrders_Load(object sender, EventArgs e)
        {
           
            
        }

        private void Backbutton_Click(object sender, EventArgs e)
        {
            Menu x = new Menu(username);
            x.Show();
            this.Hide();

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
