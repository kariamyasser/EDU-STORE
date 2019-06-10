using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBapplication
{
    public class StoredProcedures
    {
        public static string RemoveAdmin = "delete_admin";
        public static string AddAdmin= "insert_admin";
        public static string RemoveStore = "delete_store";
        public static string AddStore="insert_store";
        public static string UpdateAdminPassword = "Update_AdminPassword";
        public static string DeleteCustomer = "delete_customer";
        public static string AllCustomers = "get_customer";
        public static string AllAdmins = "get_admin";
        public static string AllStores = "get_store";

 ///////////////////////

        public static string AllProducts= "get_product";
        public static string AllSales = "get_sale";
        public static string AllBooks = "get_book";
        public static string AllOrders = "get_order";
        public static string Get_Notass_Orders = "get_Notass_order";
        public static string AllPrints = "get_printorder";
        public static string UpdateStorePassword= "Update_StorePassword";
        public static string AddProduct = "insert_product";
        public static string AddBook = "insert_book";
        public static string AddSale = "insert_sale";

        public static string Addsale = "Add_price_sales";
        public static string Removesale = "Remove_price_sales";
        public static string Incprice = "Inc_prices";

        public static string DeleteSale = "DeleteSale";
        public static string CheckSales = "CheckSales";
        public static string GetPercent ="GetPercent";

        public static string DecBQuantity = "DecBQuantity";
        public static string DecPQuantity = "DecPQuantity";

        public static string IncPQuantity = "IncPQuantity";
        public static string IncBQuantity = "IncBQuantity";


        public static string AssignEmployee = "assign_employee";
        public static string AssignPrinting = "assign_printing";

        public static string UpdateProduct = "update_product";
        public static string UpdateBook = "update_book";
        public static string GetSname = "get_storename";
        public static string AddEmployee = "insert_employee";
        public static string GetEmployees = "get_employees";
        public static string GetSC ="getsc";
        public static string GetCID="getCid";
        public static string GetCost="getCost";
        public static string DeleteSC="deletesc";
        public static string AddOrder = "addorder";
        public static string GetCUOrders = "getOrders";
        public static string GetCUOrders2 = "getcuOrders";
        public static string UpdateState = "update_state";
        public static string AddPay="addpayment";
        public static string GetPay = "getpayment";
        public static string DeleteEmp = "delete_emp";
        public static string DeleteFsc = "Deletefromsc";
       
        
       
        public static string UpdateMethod = "UpdateMethod";
        
        
        ///////////////////

       
        public static string UpdateEmployeePassword = "Update_EmployeePassword";
   
     

       
      ///// mostafa
        public static string GetDnames = "GetDnames";
        public static string GetEmpOrders = "GetEmpOrders";
        public static string DeleteTheseOrders = "DeleteTheseOrders";



        /////////////// AHMED IBRAHIM
        //INSERT CUSTOMER

        public static string InsertCustomer = "insert_customer";
        public static string InsertShopping = "insert_shopping";
        public static string UpdateEmail = "Update_email";
        public static string UpdateCard = "Update_card";
        public static string UpdateAge = "Update_age";
        public static string UpdateCustomerPassword = "Update_CustomerPassword";
        public static string CountCustomer = "count_customer";
        public static string GetCuPoints = "GetCuPoints";
        public static string DecCuPoints = "DecCuPoints";
        public static string IncCuPoints = "IncCuPoints";


        //BOOOK
        public static string GetBookByName = "GetBookByStoreName";
        public static string GetBooks = "GetBooks";
        public static string AddBookToSc = "InsertBookInSC";
        public static string GetIDByName = "GetCustByName";
        public static string InsertPrintingto = "insert_printing";
        public static string GetBookByBName = "GetBookByName";
        public static string GetBookByNameAndStore = "GetBookByNameAndStore";
        public static string CheckName = "GetCheckCount";

        //Product
        public static string GetProductByStoreName = "GetProductByStoreNameAndDepartment";
        public static string GetProducts = "GetProducts";
        public static string AddProductToSc = "InsertProductInSC";
        public static string GetProductsByDepartment = "GetProductsByDepartment";
        public static string GetProductByName = "GetProductByNameandDepartment";
        public static string GetProductByNameAndStore = "GetProductByNameAndStoreAndDepartment";
        //Update Customer

        public static string UpdateE = "Update_E";
        public static string UpdatePhone = "Update_Phone";
        public static string UpdateAdress = "Update_Adress";
        public static string UpdateCr = "Update_Cr";



    }
}
