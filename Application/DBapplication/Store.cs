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
    public partial class Store : Form
    {
        string username;
        public Store(string user)
        {
            username = user;
            InitializeComponent();
        }

        private void Updateinfobutton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPorB x = new AddPorB(0,username);
            x.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddPorB x = new AddPorB(1,username);
            x.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PricesConf x = new PricesConf( username);
            x.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AssignOrderEmp x = new AssignOrderEmp(username);
            x.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            UpdateQuantities x = new UpdateQuantities(0,username);
            x.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Login x = new Login();
            x.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UpdateQuantities x = new UpdateQuantities(1,username);
            x.Show();
            this.Hide();
        }

        private void ChangePass_Click(object sender, EventArgs e)
        {
            StoreChangePass x = new StoreChangePass(username);
            x.Show();
            this.Hide();
        }

        private void Store_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            NewEmp x =new NewEmp(username);
            this.Hide();
            x.Show();
        }

        private void myorders_Click(object sender, EventArgs e)
        {
            StoreOrders x = new StoreOrders(username);
            this.Hide();
            x.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            deleteemp x = new deleteemp(username);
            x.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ViewPayments x = new ViewPayments(username);
            x.Show();
            this.Hide();
        }
    }
}
