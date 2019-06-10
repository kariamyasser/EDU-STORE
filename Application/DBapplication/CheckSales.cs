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
    public partial class CheckSales : Form
    {
        string cuser;
        Controller controllerObj;
        public CheckSales(string user)
        {
            cuser=user;
            InitializeComponent();
        }

        private void CheckSales_Load(object sender, EventArgs e)
        {
           
            controllerObj = new Controller();
            //DataTable dt = controllerObj.GetDNames();
        
            //    DnamesCombobox.DataSource = dt;
            //    DnamesCombobox.DisplayMember = "NAME";
            this.SalesStatisticsTableAdapter.Fill(this.DataSet1.SalesStatistics);


            this.reportViewer2.RefreshReport();
        }

        
        private void BackSalesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
           Menu x = new Menu(cuser);
           x.Show();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
