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
    public partial class ViewPayments : Form
    {
        string username;
        Controller controllerObj;
        public ViewPayments(string user)
        {
            username = user;
            controllerObj = new Controller();
            InitializeComponent();
            DataTable dt = controllerObj.GetSname(username);
            string s = dt.Rows[0].Field<string>(0);
            DataTable dt2 = controllerObj.GetPay(s);
            dataGridView1.DataSource = dt2;
            dataGridView1.Refresh();
        }

        private void ViewPayments_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Store x = new Store(username);
            this.Hide();
            x.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
