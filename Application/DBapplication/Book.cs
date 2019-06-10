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
    public partial class Book : Form
    {  int  index = 0;
        Controller controllerObj;
        string Cuser;
        string storeselected=" ";
        int search=0;
        public Book(string CuserName)
        {
            InitializeComponent();
            controllerObj = new Controller();
            DataTable dt = controllerObj.GetStores();
            StoreComboBox.DataSource =dt;
            StoreComboBox.DisplayMember = "Name";
            Cuser = CuserName;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Book_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {


            if (BookTextBox.Text.Length == 0 && checkBox1.Checked == false)
            {
                MessageBox.Show("Please Enter Book Name Or Search By A Certain Store");
            }
            else if (BookTextBox.Text.Length != 0 && checkBox1.Checked == false)
            {
                search = 1;
                index = 0;
                
                DataTable dt = controllerObj.GetBooksByBName(BookTextBox.Text);
                BookDataGridView.DataSource = dt;
                BookDataGridView.Refresh();
                if(BookDataGridView.Rows.Count > 0 )
                {
                            label10.Text = BookDataGridView.Rows[index].Cells[0].Value.ToString();
                            label11.Text = BookDataGridView.Rows[index].Cells[1].Value.ToString();
                            label12.Text = BookDataGridView.Rows[index].Cells[3].Value.ToString();
                            label13.Text = BookDataGridView.Rows[index].Cells[4].Value.ToString();
                            label14.Text = BookDataGridView.Rows[index].Cells[5].Value.ToString();
                            label17.Text = BookDataGridView.Rows[index].Cells[2].Value.ToString();
                        }
                        else
                        {

                            label10.Text = "";
                            label11.Text = "";
                            label12.Text = "";
                            label13.Text = "";
                            label14.Text = "";
                            label17.Text = "";

                        }

            }


            if (checkBox1.Checked == true)
            {
                if (BookTextBox.Text.Length == 0)
                {
                    search = 2;
                    string StoreName = StoreComboBox.Text;
                    storeselected = StoreName;
                    DataTable dt = controllerObj.GetBooksByName(StoreName);
                    BookDataGridView.DataSource = dt;
                    BookDataGridView.Refresh();
                    if (BookDataGridView.Rows.Count > 0)
                    {
                        index = 0;
                         label10.Text = BookDataGridView.Rows[index].Cells[0].Value.ToString();
                            label11.Text = BookDataGridView.Rows[index].Cells[1].Value.ToString();
                            label12.Text = BookDataGridView.Rows[index].Cells[3].Value.ToString();
                            label13.Text = BookDataGridView.Rows[index].Cells[4].Value.ToString();
                            label14.Text = BookDataGridView.Rows[index].Cells[5].Value.ToString();
                            label17.Text = BookDataGridView.Rows[index].Cells[2].Value.ToString();
                        }
                        else
                        {

                            label10.Text = "";
                            label11.Text = "";
                            label12.Text = "";
                            label13.Text = "";
                            label14.Text = "";
                            label17.Text = "";

                        }
                }
                else
                {
                    search = 3;
                    string StoreName = StoreComboBox.Text;
                    storeselected = StoreName;
                    DataTable dt = controllerObj.GetBooksByBNameAndStore(BookTextBox.Text, StoreName);
                    BookDataGridView.DataSource = dt;
                    BookDataGridView.Refresh();

                    index = 0;
                    if (BookDataGridView.Rows.Count > 0)
                    {
                        label10.Text = BookDataGridView.Rows[index].Cells[0].Value.ToString();
                            label11.Text = BookDataGridView.Rows[index].Cells[1].Value.ToString();
                            label12.Text = BookDataGridView.Rows[index].Cells[3].Value.ToString();
                            label13.Text = BookDataGridView.Rows[index].Cells[4].Value.ToString();
                            label14.Text = BookDataGridView.Rows[index].Cells[5].Value.ToString();
                            label17.Text = BookDataGridView.Rows[index].Cells[2].Value.ToString();
                        }
                        else
                        {

                            label10.Text = "";
                            label11.Text = "";
                            label12.Text = "";
                            label13.Text = "";
                            label14.Text = "";
                            label17.Text = "";

                        }

                }
            }
        }

        private void AddBookButton_Click(object sender, EventArgs e)
        {
            if (BookDataGridView.Rows.Count > 0)
            {


                int CID = controllerObj.GetCUID(Cuser);



                string storename = BookDataGridView.Rows[index].Cells[5].Value.ToString();


                string ItemName = BookDataGridView.Rows[index].Cells[0].Value.ToString();
                string priceDollar = BookDataGridView.Rows[index].Cells[3].Value.ToString();
                string PricePoints = BookDataGridView.Rows[index].Cells[4].Value.ToString();

                int result = controllerObj.AddBookToSC(CID, CID, ItemName, storename, Int32.Parse(priceDollar), Int32.Parse(PricePoints));
                if (result == 1)
                {
                   controllerObj.DecBQuantity(ItemName, storename);

                    MessageBox.Show("Item Added To Shopping Cart");
                    if (search == 1)
                    {
                        index = 0;

                        DataTable dt = controllerObj.GetBooksByBName(BookTextBox.Text);
                        BookDataGridView.DataSource = dt;
                        BookDataGridView.Refresh();
                        if (BookDataGridView.Rows.Count > 0)
                        {
                            label10.Text = BookDataGridView.Rows[index].Cells[0].Value.ToString();
                            label11.Text = BookDataGridView.Rows[index].Cells[1].Value.ToString();
                            label12.Text = BookDataGridView.Rows[index].Cells[3].Value.ToString();
                            label13.Text = BookDataGridView.Rows[index].Cells[4].Value.ToString();
                            label14.Text = BookDataGridView.Rows[index].Cells[5].Value.ToString();
                            label17.Text = BookDataGridView.Rows[index].Cells[2].Value.ToString();
                        }
                        else
                        {

                            label10.Text = "";
                            label11.Text = "";
                            label12.Text = "";
                            label13.Text = "";
                            label14.Text = "";
                            label17.Text = "";

                        }


                    }
                    if (search == 2)
                    {
                        string StoreName = StoreComboBox.Text;
                        storeselected = StoreName;
                        DataTable dt = controllerObj.GetBooksByName(StoreName);
                        BookDataGridView.DataSource = dt;
                        BookDataGridView.Refresh();
                        if (BookDataGridView.Rows.Count > 0)
                        {
                            index = 0;
                            label10.Text = BookDataGridView.Rows[index].Cells[0].Value.ToString();
                            label11.Text = BookDataGridView.Rows[index].Cells[1].Value.ToString();
                            label12.Text = BookDataGridView.Rows[index].Cells[3].Value.ToString();
                            label13.Text = BookDataGridView.Rows[index].Cells[4].Value.ToString();
                            label14.Text = BookDataGridView.Rows[index].Cells[5].Value.ToString();
                            label17.Text = BookDataGridView.Rows[index].Cells[2].Value.ToString();
                        }
                        else
                        {

                            label10.Text = "";
                            label11.Text = "";
                            label12.Text = "";
                            label13.Text = "";
                            label14.Text = "";
                            label17.Text = "";

                        }


                    }
                    if (search == 3)
                    {
                        string StoreName = StoreComboBox.Text;
                        storeselected = StoreName;
                        DataTable dt = controllerObj.GetBooksByBNameAndStore(BookTextBox.Text, StoreName);
                        BookDataGridView.DataSource = dt;
                        BookDataGridView.Refresh();

                        index = 0;
                        if (BookDataGridView.Rows.Count > 0)
                        {
                            label10.Text = BookDataGridView.Rows[index].Cells[0].Value.ToString();
                            label11.Text = BookDataGridView.Rows[index].Cells[1].Value.ToString();
                            label12.Text = BookDataGridView.Rows[index].Cells[3].Value.ToString();
                            label13.Text = BookDataGridView.Rows[index].Cells[4].Value.ToString();
                            label14.Text = BookDataGridView.Rows[index].Cells[5].Value.ToString();
                            label17.Text = BookDataGridView.Rows[index].Cells[2].Value.ToString();
                        }
                        else
                        {

                            label10.Text = "";
                            label11.Text = "";
                            label12.Text = "";
                            label13.Text = "";
                            label14.Text = "";
                            label17.Text = "";

                        }


                        }


                    

                }




            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BackBookButton_Click(object sender, EventArgs e)
        {
            Menu M = new Menu(Cuser);
            M.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BookDataGridView.Rows.Count > 0)
            {
                if (index > 0) index--;


                label10.Text = BookDataGridView.Rows[index].Cells[0].Value.ToString();
                label11.Text = BookDataGridView.Rows[index].Cells[1].Value.ToString();
                label12.Text = BookDataGridView.Rows[index].Cells[3].Value.ToString();
                label13.Text = BookDataGridView.Rows[index].Cells[4].Value.ToString();
                label14.Text = BookDataGridView.Rows[index].Cells[5].Value.ToString();
                label17.Text = BookDataGridView.Rows[index].Cells[2].Value.ToString();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (BookDataGridView.Rows.Count > 0)
            {
                if (index < BookDataGridView.Rows.Count - 2) { index++; }
                label10.Text = BookDataGridView.Rows[index].Cells[0].Value.ToString();
                label11.Text = BookDataGridView.Rows[index].Cells[1].Value.ToString();
                label12.Text = BookDataGridView.Rows[index].Cells[3].Value.ToString();
                label13.Text = BookDataGridView.Rows[index].Cells[4].Value.ToString();
                label14.Text = BookDataGridView.Rows[index].Cells[5].Value.ToString();
                label17.Text = BookDataGridView.Rows[index].Cells[2].Value.ToString();
            }
            
        }
    }
}
