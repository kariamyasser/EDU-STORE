using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public int DeleteFsc(int id)
        {
            string StoredProcedureName = StoredProcedures.DeleteFsc;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();


            Parameters.Add("@id", id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int DeleteEmp(int id)
        {
            string StoredProcedureName = StoredProcedures.DeleteEmp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();


            Parameters.Add("@id", id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public int CheckPassword_Basic(string query)
        {
            object p = dbMan.ExecuteScalar2(query);
            if (p == null) return 0;
            else return 1;
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }

        // AHMED
        public int UpdateE(string username, string Em)
        {

            string StoredProcedureName = StoredProcedures.UpdateE;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@UserName", username);
            Parameters.Add("@email", Em);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdatePhone(string username, int phone)
        {

            string StoredProcedureName = StoredProcedures.UpdatePhone;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@UserName", username);
            Parameters.Add("@Phone", phone);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdateCr(string username, int cr)
        {

            string StoredProcedureName = StoredProcedures.UpdateCr;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@UserName", username);
            Parameters.Add("@Cr", cr);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdateAddress(string username, string Ad)
        {

            string StoredProcedureName = StoredProcedures.UpdateAdress;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@UserName", username);
            Parameters.Add("@Adress", Ad);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int insert_customer(string name, string username, string email, int phone, int age, string pass, string address, int cr)
        {
            string StoredProcedureName = StoredProcedures.InsertCustomer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            int zero = 0;

            Parameters.Add("@UserName", username);
            Parameters.Add("@Cuname", name);
            Parameters.Add("@Password", pass);
            Parameters.Add("@phone", phone);
            Parameters.Add("@Walletpoints", zero);
            Parameters.Add("@address", address);



            int r = dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
            if (email.Length != 0)
            {
                string StoredProcedureName1 = StoredProcedures.UpdateEmail;
                Dictionary<string, object> Parameterss = new Dictionary<string, object>();
                Parameterss.Add("@Email", email);
                Parameterss.Add("@UserName", username);


                dbMan.ExecuteNonQuery(StoredProcedureName1, Parameterss);

            }
            if (cr != 0)
            {
                string StoredProcedureName1 = StoredProcedures.UpdateCard;
                Dictionary<string, object> Parameterss = new Dictionary<string, object>();
                Parameterss.Add("@Card", cr);
                Parameterss.Add("@UserName", username);


                dbMan.ExecuteNonQuery(StoredProcedureName1, Parameterss);

            }
            if (age != 0)
            {
                string StoredProcedureName1 = StoredProcedures.UpdateAge;
                Dictionary<string, object> Parameterss = new Dictionary<string, object>();
                Parameterss.Add("@age", age);
                Parameterss.Add("@UserName", username);


                dbMan.ExecuteNonQuery(StoredProcedureName1, Parameterss);

            }

            return r;


        }
        public int insert_shopping(int cid)
        {
            string StoredProcedureName = StoredProcedures.InsertShopping;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            
            Parameters.Add("@CU_ID", cid);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public DataTable GetAllBooks()
        {
            string StoredProcedureName = StoredProcedures.GetBooks;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public DataTable GetBooksByName(string name)
        {
            string StoredProcedureName = StoredProcedures.GetBookByName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetBooksByBName(string name)
        {
            string StoredProcedureName = StoredProcedures.GetBookByBName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@BName", name);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetBooksByBNameAndStore(string Bname, string Sname)
        {
            string StoredProcedureName = StoredProcedures.GetBookByNameAndStore;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@BName", Bname);
            Parameters.Add("@SName", Sname);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int GetCUID(string Cuser)
        {
            string StoredProcedureName = StoredProcedures.GetIDByName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CName",Cuser);

            return (int) dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }



        public int AddBookToSC(int CID, int SCID, string item, string storename, int PD, int PP)
        {
            string StoredProcedureName = StoredProcedures.AddBookToSc;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CU_ID", CID);
            Parameters.Add("@SC_ID", SCID);
            Parameters.Add("@Item", item);
            Parameters.Add("@store_name", storename);
            Parameters.Add("@Price_dollars", PD);
            Parameters.Add("@Price_points", PP);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int InsertPrinting(int Num, string link, string size, string color, int sid, int cid)
        {
            string StoredProcedureName = StoredProcedures.InsertPrintingto;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@NoOfCopies", Num);
            Parameters.Add("@Source", link);
            Parameters.Add("@size", size);
            Parameters.Add("@color", color);
            Parameters.Add("@CU_ID", cid);
            Parameters.Add("@SC_ID", sid);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        //..................................................

        public int InsertBook( string Name, string Author, int quantity, int pd, int pp, string sn)
        {
            String StoredProcedureName = StoredProcedures.AddBook;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

         
            Parameters.Add("@Name", Name);
            Parameters.Add("@Author", Author);
            Parameters.Add("@Quantity", quantity);
            Parameters.Add("@Price_dollars", pd);
            Parameters.Add("@Price_points", pp);
            Parameters.Add("@store_name", sn);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public int CheckName(string user)
        {
            string StoredProcedureName = StoredProcedures.CheckName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@UName", user);

            return (int)dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }

        //Admin Functionalities
        public int AddStore(string name, string address, string username, string password)
        {

            string StoredProcedureName = StoredProcedures.AddStore;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            Parameters.Add("@Address", address);
            Parameters.Add("@Username", username);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteNonQuery(StoredProcedureName,Parameters);
        }



        public int AddPay(int id)
        {

            string StoredProcedureName = StoredProcedures.AddPay;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
           
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int AddAdmin(string username, string password)
        {

            string StoredProcedureName = StoredProcedures.AddAdmin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int RemoveAdmin(string username)
        {

            string StoredProcedureName = StoredProcedures.RemoveAdmin;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
           
            Parameters.Add("@Username", username);
                return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int RemoveStore(string username)
        {

            string StoredProcedureName = StoredProcedures.RemoveStore;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@name", username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int RemoveCustomer(string username)
        {

            string StoredProcedureName = StoredProcedures.DeleteCustomer;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username", username);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdateAdminPass(string username,string password)
        {

            string StoredProcedureName = StoredProcedures.UpdateAdminPassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Username", username);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdateStorePass(string username, string password)
        {

            string StoredProcedureName = StoredProcedures.UpdateStorePassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Username", username);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdateCustomerPass(string username, string password)
        {

            string StoredProcedureName = StoredProcedures.UpdateCustomerPassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Username", username);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int UpdateEmployeePass(string username, string password)
        {

            string StoredProcedureName = StoredProcedures.UpdateEmployeePassword;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Username", username);
            Parameters.Add("@Password", password);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }


        public DataTable GetPrintOrders()
        {
            String StoredProcedureName = StoredProcedures.AllPrints;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }
        public DataTable GetStores()
        {
            string StoredProcedureName = StoredProcedures.AllStores;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }
        public DataTable GetCustomers()
        {

            string StoredProcedureName = StoredProcedures.AllCustomers;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }


        public int GetCuPoints(string username)
        {
            String StoredProcedureName = StoredProcedures.GetCuPoints;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@username", username);
            
            
            return (int) dbMan.ExecuteScalar(StoredProcedureName, Parameters);



        }

        public DataTable GetItemDepartment(int ID)
        {
            String StoredProcedureName = StoredProcedures.GetCuPoints;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@username", ID);


            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

       

        public int DecCuPoints(string username,int points)
        {
            String StoredProcedureName = StoredProcedures.DecCuPoints;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Username", username);
            Parameters.Add("@Points", points);

            return (int)dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public int IncCuPoints(string username, int points)
        {
            String StoredProcedureName = StoredProcedures.IncCuPoints;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Username", username);
            Parameters.Add("@Points", points);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public DataTable GetAdmins()
        {
            String StoredProcedureName = StoredProcedures.AllAdmins;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }
        public int AssignPrint(string id, string pd,string pp)
        {

            string StoredProcedureName = StoredProcedures.AssignPrinting;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@Price_dollars", pd);
            Parameters.Add("@Price_points", pp);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        
        
        
        //Store Functionalities
        
        public DataTable GetProducts(string s)
        {
            String StoredProcedureName = StoredProcedures.AllProducts;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Storename", s);
            
            
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }
        public DataTable GetSales(string s)
        {
            String StoredProcedureName = StoredProcedures.AllSales;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Storename", s);


            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetEmployees(string s)
        {
            String StoredProcedureName = StoredProcedures.GetEmployees;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Storename", s);


            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetBooks(string s)
        {
            String StoredProcedureName = StoredProcedures.AllBooks;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Storename", s);


            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
 
        }
        public DataTable GetOrders(string s)
        {
            String StoredProcedureName = StoredProcedures.AllOrders;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Storename", s);


            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
         
        }

        public DataTable GetPay(string s)
        {
            String StoredProcedureName = StoredProcedures.GetPay;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@storename", s);


            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public DataTable Get_Notass_Orders(string s)
        {
            String StoredProcedureName = StoredProcedures.Get_Notass_Orders;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Storename", s);


            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
         
        }
        
        public DataTable GetSname(string s)
        {
            String StoredProcedureName = StoredProcedures.GetSname;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@username", s);


            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }
        public int CountCustomer()
        {

            String StoredProcedureName = StoredProcedures.CountCustomer;
            return ( int)dbMan.ExecuteScalar(StoredProcedureName, null);

        }
        public int InsertProduct( string desc,int quantity,int pd,int pp,string sn,string dn)
        {
            String StoredProcedureName = StoredProcedures.AddProduct;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
         
            Parameters.Add("@Description",desc);
            Parameters.Add("@Quantity", quantity);
            Parameters.Add("@Price_dollars", pd);
            Parameters.Add("@Price_points", pp);
            Parameters.Add("@store_name", sn);
            Parameters.Add("@Dname", dn);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }


        public int InsertSale( int perc, string dn, string sn)
        {

            String StoredProcedureName = StoredProcedures.AddSale;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

         
            Parameters.Add("@percentage", perc);
            Parameters.Add("@Dname", dn);
            Parameters.Add("@Storename", sn);
  
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public int InsertEmployee(string name, string username, string password,int hours,string sn)
        {

            String StoredProcedureName = StoredProcedures.AddEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Name", name);
            Parameters.Add("@Username", username);
            Parameters.Add("@Password", password);
            Parameters.Add("@Hours",hours);
            Parameters.Add("@Storename", sn);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public int Addsale(float perc,string dn,string sn)
        {
            String StoredProcedureName = StoredProcedures.Addsale;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            
            Parameters.Add("@percentage", perc);
             Parameters.Add("@Dname", dn);
             Parameters.Add("@Storename", sn);


             return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public int Removesale(float perc, string dn, string sn)
        {
            String StoredProcedureName = StoredProcedures.Removesale;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
           
            Parameters.Add("@percentage", perc);
            Parameters.Add("@Dname", dn);
            Parameters.Add("@Storename", sn);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public int Incprice(float perc, string dn, string sn)
        {
            String StoredProcedureName = StoredProcedures.Incprice;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
          
            Parameters.Add("@percentage", perc);
            Parameters.Add("@Dname", dn);
            Parameters.Add("@Storename", sn);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public int CheckSales(string Dname, String Storename)
        {
            String StoredProcedureName = StoredProcedures.CheckSales;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

           
            Parameters.Add("@Dname", Dname);
            Parameters.Add("@Storename",Storename);

            return (int) dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }
        public int DeleteSale(string Dname, String Storename)
        {
            String StoredProcedureName = StoredProcedures.DeleteSale;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();


            Parameters.Add("@Dname", Dname);
            Parameters.Add("@Storename", Storename);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public int DecBQuantity(string ItemName,string storename)
        {
            String StoredProcedureName = StoredProcedures.DecBQuantity;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();


            Parameters.Add("@itemname", ItemName);
            Parameters.Add("@storename", storename);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public int DecPQuantity(string ItemName, string storename)
        {

            String StoredProcedureName = StoredProcedures.DecPQuantity;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();


            Parameters.Add("@itemname", ItemName);
            Parameters.Add("@storename", storename);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public int  IncBQuantity(string itemname,string storename)
        {

            String StoredProcedureName = StoredProcedures.IncPQuantity;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();


            Parameters.Add("@itemname", itemname);
            Parameters.Add("@storename", storename);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);


        }
        public int IncPQuantity(string itemname, string storename)
        {

            String StoredProcedureName = StoredProcedures.IncPQuantity;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();


            Parameters.Add("@itemname", itemname);
            Parameters.Add("@storename", storename);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);


        }

        public int GetPercent(string Dname, String Storename)
        {
            String StoredProcedureName = StoredProcedures.GetPercent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();


            Parameters.Add("@Dname", Dname);
            Parameters.Add("@Storename", Storename);

            return (int) dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }




        public int AssignEmployee(int ssn,int oid)
        {
            String StoredProcedureName = StoredProcedures.AssignEmployee;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@ssn", ssn);
            Parameters.Add("@order_id", oid);
          
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public int UpdateProduct(int quantity, int id)
        {
            String StoredProcedureName = StoredProcedures.UpdateProduct;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@quantity", quantity);
            Parameters.Add("@id", id);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public int UpdateBook(int quantity, int id)
        {
            String StoredProcedureName = StoredProcedures.UpdateBook;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@quantity", quantity);
            Parameters.Add("@id", id);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }



        ///Customer Functionalities
        public DataTable GetSC(int s)
        {
            String StoredProcedureName = StoredProcedures.GetSC;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@CID", s);


            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }
        public DataTable GetCID(string s)
        {
            String StoredProcedureName = StoredProcedures.GetCID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@Username", s);


            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetCost(int s)
        {
            String StoredProcedureName = StoredProcedures.GetCost;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@CID", s);


            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int DeleteSC( int id)
        {
            String StoredProcedureName = StoredProcedures.DeleteSC;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@CID", id);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public int AddOrder(int id)
        {
            String StoredProcedureName = StoredProcedures.AddOrder;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@CID", id);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public DataTable GetCUOrders(int s)
        {
            String StoredProcedureName = StoredProcedures.GetCUOrders;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@CID", s);


            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetCUOrders2(int s)
        {
            String StoredProcedureName = StoredProcedures.GetCUOrders2;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@CID", s);


            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }



        public int UpdateMethod(int id,string meth)
        {
            String StoredProcedureName = StoredProcedures.UpdateMethod;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();

            Parameters.Add("@CID", id);
            Parameters.Add("@method", meth);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        public int UpdateState(int id)
        {
            String StoredProcedureName = StoredProcedures.UpdateState;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            
            Parameters.Add("@CID", id);
            Parameters.Add("@x", "Is Shipped");
            Parameters.Add("@xx", "Being Prepared");
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }
        ///// mostafa 
        public DataTable GetDNames()
        {
            String StoredProcedureName = StoredProcedures.GetDnames;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }
        public DataTable GetEmpOrders(string Empuser)
        {

            string StoredProcedureName = StoredProcedures.GetEmpOrders;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Username",Empuser);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public int DeleteTheseorder(int orderid)
        {
            string StoredProcedureName = StoredProcedures.DeleteTheseOrders;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@O_ID", orderid);
            
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        // ali's product
        // // // // / / / // / / / / --------------------------------------
        public DataTable GetAllProducts()
        {
            string StoredProcedureName = StoredProcedures.GetProducts;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public DataTable GetProductsByStoreName(string name, string dname)
        {
            string StoredProcedureName = StoredProcedures.GetProductByStoreName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Name", name);
            Parameters.Add("@DName", dname);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetProductsByName(string name, string dname)
        {
            string StoredProcedureName = StoredProcedures.GetProductByName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Pname", name);
            Parameters.Add("@DName", dname);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public DataTable GetProductsByNameAndStore(string Pname, string Sname, string dname)
        {
            string StoredProcedureName = StoredProcedures.GetProductByNameAndStore;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Pname", Pname);
            Parameters.Add("@SName", Sname);
            Parameters.Add("@DName", dname);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }
        public int AddProductToSC(int CID, int SCID, string item, string storename, int PD, int PP, string DN)
        {
            string StoredProcedureName = StoredProcedures.AddProductToSc;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@CU_ID", CID);
            Parameters.Add("@SC_ID", SCID);
            Parameters.Add("@Item", item);
            Parameters.Add("@store_name", storename);
            Parameters.Add("@Price_dollars", PD);
            Parameters.Add("@Price_points", PP);
            Parameters.Add("@DName", DN);


            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        //-----------------------------------------------------------------------------------aa


    }
}
