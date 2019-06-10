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
    public partial class Admin : Form
    {
        string user;
        public Admin(string usern)
        {
            user = usern;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminFunctionalities x = new AdminFunctionalities(1,user);
            x.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminFunctionalities x = new AdminFunctionalities(2,user);
            x.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AdminFunctionalities x = new AdminFunctionalities(3,user);
            x.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AdminFunctionalities x = new AdminFunctionalities(4,user);
            x.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            AdminFunctionalities x = new AdminFunctionalities(5,user);
            x.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            AdminFunctionalities x = new AdminFunctionalities(6,user);
            x.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login x = new Login();
            x.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

        }

    }
}
