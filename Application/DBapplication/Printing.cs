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
    public partial class Printing : Form
    {
        Controller controllerObj;
        string cuname;
        public Printing(string Cname)
        {
            InitializeComponent();
            controllerObj = new Controller();
            cuname = Cname;
        }

        private void PrintingPaperSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddPrintingButton_Click(object sender, EventArgs e)
        {
            string link = PrintingLinkTextBox.Text;
            string color = PrintingColorCombobox.Text;
            string size = PrintingPaperSizeComboBox.Text;
            string number = PrintingCopiesTextBox.Text;
            int num = 0;
            int Cid = controllerObj.GetCUID(cuname);
            int r = 0;
            Int32.TryParse(number, out num);
            
            if (link.Length != 0)
            {
                if (num == 0 || size.Length==0 || color.Length==0)
                {
                    MessageBox.Show("Please Enter All Values ");
                }
                else 
                {
                    r = controllerObj.InsertPrinting(num, link, size, color, Cid, Cid);
                }
                if (r == 0)
                {
                    MessageBox.Show("Order failed");

                }
                else
                {
                    MessageBox.Show("Your Order has been done");
                }

            }
            else
            {
                MessageBox.Show("Please insert a link");
            }
        }

        private void Printing_Load(object sender, EventArgs e)
        {

        }

        private void BackPrintingButton_Click(object sender, EventArgs e)
        {
            Menu M = new Menu(cuname);
            M.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
