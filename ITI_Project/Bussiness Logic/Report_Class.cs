using ITI_Project.HelpClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI_Project.Bussiness_Logic
{

    class Report_Class
    {

        Project_DBEntities context;

        public Report_Class()
        {
          context  = new Project_DBEntities( );
        }

        public DataTable LisSelectCompanyInfo()
        {
            return ToDataTable.LINQResultToDataTable(from Com in context.Company_Info_Table
                                            select Com);
        }
        public DataTable SelectAllProduct()
        {

            return ToDataTable.LINQResultToDataTable(
                                          from Produ in context.Product_Table
                                          join Catag in context.Category_Table on Produ.Catagory_ID equals Catag.Catagory_ID
                                          join Unite in context.Unite_Table on Produ.Unite_ID equals Unite.Unite_ID
                                          select new { Produ.Product_Name, Produ.BareCode, Produ.Category_Table.Catagory_Name, Produ.Unite_Table.Unite_Name, Produ.Product_Size });
        }
        public DataTable SelectAllProductQunatity()
        {
           
            return ToDataTable.LINQResultToDataTable(from Stok in context.Stock_Quantity_Table
                                                     join Produ in context.Product_Table
                                                     on Stok.Product_ID equals Produ.Product_ID
                                                     where Stok.Quantity <= Produ.AlarmQuantity

                                                     select new { Stok.Quantity, Produ.AlarmQuantity, Produ.Product_Name, Produ.Category_Table.Catagory_Name });
        }

        public DataTable SelectAllPayments( string Date,string Date2)
        {
            DateTime D1 = DateTime.Parse(Date);
            DateTime D2 = DateTime.Parse(Date2);

            return ToDataTable.LINQResultToDataTable(from Payment in context.Pay_Rev_Table
                                                     join PayType in context.Pay_Rev_Type_Table
                                                     on Payment.Pay_Rev_Type_ID equals PayType.Pay_Rev_Type_ID
                                                     where Payment.Pay_Rev_Date >= D1 && Payment.Pay_Rev_Date <= D2 && Payment.Flag=="مصروفات"
                                                     select new { Payment.Pay_Rev_Amount, Payment.Pay_Rev_Date, Payment.Pay_Rev_Description, Payment.Pay_Rev_Type_Table.Pay_Rev_Type_Name });
        }

        public DataTable SelectAllRev(string Date, string Date2)
        {
            DateTime D1 = DateTime.Parse(Date);
            DateTime D2 = DateTime.Parse(Date2);

            return ToDataTable.LINQResultToDataTable(from Payment in context.Pay_Rev_Table
                                                     join PayType in context.Pay_Rev_Type_Table
                                                     on Payment.Pay_Rev_Type_ID equals PayType.Pay_Rev_Type_ID
                                                     where Payment.Pay_Rev_Date >= D1 && Payment.Pay_Rev_Date <= D2 && Payment.Flag == "ايرادات"
                                                     select new { Payment.Pay_Rev_Amount, Payment.Pay_Rev_Date, Payment.Pay_Rev_Description, Payment.Pay_Rev_Type_Table.Pay_Rev_Type_Name });
        }

        public DataTable WillExpire(int  Dayes)
        {
            DateTime D1 = DateTime.Now;
            D1.AddDays(Dayes);
            return ToDataTable.LINQResultToDataTable(from PURQun in context.Stock_Purch_Table
                                                     join produ in context.Product_Table
                                                     on PURQun.Product_ID equals produ.Product_ID
                                                     join Cat in context.Category_Table
                                                     on produ.Catagory_ID equals Cat.Catagory_ID
                                                     join purcdetail in context.Purch_Retern_Details_Table
                                                     on produ.Product_ID equals purcdetail.Product_ID
                                                     join StockQuntity in context.Stock_Quantity_Table
                                                     on produ.Product_ID equals StockQuntity.Product_ID
                                                     where purcdetail.ExpireOrNot == "توجد" && purcdetail.Expire_Date <=D1
                                                     select new {produ.Product_Name,produ.Category_Table.Catagory_Name,StockQuntity.Quantity,purcdetail.Expire_Date});
        }


        public DataTable PurchDeatiles(int Purch_ID)
        {
           
            return ToDataTable.LINQResultToDataTable(from purch in context.Purchases_Details_Table
                                                     join produ in context.Product_Table
                                                     on purch.Product_ID equals produ.Product_ID
                                                     join Cat in context.Category_Table
                                                     on produ.Catagory_ID equals Cat.Catagory_ID
                                                     where purch.Purchases_ID == Purch_ID
                                                     select new { purch.Dealer_Price, purch.Expire_Date, purch.ExpireOrNot, purch.Product_Table.Product_Name, purch.Product_Table.Category_Table.Catagory_Name, purch.Purch_Price, purch.Purch_Total, purch.Quantity, purch .User_Price});
        }

        public DataTable SellectPurch(int Purch_ID)
        {

            return ToDataTable.LINQResultToDataTable(from Purch in context.Purchases_Table
                                                     where Purch.Purchases_ID == Purch_ID
                                                     select new { Purch.Addation_Date, Purch.Notes, Purch.Purch__Pauid, Purch.Purch_Remin, Purch.Purch_Total, Purch.Purchases_ID });
        }

        public DataTable SupplierData(string  SupMobile)
        {
            return ToDataTable.LINQResultToDataTable(from Supp_O in context.Cus_Sup_Table
                                      where Supp_O.Cus_Sup_Mobile == SupMobile && Supp_O.Flag == 1
                                      select Supp_O);

        }

    }
}
