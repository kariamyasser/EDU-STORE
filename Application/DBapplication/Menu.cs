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
    public partial class Menu : Form
    {
        string Cusername;
        public Menu(string username)
        {
            Cusername = username;
            InitializeComponent();
        }

        private void Changepass_Click(object sender, EventArgs e)
        {
            CustomerChangePass x = new CustomerChangePass(Cusername);
            x.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            Login x = new Login();
            x.Show();
            this.Hide();
        }

        private void ViewAllSalesbutton_Click(object sender, EventArgs e)
        {
            CheckSales x = new CheckSales(Cusername);
            x.Show();
            this.Hide();
        }

        private void myorder_Click(object sender, EventArgs e)
        {
            CustomerOrders x = new CustomerOrders(Cusername);
            x.Show();
            this.Hide();
        }

        private void ViewShoppingCartButton_Click(object sender, EventArgs e)
        {
            ShoppingCart x = new ShoppingCart(Cusername);
            x.Show();
            this.Hide();
        }

        private void BooksButton_Click(object sender, EventArgs e)
        {
            Book B = new Book(Cusername);
            B.Show();
            this.Hide();
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void OrderProductButton_Click(object sender, EventArgs e)
        {
            Product B = new Product(Cusername);
            B.Show();
            this.Hide();
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            Printing P = new Printing(Cusername);
            P.Show();
            this.Hide();
        }
    }
}
