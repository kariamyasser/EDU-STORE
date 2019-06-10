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
    public partial class UpdateInfo : Form
    {
        string Cusername;
        Controller controllerObj;
        public UpdateInfo(string Cuser)
        {
            Cusername = Cuser;
            InitializeComponent();
            controllerObj = new Controller();
        }



        private void UpdateInfo_Load(object sender, EventArgs e)
        {

        }

        private void ChangeEmailButton_Click(object sender, EventArgs e)
        {
            if (ChangeEmailButton.Text.Length != 0)
            {
                int r = controllerObj.UpdateE(Cusername, ChangeEmailButton.Text);
                if (r == 1)
                {
                    MessageBox.Show("Email Updated");
                }


            }
            else
            {
                MessageBox.Show("Please Enter An Email");
            }





        }

        private void ChangeAdressButton_Click(object sender, EventArgs e)
        {
            if ( ChangeAdressButton.Text.Length!=0)

            {
                int r = controllerObj.UpdateAddress(Cusername, ChangeAdressButton.Text);
                if (r == 1)
                {
                    MessageBox.Show("Adress Updated");
                }


            }
            else
            {
                MessageBox.Show("Please Enter An Adress ");
            }

        }

        private void ChangeNumButton_Click(object sender, EventArgs e)
        {

            int ph = 0;
            Int32.TryParse(ChangeNumButton.Text, out ph);

            if ( ChangeNumButton.Text.Length != 0)
            {
                if (ph != 0)
                {
                    int r = controllerObj.UpdatePhone(Cusername, ph);


                    if (r == 1)
                    {
                        MessageBox.Show("Adress Updated");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Phone");
                }


            }
            else
            {
                MessageBox.Show("Please Enter A Phone Number");
            }
        }

        private void ChangeCrCard_Click(object sender, EventArgs e)
        {
            int cr = 0;
            Int32.TryParse(ChangeNumButton.Text, out cr);

            if (ChangeCrCard.Text.Length!=0)
            {
                if (cr != 0)
                {
                    int r = controllerObj.UpdateCr (Cusername, cr);


                    if (r == 1)
                    {
                        MessageBox.Show("Credit Card Updated");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Valid Credit Card");
                }


            }
            else
            {
                MessageBox.Show("Please Enter A Credit Card Number");
            }
        }
    }
}
