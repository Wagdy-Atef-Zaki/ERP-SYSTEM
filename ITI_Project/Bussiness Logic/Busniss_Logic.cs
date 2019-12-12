using ITI_Project;
using ITI_Project.HelpClass;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItI_Project
{
    class Busniss_Logic
    {
        Project_DBEntities context;
        public Busniss_Logic()
        {
          context  = new Project_DBEntities( );
        }


        /// Ahmed 

        public Safe_Table SelectSafe_Table()
        {
            Safe_Table Obj = (from Com in context.Safe_Table
                                      select Com).FirstOrDefault();
            return Obj;
        }

        public Safe_Table Safe_Table_Update(decimal Value,String Date)
        {
            Safe_Table Obj =(from Com in context.Safe_Table
                              select Com).First();
            if (Obj == null)
            {
                Obj.Safe_Amount = Value;
            }
            else
            {
                Obj.Safe_Amount = Obj.Safe_Amount + Value;
            }

            Obj.Addation_Date = DateTime.Parse( Date);
            context.SaveChanges();

            return Obj;
        }

       
        public bool Pay_Rev_deleteByID(int Pay_Rev_id)
        {
            int x = 0;

            Pay_Rev_Table prod_t_delete = (from pt_del in context.Pay_Rev_Table
                                           where pt_del.Pay_Rev_ID == Pay_Rev_id
                                           select pt_del).FirstOrDefault();
            prod_t_delete.Deleted = 1;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }


        public Company_Info_Table SelectCompanyInfo()
        {
            Company_Info_Table Obj=(from Com in context.Company_Info_Table
                                     select Com).FirstOrDefault();
            return Obj;
        }
        public List< Company_Info_Table >LisSelectCompanyInfo()
        {
            List<Company_Info_Table> Obj = (from Com in context.Company_Info_Table
                                      select Com).ToList();
            return Obj;
        }
        public System_Users_Table SelectUserName( string _UserName )
        {
            System_Users_Table Obj = (from User in context.System_Users_Table
                                      where User.Sys_Username.ToLower() == _UserName
                                      select User).FirstOrDefault();
            return Obj;
        }

        public  List <Category_Table>SelectAllCatag()
        {
            List<Category_Table> LisObj = (from Catag in context.Category_Table
                                           select Catag ).ToList();
            return LisObj;
        }

        public Category_Table SelectCatag( int _cata_ID)
        {
            Category_Table LisObj = (from Catag in context.Category_Table
                                     where Catag.Catagory_ID == _cata_ID
                                           select Catag).FirstOrDefault();
            return LisObj;
        }

        public Unite_Table SelectUniteByID(int  _UniteID)
        {
            Unite_Table Obj = (from Unite in context.Unite_Table
                               where Unite.Unite_ID == _UniteID
                               select Unite).FirstOrDefault();
            return Obj;
        }

        public System_Users_Table SelectUserByID(int _UserID)
        {
            System_Users_Table Obj = (from obj in context.System_Users_Table
                                      where obj.ID == _UserID
                                      select obj).FirstOrDefault();
            return Obj;
        }

        public bool Pay_Rev_Types_Insert (string Pay_Rev_Name, string Pay_Rev_Des,string Falag)
        {
            int x = 0;

            Pay_Rev_Type_Table Pay_Rev_Type_tb_insert = new Pay_Rev_Type_Table { Pay_Rev_Type_Name = Pay_Rev_Name, Pay_Rev_Type_Description = Pay_Rev_Des, Flag = Falag, Deleted = 0, };
            context.Pay_Rev_Type_Table.Add(Pay_Rev_Type_tb_insert);
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool Pay_Rev_Types_Delete(int Pay_Rev_Id)
        {
            int x = 0;

            Pay_Rev_Type_Table Pay_Rev_Types = (from pt_del in context.Pay_Rev_Type_Table
                                                where pt_del.Pay_Rev_Type_ID == Pay_Rev_Id
                                           select pt_del).FirstOrDefault();
            Pay_Rev_Types.Deleted = 1;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public Pay_Rev_Type_Table Pay_Rev_Type_SelectById(int Pay_Rev_Type_ID)
        {

            Pay_Rev_Type_Table Pay_Rev_Type_tb_Obj = (from Obj in context.Pay_Rev_Type_Table
                                                      where Obj.Pay_Rev_Type_ID == Pay_Rev_Type_ID
                                                      select Obj).FirstOrDefault();
            return Pay_Rev_Type_tb_Obj;
        }

        public bool Pay_Rev_Type_Table_updateBarcodeBytID(int Pay_Rev_Type_Id, string Pay_Rev_Name, string Pay_Rev_Des, string Falag)
        {
            int x = 0;

            Pay_Rev_Type_Table Pay_Rev_t_update = (from pt in context.Pay_Rev_Type_Table
                                                   where pt.Pay_Rev_Type_ID == Pay_Rev_Type_Id 
                                           select pt).FirstOrDefault();
            Pay_Rev_t_update.Pay_Rev_Type_Name = Pay_Rev_Name;
            Pay_Rev_t_update.Pay_Rev_Type_Description = Pay_Rev_Des;
            Pay_Rev_t_update.Flag = Falag;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;

        }

        public List<string> Pay_Rev_Dates(String Flag)
        {
            List<string> Pay_Rev_Dates = (from Pay_Rev in context.Pay_Rev_Table
                                                where Pay_Rev.Flag == Flag
                                                select Pay_Rev.Pay_Rev_Date.ToString().Replace("12:00:00 ص", "").Replace("12:00:00 Am", "")).ToList();
            return Pay_Rev_Dates;

        }
        public List<string> Pay_Rev_Ides(String Flag,String Date)
        {
            List<string> Pay_Rev_IDS = (from Pay_Rev in context.Pay_Rev_Table
                                          where Pay_Rev.Flag == Flag && Pay_Rev.Pay_Rev_Date == DateTime.Parse(Date)
                                          select Pay_Rev.Pay_Rev_ID.ToString()).ToList();
            return Pay_Rev_IDS;

        }

        public Pay_Rev_Table Pay_Rev_byid(int ID)
        {
            Pay_Rev_Table Pay_Rev_Obj = (from Pay_Rev in context.Pay_Rev_Table
                                         where Pay_Rev.Pay_Rev_ID == ID
                                        select Pay_Rev).FirstOrDefault();
            return Pay_Rev_Obj;

        }

        public Cus_Sup_Table Customerbyid(int ID)
        {
            Cus_Sup_Table Cus_Obj = (from Cus_Sup in context.Cus_Sup_Table
                                               where Cus_Sup.Cus_Sup_ID == ID && Cus_Sup.Flag==0
                                               select Cus_Sup).FirstOrDefault();
            return Cus_Obj;

        }
        public Cus_Sup_Table Supplierbyid(int ID)
        {
            Cus_Sup_Table Supp_Obj = (from Supp_O in context.Cus_Sup_Table
                                      where Supp_O.Cus_Sup_ID == ID && Supp_O.Flag == 1
                                      select Supp_O).FirstOrDefault();
            return Supp_Obj;

        }


        public Cus_Sup_Table CustomerbyMobile(string Mobile)
        {
            Cus_Sup_Table Cus_Obj = (from Cus_Sup in context.Cus_Sup_Table
                                     where Cus_Sup.Cus_Sup_Mobile == Mobile && Cus_Sup.Flag == 0
                                     select Cus_Sup).FirstOrDefault();
            return Cus_Obj;

        }
        public Cus_Sup_Table SupplierbyMobile(string Mobile)
        {
            Cus_Sup_Table Supp_Obj = (from Supp_O in context.Cus_Sup_Table
                                      where Supp_O.Cus_Sup_Mobile == Mobile && Supp_O.Flag == 1
                                      select Supp_O).FirstOrDefault();
            return Supp_Obj;

        }

        public string SelectLastOrderByMobile( string SupMobile ,decimal Total,decimal Pauid,DateTime Date)
        {

              var Query =(from Purch in context.Purchases_Table
                          where Purch.Cus_Sup_Mobile == SupMobile && Purch.Purch_Total == Total && Purch.Purch__Pauid == Pauid && Purch.Addation_Date == Date
                          orderby Purch.Purchases_ID descending
                          select Purch.Purchases_ID ).Take(1).SingleOrDefault();
              return Query.ToString();
        }

        /// <summary>
        /// productMovement
 
        public List<Order_Details_Table> order_details_Table_searchByProductID(int ProductID)
        {
            List<Order_Details_Table> order_detail_search = (from order_search in context.Order_Details_Table
                                                             where order_search.product_ID == ProductID
                                                             select order_search).ToList();
            return order_detail_search;

        }
        public List<Order_Retern_Details_Table> order_retern_details_Table_searchByProductID(int ProductID)
        {
            List<Order_Retern_Details_Table> order_detail_search = (from order_search in context.Order_Retern_Details_Table
                                                             where order_search.product_ID == ProductID
                                                             select order_search).ToList();
            return order_detail_search;

        }

        public List<Purchases_Details_Table> Purch_details_Table_searchByProductID(int ProductID)
        {
            List<Purchases_Details_Table> order_detail_search = (from order_search in context.Purchases_Details_Table
                                                                    where order_search.Product_ID == ProductID
                                                                    select order_search).ToList();
            return order_detail_search;

        }
        public List<Purch_Retern_Details_Table> Purch_Reterns_details_Table_searchByProductID(int ProductID)
        {
            List<Purch_Retern_Details_Table> order_detail_search = (from order_search in context.Purch_Retern_Details_Table
                                                                 where order_search.Product_ID == ProductID
                                                                 select order_search).ToList();
            return order_detail_search;

        }

        /// ith date
   
        public List<Order_Details_Table> order_details_Table_searchByProductID_Date(int ProductID,string Date1,string Date2)
        {
            List<Order_Details_Table> order_detail_search =(
                from order_Det in context.Order_Details_Table 
                join order in context.Order_Table 
                on order_Det.Order_ID equals order.Order_ID
                where order_Det.product_ID == ProductID && (order.Order_Date >= DateTime.Parse(Date1) && order.Order_Date <= DateTime.Parse(Date2))
                select order_Det).ToList();
            return order_detail_search;

        }
        public List<Order_Retern_Details_Table> order_retern_details_Table_searchByProductID_Date(int ProductID, string Date1, string Date2)
        {
            List<Order_Retern_Details_Table> order_detail_search = (from order_Det in context.Order_Retern_Details_Table
                                                                    join order in context.Order_Retern_Table
                                                                    on order_Det.Order_Retern_ID equals order.Order_Retern_ID
                                                                    where order_Det.product_ID == ProductID && (order.Retern_Date >= DateTime.Parse(Date1) && order.Retern_Date <= DateTime.Parse(Date2))
                                                                    select order_Det).ToList();
            return order_detail_search;

        }

        public List<Purchases_Details_Table> Purch_details_Table_searchByProductID_Date(int ProductID, string Date1, string Date2)
        {
            List<Purchases_Details_Table> order_detail_search = (from order_Det in context.Purchases_Details_Table
                                                                 join order in context.Purchases_Table
                                                                 on order_Det.Purchases_ID equals order.Purchases_ID
                                                                 where order_Det.Product_ID == ProductID && (order.Addation_Date >= DateTime.Parse(Date1) && order.Addation_Date <= DateTime.Parse(Date2))
                                                                 select order_Det).ToList();
            return order_detail_search;

        }
        public List<Purch_Retern_Details_Table> Purch_Reterns_details_Table_searchByProductID_Date(int ProductID, string Date1, string Date2)
        {
            List<Purch_Retern_Details_Table> order_detail_search = (from order_Det in context.Purch_Retern_Details_Table
                                                                    join order in context.Purch_Retern_Table
                                                                    on order_Det.Purch_Retern_ID equals order.Purch_Retern_ID
                                                                    where order_Det.Product_ID == ProductID && (order.Addation_Date >= DateTime.Parse(Date1) && order.Addation_Date <= DateTime.Parse(Date2))
                                                                    select order_Det).ToList();
            return order_detail_search;

        }


        public bool purch_detail_insert(int purch_id, int product_id, string ex_date, string expire_or_not, int qunt, decimal purchprice, decimal userprice, decimal dealerprice, decimal purchtotal)
        {
            int x = 0;

            Purchases_Details_Table purch_detail_insert = new Purchases_Details_Table { Purchases_ID = purch_id, Product_ID = product_id, Expire_Date = ex_date, ExpireOrNot = expire_or_not, Quantity = qunt, Purch_Price = (decimal)purchprice, User_Price = (decimal)userprice, Dealer_Price = (decimal)dealerprice, Purch_Total = (decimal)purchtotal, Deleted = 0 };
            context.Purchases_Details_Table.Add(purch_detail_insert);
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }

        public List<Purchases_Table> SellectPurchZeroByMobile(string SupMobile)
        {

            List<Purchases_Table> ListOb  =(from Purch in context.Purchases_Table
                                            where Purch.Cus_Sup_Mobile == SupMobile && Purch.Purch_Remin==0
                                                     select Purch).ToList();
            return ListOb;
        }
        public List<Purchases_Table> SellectPurchRemingByMobile(string SupMobile)
        {

            List<Purchases_Table> ListOb = (from Purch in context.Purchases_Table
                                            where Purch.Cus_Sup_Mobile == SupMobile && Purch.Purch_Remin *-1 > 0
                                            select Purch).ToList();
            return ListOb;
        }


        ///Wagdy
        // Product_Table functionsinsert & update & delete
        public bool Product_Table_insert(string product_name,string barcode,int catagory_id,int unit_id,string description,int product_exist,string product_image,string alarm_quantity,string product_size,string sproduct_id,string squantity)
        {
            int x=0;
            if (ValidationClass.StringNotEmpty(product_name) && ValidationClass.ISDigit(catagory_id.ToString()))
            {
                Product_Table prod_t_insert = new Product_Table { Product_Name = product_name, BareCode = barcode, Catagory_ID = catagory_id, Unite_ID = unit_id, Description = description, Product_Exist = product_exist, Product_Image = product_image, AlarmQuantity =(ValidationClass.ISDigit(alarm_quantity) == true ? int.Parse(alarm_quantity) : 0), Product_Size = product_size, SProduct_ID = sproduct_id, SQuantity = squantity, Deleted = 0 };
                context.Product_Table.Add(prod_t_insert);
                x = context.SaveChanges();
            }
            if (x==1)
            return true;
            else
            return false;
        }
        public bool Product_Table_updateBarcodeByProductID(int product_id, string barcode)
        {
            int x = 0;

            Product_Table prod_t_update = (from pt in context.Product_Table
                                           where pt.Product_ID == product_id && pt.Deleted == 0
                                           select pt).FirstOrDefault();
            prod_t_update.BareCode = barcode;
           
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;

        }

        public bool Product_Table_updateByProductID(int product_id, string product_name, string barcode, int catagory_id, int unit_id, string description, int product_exist, string product_image, string alarm_quantity, string product_size, string sproduct_id, string squantity)
        {
            int x = 0;

            Product_Table prod_t_update=(from pt in context.Product_Table
                                          where pt.Product_ID==product_id && pt.Deleted ==0
                                           select pt).FirstOrDefault();
            prod_t_update.Product_Name = product_name;
            prod_t_update.BareCode = barcode;
            prod_t_update.Catagory_ID = catagory_id;
            prod_t_update.Unite_ID = unit_id;
            prod_t_update.Description = description;
            prod_t_update.Product_Exist = product_exist;
            prod_t_update.Product_Image = product_image;
            prod_t_update.AlarmQuantity = ValidationClass.ISDigit(alarm_quantity) == true ? int.Parse(alarm_quantity) : 0;
            prod_t_update.Product_Size = product_size;
            prod_t_update.SProduct_ID = sproduct_id;
            prod_t_update.SQuantity = squantity;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
            
        }
        public bool Product_Table_updateByBarcode(string Barcode, string product_name, int catagory_id, int unit_id, string description, int product_exist, string product_image, string alarm_quantity, string product_size, string sproduct_id, string squantity)
        {
            int x = 0;

            Product_Table prod_t_update = (from pt in context.Product_Table
                                           where pt.BareCode == Barcode && pt.Deleted == 0
                                           select pt).FirstOrDefault();
            prod_t_update.Product_Name = product_name;
            prod_t_update.Catagory_ID = catagory_id;
            prod_t_update.Unite_ID = unit_id;
            prod_t_update.Description = description;
            prod_t_update.Product_Exist = product_exist;
            prod_t_update.Product_Image = product_image;
            prod_t_update.AlarmQuantity = ValidationClass.ISDigit(alarm_quantity) == true ? int.Parse(alarm_quantity) : 0;
            prod_t_update.Product_Size = product_size;
            prod_t_update.SProduct_ID = sproduct_id;
            prod_t_update.SQuantity = squantity;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;

        }

        public bool Product_Table_deleteByID(int product_id)
        {
            int x = 0;

            Product_Table prod_t_delete = (from pt_del in context.Product_Table
                                           where pt_del.Product_ID == product_id 
                                           select pt_del).FirstOrDefault();
            prod_t_delete.Deleted = 1;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool Product_Table_deleteByBarcode( string Barcode)
        {
            int x = 0;

            Product_Table prod_t_delete = (from pt_del in context.Product_Table
                                           where pt_del.BareCode == Barcode
                                           select pt_del).FirstOrDefault();
            prod_t_delete.Deleted = 1;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        //end of  Product_Table functionsinsert & update & delete
   

        //1-searching with product ID
        public Product_Table Product_tb_search_by_ID(int product_id)
        {

            Product_Table prod_t_search1 = (from pt_sh1 in context.Product_Table
                                 where pt_sh1.Product_ID == product_id
                                 select pt_sh1).FirstOrDefault();

            return prod_t_search1;
        }
        //2-searching with Barecode
        public Product_Table Product_tb_search_by_Barecode( string Barecode)
        {

            Product_Table prod_t_search2 = (from pt_sh2 in context.Product_Table
                                 where   pt_sh2.BareCode == Barecode
                                 select pt_sh2).FirstOrDefault();

            return prod_t_search2;
        }
       
        //4-searching with product it was deleted
        public List<Product_Table> Product_tb_search_by_product_deleted()
        {
             List<Product_Table> prod_t_search4 = (from pt_sh4 in context.Product_Table
                                 where pt_sh4.Deleted==0
                                 select pt_sh4).ToList();
            return prod_t_search4;
        }
        //5-searching with product it is Existing in data base
        public List<Product_Table> Product_tb_search_by_product_exist()
        {
            List<Product_Table> prod_t_search5 = (from pt_sh5 in context.Product_Table
                                 where pt_sh5.Deleted == 1
                                 select pt_sh5).ToList();
            return prod_t_search5;
           
        }

        //end of searching in product table

        //Order_Details_Table insert ,update,delete
        public bool order_details_Table_insert(int order_id,int product_id, int quantity,double price,double total,double disconet)
        {
            int x = 0;
            Order_Details_Table order_det_tb = new Order_Details_Table { Order_ID = order_id, product_ID = product_id, Quantity = quantity, product_Price = (decimal)price, Total = (decimal)total, Discount = (decimal)disconet, Deleted =1};
            context.Order_Details_Table.Add(order_det_tb);
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool order_details_Table_update(int order_detail_id,int order_id, int product_id, int quantity, double price, double total, double disconet)
        {
            int x = 0;

            Order_Details_Table order_det_update = (from oredr_up in context.Order_Details_Table
                                                    where oredr_up.Order_Details_ID == order_detail_id
                                                    select oredr_up).FirstOrDefault();

           order_det_update.Order_ID = order_id;
            order_det_update.product_ID = product_id;
            order_det_update.Quantity = quantity; 
            order_det_update.product_Price = (decimal)price;
            order_det_update.Total = (decimal)total;
            order_det_update.Discount = (decimal)disconet;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        ///  

        public bool order_details_Table_delete(int _Order_ID)
        {
            int x = 0;

            Order_Details_Table order_det_delete = (from oredr_del in context.Order_Details_Table
                                                    where oredr_del.Order_ID == _Order_ID
                                                    select oredr_del).FirstOrDefault();
            order_det_delete.Deleted = 0;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public List<Order_Details_Table> order_details_Table_search(int order_id)
        {
            List<Order_Details_Table>  order_detail_search =( from order_search in context.Order_Details_Table
                                      where order_search.Order_ID == order_id
                                      select  order_search).ToList();
            return order_detail_search;
         
        }
      
        //end of Order_Details_Table insert ,update,delete, search
        
        //Order_return_Details _Table insert ,update,delete,search
        public bool order_return_return_details_Table_insert(int order_return_id, int product_id, int quantity, double price, double total, double disconet)
        {
            int x = 0;

            Order_Retern_Details_Table order_ret_det_tb = new Order_Retern_Details_Table { Order_Retern_ID = order_return_id, product_ID = product_id, Quantity = quantity, product_Price = (decimal)price, Total = (decimal)total, Discount = (decimal)disconet, Deleted = 0 };
            context.Order_Retern_Details_Table.Add(order_ret_det_tb);
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool order_return_details_Table_update(int order_ret_detail_id, int order_id, int product_id, int quantity, double price, double total, double disconet)
        {
            int x = 0;

            Order_Retern_Details_Table order_det_update = (from oredr_up in context.Order_Retern_Details_Table
                                                           where oredr_up.Order_Retern_Details_ID == order_ret_detail_id
                                                    select oredr_up).FirstOrDefault();

            order_det_update.Order_Retern_ID = order_id;
            order_det_update.product_ID = product_id;
            order_det_update.Quantity = quantity;
            order_det_update.product_Price = (decimal)price;
            order_det_update.Total = (decimal)total;
            order_det_update.Discount = (decimal)disconet;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool order_return_details_Table_delete(int order_ret_detail_id)
        {
            int x = 0;

            Order_Retern_Details_Table order_det_delete = (from oredr_del in context.Order_Retern_Details_Table
                                                           where oredr_del.Order_Retern_Details_ID == order_ret_detail_id
                                                           select oredr_del).FirstOrDefault();
            order_det_delete.Deleted = 0;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool order_return_details_Table_search(int order_return_id)
        {
            int x = 0;

            var order_return_detail_search = from order_search in context.Order_Retern_Details_Table
                                             where order_search.Order_Retern_ID == order_return_id
                                             select order_search.Order_Retern_Details_ID;
            order_return_detail_search.ToList();
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        //end of Order_return_Details_Table insert ,update,delete, search
        
        //category table insert ,update,delete,search
        public bool Category_Table_insert(string catag_name, string categ_description, int catg_exist)
        {
            int x = 0;

            if (ValidationClass.StringNotEmpty(catag_name))
            {
                Category_Table catg_tb_insert = new Category_Table { Catagory_Name = catag_name, Catagory_Description = categ_description, Catagory_Exist = catg_exist, Deleted = 0 };
                context.Category_Table.Add(catg_tb_insert);
                x = context.SaveChanges();
            }
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool Category_Table_update(int catg_id,string catag_name, string categ_description, int catg_exist)
        {
            int x = 0;

            Category_Table catg_tb_update = (from catg_up in context.Category_Table
                                             where catg_up.Catagory_ID == catg_id
                                             select catg_up).FirstOrDefault();
            catg_tb_update.Catagory_Name = catag_name;
            catg_tb_update.Catagory_Description = categ_description;
            catg_tb_update.Catagory_Exist = catg_exist;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool Category_Table_delete(int catg_id)
        {
            int x = 0;

            Category_Table catg_tb_delete = (from catg_del in context.Category_Table
                                             where catg_del.Catagory_ID == catg_id
                                             select catg_del).First();
            catg_tb_delete.Deleted = 1;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool Category_Table_search()
        {
            var catg_search = from catg_sch in context.Category_Table
                              select new { catg_sch.Catagory_ID, catg_sch.Catagory_Name };
            catg_search.ToList();
            return true;
        }
        //end of category table insert ,update,delete,search
       // unite table insert ,update , delete, search
        public bool unite_table_insert(string unite_name,string unite_description)
        {
            int x = 0;

            Unite_Table unite_tb_insert = new Unite_Table { Unite_Name =unite_name,Unite_Description=unite_description,Deleted=0};
            context.Unite_Table.Add(unite_tb_insert);
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool unite_table_update(int unit_id,string unite_name, string unite_description)
        {
            int x = 0;

            Unite_Table unite_tb_update = (from unite_tb_up in context.Unite_Table
                                           where unite_tb_up.Unite_ID == unit_id
                                           select unite_tb_up).FirstOrDefault();
            unite_tb_update.Unite_Name = unite_name;
            unite_tb_update.Unite_Description = unite_description;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool unite_table_delete(int unit_id)
        {
            int x = 0;

            Unite_Table unite_tb_del = (from unite_tb_dl in context.Unite_Table
                                           where unite_tb_dl.Unite_ID == unit_id
                                           select unite_tb_dl).FirstOrDefault();
            unite_tb_del.Deleted = 0;

            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
      
       // unite table insert ,update , delete, search

        //stock purch table insert ,update,delete,search
        public bool Stock_Purch_Table_insert(int purchase_id,int product_id,int quantity,int purchase_accept )
        {
            int x = 0;

            Stock_Purch_Table stock_purch_tb_insert = new Stock_Purch_Table { Purchases_ID = purchase_id, Product_ID = product_id, Quantity = quantity, Purch_Accept_States = purchase_accept ,Deleted=0};
            context.Stock_Purch_Table.Add(stock_purch_tb_insert);
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool Stock_Purch_Table_update(int stock_purch_id,int purchase_id, int product_id, int quantity, int purchase_accept)
        {
            int x = 0;

            Stock_Purch_Table stock_purch_tb_update = (from stock_pur_up in context.Stock_Purch_Table
                                                       where stock_pur_up.Stock_Purch_ID == stock_purch_id
                                                       select stock_pur_up).FirstOrDefault();
            stock_purch_tb_update.Product_ID = product_id;
            stock_purch_tb_update.Purchases_ID=purchase_id;
            stock_purch_tb_update.Quantity=quantity;
            stock_purch_tb_update.Purch_Accept_States = purchase_accept;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool Stock_Purch_Table_delete(int stock_purch_id)
        {
            int x = 0;

            Stock_Purch_Table stock_purch_tb_delete = (from stock_pur_del in context.Stock_Purch_Table
                                                       where stock_pur_del.Stock_Purch_ID == stock_purch_id
                                                       select stock_pur_del).FirstOrDefault();
            stock_purch_tb_delete.Deleted = 0;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool Stock_Purch_Table_search()
        {
            var stock_purch_tb_search = from stock_pur_sch in context.Stock_Purch_Table
                                        select new { stock_pur_sch.Stock_Purch_ID, stock_pur_sch.Product_ID};
            stock_purch_tb_search.ToList();

            return true;
        }
        //end ofstock purch table insert ,update,delete,search
        //stock quantity table insert ,update,delete,search
        public bool Stock_Quantity_Table_insert(int product_id,int quantity)
        {
            int x = 0;

            Stock_Quantity_Table stock_quant_tb_insert = new Stock_Quantity_Table { Product_ID = product_id, Quantity = quantity,Deleted=0 };
            context.Stock_Quantity_Table.Add(stock_quant_tb_insert);
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool Stock_Quantity_Table_update(int stock_qunt_id,int product_id,int quantity)
        {
            int x = 0;

            Stock_Quantity_Table stock_quant_tb_insert = (from stock_q_up in context.Stock_Quantity_Table
                                                          where stock_q_up.Stock_Quantity_ID == stock_qunt_id
                                                          select stock_q_up).FirstOrDefault();
            stock_quant_tb_insert.Product_ID=product_id;
            stock_quant_tb_insert.Quantity = quantity;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool Stock_Quantity_Table_delete(int stock_qunt_id)
        {
            int x = 0;

            Stock_Quantity_Table stock_quant_tb_delete= (from stock_q_del in context.Stock_Quantity_Table
                                                          where stock_q_del.Stock_Quantity_ID == stock_qunt_id
                                                          select stock_q_del).FirstOrDefault();
            stock_quant_tb_delete.Deleted = 0;

            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool Stock_Quantity_Table_search()
        {
            int x = 0;

            var stock_quant_tb_search = from stock_q_sch in context.Stock_Quantity_Table
                                        select new { stock_q_sch.Stock_Quantity_ID, stock_q_sch.Product_ID };
            stock_quant_tb_search.ToList();

            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        //end ofstock quantity table insert ,update,delete,search

        //Purchases_Details_Table insert ,update,delete,search
        public bool Purchases_Details_Table_insert(int purch_id,int product_id,string ex_date,string expire_or_not,int qunt,double purchprice,double userprice,double dealerprice,double purchtotal )
        {
            int x = 0;

            Purchases_Details_Table purch_det_tb_insert = new Purchases_Details_Table { Purchases_ID = purch_id, Product_ID = product_id, Expire_Date = ex_date, ExpireOrNot = expire_or_not, Quantity = qunt, Purch_Price = (decimal)purchprice, User_Price = (decimal)userprice, Dealer_Price = (decimal)dealerprice, Purch_Total = (decimal)purchtotal,Deleted=0 };
            context.Purchases_Details_Table.Add(purch_det_tb_insert);
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool Purchases_Details_Table_update(int purch_detail_id, int purch_id, int product_id, string ex_date, string expire_or_not, int qunt, double purchprice, double userprice, double dealerprice, double purchtotal)
        {
            int x = 0;

            Purchases_Details_Table purch_det_tb_update = (from purch_up in context.Purchases_Details_Table
                                                           where purch_up.Purchases_Details_ID == purch_detail_id
                                                           select purch_up).FirstOrDefault();
            purch_det_tb_update. Purchases_ID = purch_id;
             purch_det_tb_update.Product_ID = product_id;
             purch_det_tb_update.Expire_Date = ex_date;
             purch_det_tb_update.ExpireOrNot = expire_or_not;
             purch_det_tb_update.Quantity = qunt;
             purch_det_tb_update.Purch_Price = (decimal)purchprice;
             purch_det_tb_update.User_Price = (decimal)userprice;
             purch_det_tb_update.Dealer_Price = (decimal)dealerprice;
             purch_det_tb_update.Purch_Total = (decimal)purchtotal;
             x = context.SaveChanges();
             if (x == 1)
                 return true;
             else
                 return false;
        }
        public bool Purchases_Details_Table_delete(int purch_detail_id)
        {
            int x = 0;

            Purchases_Details_Table purch_det_tb_delete = (from purch_del in context.Purchases_Details_Table
                                                           where purch_del.Purchases_Details_ID == purch_detail_id
                                                           select purch_del).FirstOrDefault();
            purch_det_tb_delete.Deleted = 0;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        //end of Purchases_Details_Table insert ,update,delete,search
        // Purchases_return_Details_Table insert ,update,delete,search
        public bool purch_ret_detail_insert(int purch_ret_id, int product_id, DateTime ex_date, string expire_or_not, int qunt, double purchprice, double userprice, double dealerprice, double purchtotal)
        {
            int x = 0;

            Purch_Retern_Details_Table purch_ret_detail_insert = new Purch_Retern_Details_Table { Purch_Retern_ID = purch_ret_id, Product_ID = product_id, Expire_Date = ex_date, ExpireOrNot = expire_or_not, Quantity = qunt, Purch_Price = (decimal)purchprice, User_Price = (decimal)userprice, Dealer_Price = (decimal)dealerprice, Purch_Total = (decimal)purchtotal, Deleted = 0 };
            context.Purch_Retern_Details_Table.Add(purch_ret_detail_insert);
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool purch_ret_detail_update(int purch_ret_detail_id, int purch_ret_id, int product_id, DateTime ex_date, string expire_or_not, int qunt, double purchprice, double userprice, double dealerprice, double purchtotal)
        {
            int x = 0;

            Purch_Retern_Details_Table purch_ret_detail_update = (from purch_up in context.Purch_Retern_Details_Table
                                                                  where purch_up.Purch_Retern_Details_ID == purch_ret_detail_id
                                                                  select purch_up).FirstOrDefault();
            purch_ret_detail_update.Purch_Retern_ID = purch_ret_id;
            purch_ret_detail_update.Product_ID = product_id;
            purch_ret_detail_update.Expire_Date = ex_date;
            purch_ret_detail_update.ExpireOrNot = expire_or_not;
            purch_ret_detail_update.Quantity = qunt;
            purch_ret_detail_update.Purch_Price = (decimal)purchprice;
            purch_ret_detail_update.User_Price = (decimal)userprice;
            purch_ret_detail_update.Dealer_Price = (decimal)dealerprice;
            purch_ret_detail_update.Purch_Total = (decimal)purchtotal;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool purch_ret_detail_delete(int purch_ret_detail_id)
        {
            int x = 0;

            Purch_Retern_Details_Table purch_ret_detail_delete = (from purch_del in context.Purch_Retern_Details_Table
                                                                  where purch_del.Purch_Retern_Details_ID == purch_ret_detail_id
                                                                  select purch_del).FirstOrDefault();
            purch_ret_detail_delete.Deleted = 0;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        //end of Purchases_return_Details_Table insert ,update,delete,search
        // Purchases_return_Table insert ,update,delete,search
        public bool Purch_Retern_Table_insert(DateTime addtion_date,string cus_mobile,double ret_total,double ret_pauid,double ret_remin,string notes,int user_id)
        {
            int x = 0;

            Purch_Retern_Table purch__ret_insert = new Purch_Retern_Table { Addation_Date = addtion_date, Cus_Sup_Mobile = cus_mobile, Purch_Retern_Total = (decimal)ret_total, Purch_Retern_Pauid = (decimal)ret_pauid, Purch_Retern_Remin = (decimal)ret_remin, Notes = notes, UserID = user_id, Deleted=1 };
            context.Purch_Retern_Table.Add(purch__ret_insert);
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool Purch_Retern_Table_update(int purch_ret_id,DateTime addtion_date, string cus_mobile, double ret_total, double ret_pauid, double ret_remin, string notes, int user_id)
        {
            int x = 0;

            Purch_Retern_Table purch__ret_update = (from purch_up in context.Purch_Retern_Table
                                                    where purch_up.Purch_Retern_ID == purch_ret_id
                                                    select purch_up).FirstOrDefault();
            purch__ret_update.Addation_Date = addtion_date;
            purch__ret_update.Cus_Sup_Mobile = cus_mobile;
            purch__ret_update.Purch_Retern_Total = (decimal)ret_total;
            purch__ret_update.Purch_Retern_Pauid = (decimal)ret_pauid;
            purch__ret_update.Purch_Retern_Remin = (decimal)ret_remin;
            purch__ret_update.Notes = notes;
            purch__ret_update.UserID = user_id;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool Purch_Retern_Table_delete(int purch_ret_id)
        {
            int x = 0;

            Purch_Retern_Table purch__ret_delete = (from purch_del in context.Purch_Retern_Table
                                                    where purch_del.Purch_Retern_ID == purch_ret_id
                                                    select purch_del).FirstOrDefault();
            purch__ret_delete.Deleted = 0;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        //end of Purchases_return_Table insert ,update,delete,search
        // Purchases_Table insert ,update,delete,search
        public bool Purch_Table_insert(DateTime addtion_date, string cus_mobile, double ret_total, double ret_pauid, double ret_remin, string notes, int user_id)
        {
            int x = 0;

            Purchases_Table purch_insert = new Purchases_Table { Addation_Date = addtion_date, Cus_Sup_Mobile = cus_mobile, Purch_Total = (decimal)ret_total, Purch__Pauid = (decimal)ret_pauid, Purch_Remin = (decimal)ret_remin, Notes = notes, UserID = user_id, Deleted = 0 };
            context.Purchases_Table.Add(purch_insert);
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool Purch_Table_update(int purch_id, DateTime addtion_date, string cus_mobile, double ret_total, double ret_pauid, double ret_remin, string notes, int user_id)
        {
            int x = 0;

            Purchases_Table purch_update = (from purch_up in context.Purchases_Table
                                               where purch_up.Purchases_ID == purch_id
                                                    select purch_up).FirstOrDefault();
            purch_update.Addation_Date = addtion_date;
            purch_update.Cus_Sup_Mobile = cus_mobile;
            purch_update.Purch_Total = (decimal)ret_total;
            purch_update.Purch__Pauid = (decimal)ret_pauid;
            purch_update.Purch_Remin = (decimal)ret_remin;
            purch_update.Notes = notes;
            purch_update.UserID = user_id;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool Purch_Table_delete(int purch_id)
        {
            int x = 0;

            Purchases_Table purch_delete = (from purch_up in context.Purchases_Table
                                               where purch_up.Purchases_ID == purch_id
                                                    select purch_up).FirstOrDefault();
            purch_delete.Deleted = 0;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        //end of Purchases_Table insert ,update,delete,search
        //safe_Table insert ,update,delete,search
        public bool safe_insert(DateTime addition_date, double money)
        {
            int x = 0;

            Safe_Table safe_insert = new Safe_Table { Safe_Amount = (decimal)money, Addation_Date = addition_date, Deleted = 0 };
            context.Safe_Table.Add(safe_insert);
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool safe_update( DateTime addition_date, double money)
        {
            int x = 0;

            Safe_Table safe_update = (from safe_up in context.Safe_Table
                                      select safe_up).FirstOrDefault();
           safe_update.Safe_Amount = (decimal)money;
           safe_update.Addation_Date = addition_date;
           x = context.SaveChanges();
           if (x == 1)
               return true;
           else
               return false;

        }
        public bool safe_delete(int id)
        {
            int x = 0;

            Safe_Table safe_delete = (from safe_del in context.Safe_Table
                                      where safe_del.Safe_ID == id
                                      select safe_del).FirstOrDefault();
            safe_delete.Deleted = 0;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        //end of safe_Table insert ,update,delete,search
        //system user insert update delete
        public bool system_user_insert(string username ,string pass,string permesion,string ImagePath)
        {
            int x = 0;

            System_Users_Table sys_insert = new System_Users_Table { Sys_Username = username, Sys_Pass = pass, Sys_User_Permission = permesion, Sys_User_Imagr_Path = ImagePath, Deleted = 0 };
            context.System_Users_Table.Add(sys_insert);
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
        }
        public bool system_user_update(int id, string username, string pass, string permesion, string ImagePath)
        {
            int x = 0;

            System_Users_Table sys_update = (from sys_up in context.System_Users_Table
                                             where sys_up.ID == id
                                             select sys_up).FirstOrDefault();
            sys_update.Sys_Username=username;
            sys_update.Sys_Pass=pass;
            sys_update.Sys_User_Permission = permesion;
            sys_update.Sys_User_Imagr_Path = ImagePath;
            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;
                
        }
        public bool system_user_delete(int id)
        {
            int x = 0;

            System_Users_Table sys_delete = (from sys_del in context.System_Users_Table
                                             where sys_del.ID == id
                                             select sys_del).FirstOrDefault();
            sys_delete.Deleted = 1;

            x = context.SaveChanges();
            if (x == 1)
                return true;
            else
                return false;

        }
        //end of system user insert update delete
       



      /// Reda 

        // insert into table information about company
        public bool UPDATE_info_company(string c_name, string c_categ, string c_adress, string c_manager, string c_phone1, string c_phone2, string c_phone3, string c_logo)
        {

            Company_Info_Table c_i_t =
                               (from company in context.Company_Info_Table
                                select company).FirstOrDefault();
               c_i_t.Company_Name = c_name;
               c_i_t.Company_Catagory = c_categ;
               c_i_t. Company_Address = c_adress;
               c_i_t .Company_Manager = c_manager;
               c_i_t. Company_Phone1 = c_phone1;
               c_i_t. Company_Phone2 = c_phone2;
               c_i_t.  Company_Phone3 = c_phone3;
               c_i_t.Company_Logo = c_logo;
           
            int msg = context.SaveChanges();
            return msg == 1 ? true : false;
        }
        public bool UPDATE_MediaPath( String MediaPath)
        {

            Company_Info_Table c_i_t =
                               (from company in context.Company_Info_Table
                                select company).FirstOrDefault();

            c_i_t.MediaPath = MediaPath;

            int msg = context.SaveChanges();
            return msg == 1 ? true : false;
        }

        // insert into table Cus_Sup_Table information about customer or supplier 
        public bool insert_into_Cus_Sup_Table(string c_s_mobile, string c_s_name, string c_s_company, string c_s_email, string c_s_notes, decimal c_s_account, int flag)
        {
            Cus_Sup_Table c_s_t = new Cus_Sup_Table()
            {
                Cus_Sup_Mobile = c_s_mobile,
                Cus_Sup_Name = c_s_name,
                Cus_Sup_Company = c_s_company,
                Cus_Sup_Email = c_s_email,
                Cus_Sup_Notes = c_s_notes,
                Cus_Sup_Account = c_s_account,
                Flag = flag,
                Deleted = 0
            };
            context.Cus_Sup_Table.Add(c_s_t);
            int msg = context.SaveChanges();
            return msg == 1 ? true : false;

        }

        // insert into table order information about order
        public bool insert_into_order_table(string ord_pay_meth, string client_or_not, DateTime order_date, string cus_sup_mob, decimal order_total, decimal order_puaid, decimal order_reming, string order_note, int user_id)
        {
            Order_Table order_tab = new Order_Table()
            {
                Order_Payment_Method = ord_pay_meth,
                Client_or_Not = client_or_not,
                Order_Date = order_date,
                Cus_Sup_Mobile = cus_sup_mob,
                Order_Total = order_total,
                Order_Pauid = order_puaid,
                Order_Reming = order_reming,
                Order_Notes = order_note,
                UserID = user_id,
                Deleted = 0
            };
            context.Order_Table.Add(order_tab);
            int msg = context.SaveChanges();
            return msg == 1 ? true : false;

        }


        // insert into table order return details more information about return order
        public bool insert_into_order_return_details_table(int order_return_id, int product_id, int quantity, decimal product_price, decimal total, decimal discount)
        {
            Order_Retern_Details_Table order_return_detail = new Order_Retern_Details_Table()
            {
                Order_Retern_ID = order_return_id,
                product_ID = product_id,
                Quantity = quantity,
                product_Price = product_price,
                Total = total,
                Discount = discount,
                Deleted = 0
            };
            context.Order_Retern_Details_Table.Add(order_return_detail);
            int msg = context.SaveChanges();
            return msg == 1 ? true : false;
        }


        // insert into table pay rev table 
        public bool insert_into_pay_rev_table(decimal pay_rev_ammount, string pay_rev_date, string pay_rev_desc, int pay_rev_type_id, int user_id, string flag)
        {
            Pay_Rev_Table p_r_t = new Pay_Rev_Table()
            {
                Pay_Rev_Amount = pay_rev_ammount,
                Pay_Rev_Date = DateTime.Parse( pay_rev_date),
                Pay_Rev_Description = pay_rev_desc,
                Pay_Rev_Type_ID = pay_rev_type_id,
                UserID = user_id,
                Flag = flag,
                Deleted = 0
            };
            context.Pay_Rev_Table.Add(p_r_t);
            int msg = context.SaveChanges();
            return msg == 1 ? true : false;
        }


        // update

        // update table company information
        public bool update_company_info_table(int company_id, string company_name, string category, string address, string manager, string p1, string p2, string p3, string logo)
        {
            var query_comp_info =
                               (from company in context.Company_Info_Table
                                where company.Compans_ID == company_id
                                select company).FirstOrDefault();
            query_comp_info.Company_Name = company_name;
            query_comp_info.Company_Catagory = category;
            query_comp_info.Company_Address = address;
            query_comp_info.Company_Manager = manager;
            query_comp_info.Company_Phone1 = p1;
            query_comp_info.Company_Phone2 = p2;
            query_comp_info.Company_Phone3 = p3;
            query_comp_info.Company_Logo = logo;
            int msg = context.SaveChanges();
            return msg == 1 ? true : false;

        }


        //update table cust_sup_table
        public bool update_cust_sub_table(int cust_sup_id, string c_s_mobile, string c_s_name, string c_s_company, string c_s_email, string c_s_notes, int flag)
        {
            var query_cust_sup =
                              (from c_or_sup in context.Cus_Sup_Table
                               where c_or_sup.Cus_Sup_ID == cust_sup_id && c_or_sup.Flag==flag
                               select c_or_sup).FirstOrDefault();
            query_cust_sup.Cus_Sup_Mobile = c_s_mobile;
            query_cust_sup.Cus_Sup_Name = c_s_name;
            query_cust_sup.Cus_Sup_Company = c_s_company;
            query_cust_sup.Cus_Sup_Email = c_s_email;
            query_cust_sup.Cus_Sup_Notes = c_s_notes;
            query_cust_sup.Flag = flag;
            int msg = context.SaveChanges();
            return msg > 0 ? true : false;
        }


        // update table order table
        public bool update_order_table(int order_id, string ord_pay_meth, string client_or_not, DateTime order_date, string cus_sup_mob, decimal order_total, decimal order_puaid, decimal order_reming, string order_note, int user_id)
        {
            var query_order =
                           (from o in context.Order_Table
                            where o.Order_ID == order_id
                            select o).FirstOrDefault();
            query_order.Order_Payment_Method = ord_pay_meth;
            query_order.Client_or_Not = client_or_not;
            query_order.Order_Date = order_date;
            query_order.Cus_Sup_Mobile = cus_sup_mob;
            query_order.Order_Total = order_total;
            query_order.Order_Pauid = order_puaid;
            query_order.Order_Reming = order_reming;
            query_order.Order_Notes = order_note;
            query_order.UserID = user_id;
            int msg = context.SaveChanges();
            return msg == 1 ? true : false;

        }

        // update table order return details
        public bool update_order_return_detail_table(int order_return_detail_id, int order_return_id, int product_id, int quantity, decimal product_price, decimal total, decimal discount)
        {
            var query_order_ret_detail =
                                      (from order_ret_detail in context.Order_Retern_Details_Table
                                       where order_ret_detail.Order_Retern_ID == order_return_detail_id
                                       select order_ret_detail).FirstOrDefault();
            query_order_ret_detail.Order_Retern_ID = order_return_id;
            query_order_ret_detail.product_ID = product_id;
            query_order_ret_detail.Quantity = quantity;
            query_order_ret_detail.product_Price = product_price;
            query_order_ret_detail.Total = total;
            query_order_ret_detail.Discount = discount;
            int msg = context.SaveChanges();
            return msg == 1 ? true : false;
        }


        // update table pay_prev 
        public bool update_pay_rev(int pay_rev_id, decimal pay_rev_ammount, DateTime pay_rev_date, string pay_rev_desc, int pay_rev_type_id, int user_id, string flag)
        {
            var query_pay_rev =
                             (from pay_rev in context.Pay_Rev_Table
                              where pay_rev.Pay_Rev_ID == pay_rev_id
                              select pay_rev).FirstOrDefault();
            query_pay_rev.Pay_Rev_Amount = pay_rev_ammount;
            query_pay_rev.Pay_Rev_Date = pay_rev_date;
            query_pay_rev.Pay_Rev_Description = pay_rev_desc;
            query_pay_rev.Pay_Rev_Type_ID = pay_rev_type_id;
            query_pay_rev.UserID = user_id;
            query_pay_rev.Flag = flag;
            int msg = context.SaveChanges();
            return msg == 1 ? true : false;
        }



        //Delete

        // delete from customer or suplier table
        public bool Delete_from_cust_sup_table(int cust_sup_id ,int _flag)
        {
            var query_dele_cust_sup =
                                  (from cust_sup in context.Cus_Sup_Table
                                   where cust_sup.Cus_Sup_ID == cust_sup_id && cust_sup.Flag == _flag 
                                   select cust_sup).FirstOrDefault();
            query_dele_cust_sup.Deleted = 1;
            int msg = context.SaveChanges();
            return msg == 1 ? true : false;
        }

        // delete from order table
        public bool Delete_from_order_table(int order_id)
        {
            var query_order =
                           (from order in context.Order_Table
                            where order.Order_ID == order_id
                            select order).FirstOrDefault();
            query_order.Deleted = 1;
            int msg = context.SaveChanges();
            return msg == 1 ? true : false;
        }


        // delete from order return detail
        public bool Delete_from_order_return_detail(int order_return_detail_id)
        {
            var query_del_order_return_detail =
                                              (from order_return_detail in context.Order_Retern_Details_Table
                                               where order_return_detail.Order_Retern_Details_ID == order_return_detail_id
                                               select order_return_detail).FirstOrDefault();
            query_del_order_return_detail.Deleted = 1;
            int msg = context.SaveChanges();
            return msg == 1 ? true : false;

        }

        // delete from pay_rev table
        public bool Delete_from_pay_rev(int pay_rev_id)
        {
            var query_pay_rev =
                             (from pay_rev in context.Pay_Rev_Table
                              where pay_rev.Pay_Rev_ID == pay_rev_id
                              select pay_rev).FirstOrDefault();
            query_pay_rev.Deleted = 1;
            int msg = context.SaveChanges();
            return msg == 1 ? true : false;
        }




    }
}
