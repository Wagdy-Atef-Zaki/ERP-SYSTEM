using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.IO;
using DevExpress.XtraBars.Helpers;
using DevExpress.LookAndFeel;
using System.Configuration;
using ItI_Project.HelpClass;
using DevExpress.Skins;
using ITI_Project.Forms.Company;
using ITI_Project.Forms.Customer;
using ITI_Project.Forms.Money;
using ITI_Project.Forms.Orders;
using ITI_Project.Forms.Product;
using ITI_Project.Forms.Purch;
using ITI_Project.Forms.Settings;
using ITI_Project.Forms.Supplier;
using ITI_Project;
using ITI_Project.Bussiness_Logic;

namespace ItI_Project
{
    public partial class Home : DevExpress.XtraEditors.XtraForm
    {

        
        Bitmap B;
        string userImage = "";
        private Timer t = new Timer();
        Report_Class Report_Obj;
       
        private bool itemhide=false;
        private AboutUs AboutUs;
        private CompanyInfo CompanyInfo;
        private ExpireDateAlert ExpireDateAlert;
        private MediaPath MediaPath;
        private StoreToZero StoreToZero;
        private CustomerAccountView CustomerAccountView;
        private CustomerAdd CustomerAdd;
        private CustomerUp CustomerUp;
        private CustomerZaeroPay CustomerZaeroPay;
        private CustumersPaymentsView CustumersPaymentsView;
        private PayBackOrderAdd PayBackOrderAdd;
        private PayBackOrderUp PayBackOrderUp;
        private PayBackPuchAdd PayBackPuchAdd;
        private PayBackPurchUp PayBackPurchUp;
        private PayBackReternAdd PayBackReternAdd;
        private PayBackReterUp PayBackReterUp;
        private PayRevAdd PayRevAdd;
        private PayRevTypesAdd PayRevTypesAdd;
        private PayRevTypesUp PayRevTypesUp;
        private PayRevUp PayRevUp;
        private SafeUp SafeUp;
        private OrderAdd OrderAdd;
        private OrderPriceAdd OrderPriceAdd;
        private OrderPriceView OrderPriceView;
        private StoreQuantity StoreQuantity;
        private TotalProductOrder TotalProductOrder;
        private BarcodeGenerator BarcodeGenerator;
        private CatagoryAdd CatagoryAdd;
        private CatagoryUp CatagoryUp;
        private ProductAdd ProductAdd;
        private ProductMovement ProductMovement;
        private ProductUp ProductUp;
        private UniteAdd UniteAdd;
        private UniteUp UniteUp;
        private AcceptPurch AcceptPurch;
        private PucheDele PucheDele;
        private PurchesAdd PurchesAdd;
        private TotalPurch TotalOrderPurch;
        private BackupAndRestore BackupAndRestore;
        private ConncetionSettings ConncetionSettings;
        private SystemUserAdd SystemUserAdd;
        private SystemUserUp SystemUserUp;
        private SupplierAccountView SupplierAccountView;
        private SupplierAdd SupplierAdd;
        private SuppliersAccountsView SuppliersAccountsView;
        private SupplierUp SupplierUp;
        private SupplierZeroPoints SupplierZeroPoints;
        private ALlProductInSystem ALlProductInSystem;
        private ProductQuantityAlert ProductQuantityAlert;
        private ProductWillExpire ProductWillExpire;
        private RevPay_Rep RevPay_Rep;
     
        string UserName, Permision, skinName;
        public Home()
        {
            InitializeComponent();
            Report_Obj = new Report_Class();
        }

        public Home(string Permision, string UserName, string userImage,string _skinName)
        {
              InitializeComponent();

              this.UserName = UserName;
              this.Permision = Permision;
              LaUserName.Text = UserName;
              this.userImage = userImage;
              skinName = _skinName;

        }

        private void t_Tick(object sender, EventArgs e)
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;


            if (hh > 12)
            {
                hh = hh - 12;
                label5.Text = "م";
            }
            else
            {
                label5.Text =  "ص";

            }
            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

           label1.Text = time;
        }


        public void changeColor(string SkinName)
        {

            if (SkinName.Contains("Dark") || SkinName.Contains("dark"))
            {
                label1.ForeColor = Color.White;
                label2.ForeColor = Color.White;
                label4.ForeColor = Color.White;
                label5.ForeColor = Color.White;
                btnProduct.ForeColor = Color.White;
                btnPurch.ForeColor = Color.White;
                btnCustomer.ForeColor = Color.White;
                btnMoney.ForeColor = Color.White;
                btnReport.ForeColor = Color.White;
                btnSettings.ForeColor = Color.White;
                btnCompany.ForeColor = Color.White;
                btnSupplier.ForeColor = Color.White;
                btnAbout.ForeColor = Color.White;
                btnOrder.ForeColor = Color.White;
                LaUserName.ForeColor = Color.White;
                btnReterns.ForeColor = Color.White;
            }
            else
            {
                label1.ForeColor = Color.Black;
                label2.ForeColor = Color.Black;
                label4.ForeColor = Color.Black;
                label5.ForeColor = Color.Black;
                btnProduct.ForeColor = Color.Black;
                btnPurch.ForeColor = Color.Black;
                btnCustomer.ForeColor = Color.Black;
                btnMoney.ForeColor = Color.Black;
                btnReport.ForeColor = Color.Black;
                btnSettings.ForeColor = Color.Black;
                btnCompany.ForeColor = Color.Black;
                btnSupplier.ForeColor = Color.Black;
                btnAbout.ForeColor = Color.Black;
                btnOrder.ForeColor = Color.Black;
                LaUserName.ForeColor = Color.Black;
                btnReterns.ForeColor = Color.Black;

            }

        }
    
        private void Home_Load(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(userImage) && userImage!=null)
            {
                if (File.Exists(userImage))
                {
                    B = new Bitmap(userImage);
                    UserPic.Image = B;
                }
                else
                {
                    UserPic.Image = ITI_Project.Properties.Resources.user1;
                }
            }
            else
            {
                UserPic.Image = ITI_Project.Properties.Resources.user1;
            }

            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var filePath = roamingDirectory + "\\HosWallPaper.txt";
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            if (File.Exists(filePath))
            {

                this.BackgroundImage = Image.FromFile(File.ReadAllText(filePath));
            }
            else
            {
             
              //  this.BackgroundImage = new Bitmap(ITI_Project.Properties.Resources.Hos);

            }
            label2.Text = DateTime.Now.Day.ToString() + " / " + DateTime.Now.Month.ToString() + " / " + DateTime.Now.Year.ToString();
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);
            t.Start();
            panelControl1.AutoScroll = true;
            panelControl3.AutoScroll = true;



            DataTable Obj = Report_Obj.SelectAllProductQunatity();
            if (Obj.Rows.Count>0)
            {
                if (ProductQuantityAlert == null || ProductQuantityAlert.IsDisposed == true)
                {
                    ProductQuantityAlert = new ProductQuantityAlert();
                } ProductQuantityAlert.MdiParent = this;
                ProductQuantityAlert.Show();
                ProductQuantityAlert.Select();
            }

            var Path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var FPath = roamingDirectory + "\\ProductExpireSetting.txt";

            if (File.Exists(FPath))
            {
                if (!string.IsNullOrEmpty(File.ReadAllText(FPath)) || !string.IsNullOrWhiteSpace(File.ReadAllText(FPath)))
                {

                    DataTable Obj2 = Report_Obj.WillExpire(int.Parse(File.ReadAllText(FPath)));
                    if (Obj2.Rows.Count > 0)
                    {
                        if (ProductWillExpire == null || ProductWillExpire.IsDisposed == true)
                        {
                            ProductWillExpire = new ProductWillExpire();
                        } ProductWillExpire.MdiParent = this;
                        ProductWillExpire.Show();
                        ProductWillExpire.Select();
                    }
                }
                
            }


    

        }

        private void toggleSwitch1_Toggled(object sender, EventArgs e)
        {
           
        }

        private void toggleSwitch2_Toggled(object sender, EventArgs e)
        {
           
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panelControl2.Visible = false;
            panelControl3.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (itemhide == false)
            {
                panelControl1.AutoScroll = false;

                panelControl1.Width = 63;
                itemhide = true;
                groupControl1.Visible = false;

                //64; 0   64; 53
                panelControl2.Location = new Point(62, 0);
                panelControl3.Location = new Point(62, 53);


            }
            else
            {
                panelControl1.AutoScroll = true;

                panelControl1.Width = 332;
                itemhide = false;
                groupControl1.Visible = true;
                panelControl2.Location = new Point(331, 0);
                panelControl3.Location = new Point(331, 49);

            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
           if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }
           if (label4.Text != "قائمة المنتجات")
           {
               label4.Text = "قائمة المنتجات";
               AddProductMenu();
           }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click_2(object sender, EventArgs e)
        {
         
            if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }

            if (label4.Text != "قائمة المنتجات")
            {
                label4.Text = "قائمة المنتجات";
                AddProductMenu();
            }
           




        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }

            if (  label4.Text != "قائمة المشتريات")
            {
                label4.Text = "قائمة المشتريات";
                AddPurchtMenu();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true; 
               panelControl3.Visible = true;


            }
           if (label4.Text != "قائمة المشتريات")
           {
               label4.Text = "قائمة المشتريات";
               AddPurchtMenu();
           }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }
           if (label4.Text != "قائمة العملاء")
           {
               label4.Text = "قائمة العملاء";
               AddCustomerMenu();
           }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }
            if (label4.Text != "قائمة العملاء")
            {
                label4.Text = "قائمة العملاء";
                AddCustomerMenu();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
          if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }

          if (label4.Text != "قائمة الماليات")
          {
              label4.Text = "قائمة الماليات";
              AddMoneyMenu();
          }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
           if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }
           if (label4.Text != "قائمة الماليات")
           {
               label4.Text = "قائمة الماليات";
               AddMoneyMenu();
           }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }
            if (label4.Text != "قائمة التقارير")
            {
              label4.Text = "قائمة التقارير";
                AddReportMenu();
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
             if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }
             if (label4.Text != "قائمة التقارير")
             {
                 label4.Text = "قائمة التقارير";
                 AddReportMenu();
             }
        }

        private void simpleButton6_Click(object sender, EventArgs e)
        {
             if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }

             if (label4.Text != "قائمة الاعدادات")
             {
                 label4.Text = "قائمة الاعدادات";
                 AddSettingsMenu();
             }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
             if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }
             if (label4.Text != "قائمة الاعدادات")
             {
                 label4.Text = "قائمة الاعدادات";
                 AddSettingsMenu();
             }
        }

        private void simpleButton7_Click(object sender, EventArgs e)
        {
            if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }


            if (label4.Text != "قائمة المؤسسة")
            {
                label4.Text = "قائمة المؤسسة";
                AddCompanyMenu();
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }
            if (label4.Text != "قائمة المؤسسة")
            {
                label4.Text = "قائمة المؤسسة";
                AddCompanyMenu();
            }
        }

        private void simpleButton11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton8_Click(object sender, EventArgs e)
        {
            if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }
            if (label4.Text != "قائمة الموردين")
            {
                label4.Text = "قائمة الموردين";
                AddSupplierMenu();
            }
        }

        private void pictureBox10_Click_1(object sender, EventArgs e)
        {
             if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }
             if (label4.Text != "قائمة الموردين")
             {
                 label4.Text = "قائمة الموردين";
                 AddSupplierMenu();
             }
        }

      

       

        private void simpleButton10_Click(object sender, EventArgs e)
        {
            if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }
            if (label4.Text != "عن المطورين")
            {
                label4.Text = "عن المطورين";
                AddAboutMenu();
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }
            if (label4.Text != "عن المطورين")
            {
                label4.Text = "عن المطورين";
                AddAboutMenu();
            }
        }


        public void AddProductMenu()
        {
            panelControl3.Controls.Clear();

            SimpleButton[] ProducButtuns = new SimpleButton[8];
            Label[] Titels = new Label[5];

            for (int i = 0; i < ProducButtuns.Length; i++)
            {
                ProducButtuns[i] = new SimpleButton();
                ProducButtuns[i].PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
                ProducButtuns[i].Font = btnProduct.Font;
                ProducButtuns[i].Size = btnProduct.Size;
                ProducButtuns[i].ForeColor = btnProduct.ForeColor;
                ProducButtuns[i].Width = 300;
                ProducButtuns[i].Height = 45;


            }
            for (int i = 0; i < Titels.Length; i++)
            {
                Titels[i] = new Label();
                Titels[i].Font = new System.Drawing.Font("Andalus", 18, FontStyle.Bold);
                Titels[i].Height = 35;
                Titels[i].Width = 285;
                Titels[i].TextAlign = ContentAlignment.MiddleRight;

            }

            Titels[0].Text = "المجموعات الرئيسية";
            Titels[0].Location = new Point(0, 40);

            ProducButtuns[0].Text = "اضافة مجموعة رئيسة ";
            ProducButtuns[0].Location = new Point(17, 80);

            ProducButtuns[1].Text = "تحديث بيانات  المجموعات";
            ProducButtuns[1].Location = new Point(17, 130);


            Titels[1].Text = "الوحدات";
            Titels[1].Location = new Point(0, 180);


            ProducButtuns[2].Text = "اضافة وحدة ";
            ProducButtuns[2].Location = new Point(17, 230);

            ProducButtuns[3].Text = "تحديث بيانات وحدة ";
            ProducButtuns[3].Location = new Point(17, 280);


            Titels[2].Text = "المنتجات";
            Titels[2].Location = new Point(0, 330);

            ProducButtuns[4].Text = "اضافة بيانات منتج ";
            ProducButtuns[4].Location = new Point(17, 380);

            ProducButtuns[5].Text = "تحديث بيانات منتج ";
            ProducButtuns[5].Location = new Point(17, 430);

            Titels[3].Text = "الباركود";
            Titels[3].Location = new Point(0, 480);

            ProducButtuns[6].Text = "انشاء باركود";
            ProducButtuns[6].Location = new Point(17, 530);
          
            Titels[4].Text = "تقرير";
            Titels[4].Location = new Point(0, 580);

            ProducButtuns[7].Text = " حركة منتج ";
            ProducButtuns[7].Location = new Point(17, 630);


            panelControl3.Controls.Add(Titels[0]);
            panelControl3.Controls.Add(Titels[1]);
            panelControl3.Controls.Add(Titels[2]);
            panelControl3.Controls.Add(Titels[3]);
            panelControl3.Controls.Add(Titels[4]);


            panelControl3.Controls.Add(ProducButtuns[0]);
            panelControl3.Controls.Add(ProducButtuns[1]);

            panelControl3.Controls.Add(ProducButtuns[2]);
            panelControl3.Controls.Add(ProducButtuns[3]);

            panelControl3.Controls.Add(ProducButtuns[4]);
            panelControl3.Controls.Add(ProducButtuns[5]);
            panelControl3.Controls.Add(ProducButtuns[6]);
            panelControl3.Controls.Add(ProducButtuns[7]);


            ////add action

            ProducButtuns[0].Click += new EventHandler(ShowCataAdd);
            ProducButtuns[1].Click += new EventHandler(ShowCataUp);
            ProducButtuns[2].Click += new EventHandler(ShowUniteAdd);
            ProducButtuns[3].Click += new EventHandler(ShowUniteUp);
            ProducButtuns[4].Click += new EventHandler(ShowAddProduct);
            ProducButtuns[5].Click += new EventHandler(ShowProductUp);
            ProducButtuns[6].Click += new EventHandler(ShowBarcodeGer);
            ProducButtuns[7].Click += new EventHandler(ShowProductMovem);


        }

        public void AddCompanyMenu()
        {
            panelControl3.Controls.Clear();

            SimpleButton[] CompanyButtuns = new SimpleButton[5];
            Label[] Titels = new Label[4];

            for (int i = 0; i < CompanyButtuns.Length; i++)
            {
                CompanyButtuns[i] = new SimpleButton();
                CompanyButtuns[i].PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
                CompanyButtuns[i].Font = btnProduct.Font;
                CompanyButtuns[i].Size = btnProduct.Size;
                CompanyButtuns[i].ForeColor = btnProduct.ForeColor;
                CompanyButtuns[i].Width = 300;
                CompanyButtuns[i].Height = 45;


            }


            for (int i = 0; i < Titels.Length; i++)
            {
                Titels[i] = new Label();
                Titels[i].Font = new System.Drawing.Font("Andalus", 18, FontStyle.Bold);
                Titels[i].Height = 35;
                Titels[i].Width = 285;
                Titels[i].TextAlign = ContentAlignment.MiddleRight;


            }

            Titels[0].Text = "بيانات المؤسسة";
            Titels[0].Location = new Point(0, 40);

            CompanyButtuns[0].Text = "تحديث بيانات المؤسسة ";
            CompanyButtuns[0].Location = new Point(17, 80);

            Titels[1].Text = "اعدادات خاصة بالمنتج";
            Titels[1].Location = new Point(0, 130);

            CompanyButtuns[1].Text = " تنبيهات صلاحيات المنتجات";
            CompanyButtuns[1].Location = new Point(17, 180);

            CompanyButtuns[2].Text = "تصفير الكميات بالمخزن";
            CompanyButtuns[2].Location = new Point(17, 230);
            ////

            Titels[2].Text = "مسار حفظ ملفات الوسائط";
            Titels[2].Location = new Point(0, 280);

            CompanyButtuns[3].Text = "تحديث المسار ";
            CompanyButtuns[3].Location = new Point(17, 330);



            Titels[3].Text = "سلة المحذوفات";
            Titels[3].Location = new Point(0, 380);

            CompanyButtuns[4].Text = "سلة الحذف  ";
            CompanyButtuns[4].Location = new Point(17, 430);



            panelControl3.Controls.Add(Titels[0]);
            panelControl3.Controls.Add(Titels[1]);
            panelControl3.Controls.Add(Titels[2]);
            panelControl3.Controls.Add(Titels[3]);


            panelControl3.Controls.Add(CompanyButtuns[0]);
            panelControl3.Controls.Add(CompanyButtuns[1]);
            panelControl3.Controls.Add(CompanyButtuns[2]);
            panelControl3.Controls.Add(CompanyButtuns[3]);
            panelControl3.Controls.Add(CompanyButtuns[4]);



            CompanyButtuns[0].Click += new EventHandler(ShowCompanyInfo);
            CompanyButtuns[1].Click += new EventHandler(ShowExpireDate);
            CompanyButtuns[2].Click += new EventHandler(ShowStoreToZero);
            CompanyButtuns[3].Click += new EventHandler(ShowMediaPa);
            

        }

        public void AddSettingsMenu()
        {
            panelControl3.Controls.Clear();

            SimpleButton[] SettingsButtuns = new SimpleButton[5];
            Label[] Titels = new Label[4];

            for (int i = 0; i < SettingsButtuns.Length; i++)
            {
                SettingsButtuns[i] = new SimpleButton();
                SettingsButtuns[i].PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
                SettingsButtuns[i].Font = btnProduct.Font;
                SettingsButtuns[i].Size = btnProduct.Size;
                SettingsButtuns[i].ForeColor = btnProduct.ForeColor;
                SettingsButtuns[i].Width = 300;
                SettingsButtuns[i].Height = 45;


            }


            for (int i = 0; i < Titels.Length; i++)
            {
                Titels[i] = new Label();
                Titels[i].Font = new System.Drawing.Font("Andalus", 18, FontStyle.Bold);
                Titels[i].Height = 35;
                Titels[i].Width = 285;
                Titels[i].TextAlign = ContentAlignment.MiddleRight;


            }

            Titels[0].Text = "النسخ الاحتياطى والاسترجاع";
            Titels[0].Location = new Point(0, 40);

            SettingsButtuns[0].Text = " نسخ احتياطى واسترجاع ";
            SettingsButtuns[0].Location = new Point(17, 80);

            Titels[1].Text = "مستخدمين و صلاحيات";
            Titels[1].Location = new Point(0, 130);

            SettingsButtuns[1].Text = "اضافة مستخدم للنظام";
            SettingsButtuns[1].Location = new Point(17, 180);

            SettingsButtuns[2].Text = "تحديث بيانات مستخدم  ";
            SettingsButtuns[2].Location = new Point(17, 230);

            Titels[2].Text = "واجهة المستخدم";
            Titels[2].Location = new Point(0, 280);

            SettingsButtuns[3].Text = "تغير خلفية واجهة المستخدم";
            SettingsButtuns[3].Location = new Point(17, 330);

            Titels[3].Text = "اعدادات الاتصال";
            Titels[3].Location = new Point(0, 380);

            SettingsButtuns[4].Text = "تحديث اعدادات الاتصال";
            SettingsButtuns[4].Location = new Point(17, 430);

            panelControl3.Controls.Add(Titels[0]);
            panelControl3.Controls.Add(Titels[1]);
            panelControl3.Controls.Add(Titels[2]);
            panelControl3.Controls.Add(Titels[3]);

            panelControl3.Controls.Add(SettingsButtuns[0]);
            panelControl3.Controls.Add(SettingsButtuns[1]);
            panelControl3.Controls.Add(SettingsButtuns[2]);
            panelControl3.Controls.Add(SettingsButtuns[3]);
            panelControl3.Controls.Add(SettingsButtuns[4]);

      
            SettingsButtuns[0].Click += new EventHandler(ShowBackupAndRestore);
            SettingsButtuns[1].Click += new EventHandler(ShowSystemUserAdd);
            SettingsButtuns[2].Click += new EventHandler(ShowSystemUserUp);
            SettingsButtuns[4].Click += new EventHandler(ShowConncetionSettings);


        }

        public void AddCustomerMenu()
        {
            panelControl3.Controls.Clear();

            SimpleButton[] CustomerButtuns = new SimpleButton[5];
            Label[] Titels = new Label[3];

            for (int i = 0; i < CustomerButtuns.Length; i++)
            {
                CustomerButtuns[i] = new SimpleButton();
                CustomerButtuns[i].PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
                CustomerButtuns[i].Font = btnProduct.Font;
                CustomerButtuns[i].Size = btnProduct.Size;
                CustomerButtuns[i].ForeColor = btnProduct.ForeColor;
                CustomerButtuns[i].Width = 300;
                CustomerButtuns[i].Height = 45;


            }
            for (int i = 0; i < Titels.Length; i++)
            {
                Titels[i] = new Label();
                Titels[i].Font = new System.Drawing.Font("Andalus", 18, FontStyle.Bold);
                Titels[i].Height = 35;
                Titels[i].Width = 285;
                Titels[i].TextAlign = ContentAlignment.MiddleRight;

            }

            Titels[0].Text = "العملاء";
            Titels[0].Location = new Point(0, 40);


            CustomerButtuns[0].Text = "اضافة بيانات عميل";
            CustomerButtuns[0].Location = new Point(17, 80);

            CustomerButtuns[1].Text = "تحديث بيانات  عميل";
            CustomerButtuns[1].Location = new Point(17, 130);

            Titels[1].Text = "كشف حساب";
            Titels[1].Location = new Point(0, 180);

            CustomerButtuns[2].Text ="نقاط تصفية حساب";
            CustomerButtuns[2].Location = new Point(17, 230);

            CustomerButtuns[3].Text = "كشف حساب عميل";
            CustomerButtuns[3].Location = new Point(17, 280);

            Titels[2].Text = "العملاء";
            Titels[2].Location = new Point(0, 330);

            CustomerButtuns[4].Text = "كشف حساب العملاء ";
            CustomerButtuns[4].Location = new Point(17, 380);


            panelControl3.Controls.Add(Titels[0]);
            panelControl3.Controls.Add(Titels[1]);
            panelControl3.Controls.Add(Titels[2]);

            panelControl3.Controls.Add(CustomerButtuns[0]);
            panelControl3.Controls.Add(CustomerButtuns[1]);

            panelControl3.Controls.Add(CustomerButtuns[2]);
            panelControl3.Controls.Add(CustomerButtuns[3]);

            panelControl3.Controls.Add(CustomerButtuns[4]);


            CustomerButtuns[0].Click += new EventHandler(ShowCustomerAdd);
            CustomerButtuns[1].Click += new EventHandler(ShowCustomerUp);
            CustomerButtuns[2].Click += new EventHandler(ShowCustomerZaeroPay);
            CustomerButtuns[3].Click += new EventHandler(ShowCustomerAccountView);
            CustomerButtuns[4].Click += new EventHandler(ShowCustumersPaymentsView);
       


        }

        public void AddPurchtMenu()
        {
            panelControl3.Controls.Clear();

            SimpleButton[] PurchButtuns = new SimpleButton[4];
            Label[] Titels = new Label[2];

            for (int i = 0; i < PurchButtuns.Length; i++)
            {
                PurchButtuns[i] = new SimpleButton();
                PurchButtuns[i].PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
                PurchButtuns[i].Font = btnProduct.Font;
                PurchButtuns[i].Size = btnProduct.Size;
                PurchButtuns[i].ForeColor = btnProduct.ForeColor;
                PurchButtuns[i].Width = 300;
                PurchButtuns[i].Height = 45;


            }
            for (int i = 0; i < Titels.Length; i++)
            {
                Titels[i] = new Label();
                Titels[i].Font = new System.Drawing.Font("Andalus", 18, FontStyle.Bold);
                Titels[i].Height = 35;
                Titels[i].Width = 285;
                Titels[i].TextAlign = ContentAlignment.MiddleRight;

            }

            Titels[0].Text = "فاتورة المشتريات";
            Titels[0].Location = new Point(0, 40);


            PurchButtuns[0].Text = " اضافة فاتورة مشتريات";
            PurchButtuns[0].Location = new Point(17, 80);

            PurchButtuns[1].Text = "حذف فاتورة خطاء ";
            PurchButtuns[1].Location = new Point(17, 130);

            PurchButtuns[2].Text = "استلام فاتورة مشتريات";
            PurchButtuns[2].Location = new Point(17, 180);


             Titels[1].Text = "اجمالى";
             Titels[1].Location = new Point(0, 230);

            PurchButtuns[3].Text = "اجمالى مشتريات منتجات";
            PurchButtuns[3].Location = new Point(17, 280);


            panelControl3.Controls.Add(Titels[0]);
            panelControl3.Controls.Add(Titels[1]);

            panelControl3.Controls.Add(PurchButtuns[0]);
            panelControl3.Controls.Add(PurchButtuns[1]);
            panelControl3.Controls.Add(PurchButtuns[2]);
            panelControl3.Controls.Add(PurchButtuns[3]);

            PurchButtuns[0].Click += new EventHandler(ShowPurchesAdd);
            PurchButtuns[1].Click += new EventHandler(ShowPurcheDele);
            PurchButtuns[2].Click += new EventHandler(ShowAcceptPurch);
            PurchButtuns[3].Click += new EventHandler(ShowTotalPurch);


        }
        
        public void AddOrderMenu()
        {
            panelControl3.Controls.Clear();

            SimpleButton[] OrderButtuns = new SimpleButton[5];
            Label[] Titels = new Label[4];

            for (int i = 0; i < OrderButtuns.Length; i++)
            {
                OrderButtuns[i] = new SimpleButton();
                OrderButtuns[i].PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
                OrderButtuns[i].Font = btnProduct.Font;
                OrderButtuns[i].Size = btnProduct.Size;
                OrderButtuns[i].ForeColor = btnProduct.ForeColor;
                OrderButtuns[i].Width = 300;
                OrderButtuns[i].Height = 45;


            }
            for (int i = 0; i < Titels.Length; i++)
            {
                Titels[i] = new Label();
                Titels[i].Font = new System.Drawing.Font("Andalus", 18, FontStyle.Bold);
                Titels[i].Height = 35;
                Titels[i].Width = 285;
                Titels[i].TextAlign = ContentAlignment.MiddleRight;

            }

            Titels[0].Text = "فاتورة مبيعات";
            Titels[0].Location = new Point(0, 40);

            OrderButtuns[0].Text = " اضافة فاتورة مبيعات";
            OrderButtuns[0].Location = new Point(17, 80);


            Titels[1].Text = "عرض اسعار";
            Titels[1].Location = new Point(0, 130);

            OrderButtuns[1].Text = " اضافة عرض اسعار";
            OrderButtuns[1].Location = new Point(17, 180);

            OrderButtuns[2].Text = "استعلام عن عرض اسعار";
            OrderButtuns[2].Location = new Point(17, 230);


            Titels[2].Text = "اجمالى";
            Titels[2].Location = new Point(0, 280);

            OrderButtuns[3].Text = "اجمالى مبيعات منتجات";
            OrderButtuns[3].Location = new Point(17, 330);

            Titels[3].Text = "المخزن";
            Titels[3].Location = new Point(0, 380);

            OrderButtuns[4].Text = "جرد المخزن";
            OrderButtuns[4].Location = new Point(17, 430);

            panelControl3.Controls.Add(Titels[0]);
            panelControl3.Controls.Add(Titels[1]);
            panelControl3.Controls.Add(Titels[2]);
            panelControl3.Controls.Add(Titels[3]);

            panelControl3.Controls.Add(OrderButtuns[0]);
            panelControl3.Controls.Add(OrderButtuns[1]);
            panelControl3.Controls.Add(OrderButtuns[2]);
            panelControl3.Controls.Add(OrderButtuns[3]); 
            panelControl3.Controls.Add(OrderButtuns[4]);


            OrderButtuns[0].Click += new EventHandler(ShowOrderAdd);
            OrderButtuns[1].Click += new EventHandler(ShowOrderPriceAdd);
            OrderButtuns[2].Click += new EventHandler(ShowOrderPriceView);
            OrderButtuns[3].Click += new EventHandler(ShowTotalProductOrder);
            OrderButtuns[4].Click += new EventHandler(ShowStoreQuantity);


        }

        public void AddReternsMenu()
        {
            panelControl3.Controls.Clear();

            SimpleButton[] ReternButtuns = new SimpleButton[2];
            Label[] Titels = new Label[2];

            for (int i = 0; i < ReternButtuns.Length; i++)
            {
                ReternButtuns[i] = new SimpleButton();
                ReternButtuns[i].PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
                ReternButtuns[i].Font = btnProduct.Font;
                ReternButtuns[i].Size = btnProduct.Size;
                ReternButtuns[i].ForeColor = btnProduct.ForeColor;
                ReternButtuns[i].Width = 300;
                ReternButtuns[i].Height = 45;


            }
            for (int i = 0; i < Titels.Length; i++)
            {
                Titels[i] = new Label();
                Titels[i].Font = new System.Drawing.Font("Andalus", 18, FontStyle.Bold);
                Titels[i].Height = 35;
                Titels[i].Width = 285;
                Titels[i].TextAlign = ContentAlignment.MiddleRight;

            }

            Titels[0].Text = "فاتورة مرتجع";
            Titels[0].Location = new Point(0, 40);

            ReternButtuns[0].Text = " اضافة فاتورة مرتجع";
            ReternButtuns[0].Location = new Point(17, 80);


            Titels[1].Text = "اجمالى";
            Titels[1].Location = new Point(0, 130);

            ReternButtuns[1].Text = "اجمالى مرتجعات منتج";
            ReternButtuns[1].Location = new Point(17, 180);

            
            panelControl3.Controls.Add(Titels[0]);
            panelControl3.Controls.Add(Titels[1]);
          

            panelControl3.Controls.Add(ReternButtuns[0]);
            panelControl3.Controls.Add(ReternButtuns[1]);
           

        }

        public void AddSupplierMenu()
        {
            panelControl3.Controls.Clear();

            SimpleButton[] SupplierButtuns = new SimpleButton[5];
            Label[] Titels = new Label[3];

            for (int i = 0; i < SupplierButtuns.Length; i++)
            {
                SupplierButtuns[i] = new SimpleButton();
                SupplierButtuns[i].PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
                SupplierButtuns[i].Font = btnProduct.Font;
                SupplierButtuns[i].Size = btnProduct.Size;
                SupplierButtuns[i].ForeColor = btnProduct.ForeColor;
                SupplierButtuns[i].Width = 300;
                SupplierButtuns[i].Height = 45;


            }
            for (int i = 0; i < Titels.Length; i++)
            {
                Titels[i] = new Label();
                Titels[i].Font = new System.Drawing.Font("Andalus", 18, FontStyle.Bold);
                Titels[i].Height = 35;
                Titels[i].Width = 285;
                Titels[i].TextAlign = ContentAlignment.MiddleRight;

            }

            Titels[0].Text = "الموردين";
            Titels[0].Location = new Point(0, 40);


            SupplierButtuns[0].Text = "اضافة بيانات مورد";
            SupplierButtuns[0].Location = new Point(17, 80);

            SupplierButtuns[1].Text = "تحديث بيانات مورد";
            SupplierButtuns[1].Location = new Point(17, 130);

            Titels[1].Text = "كشف حساب";
            Titels[1].Location = new Point(0, 180);

            SupplierButtuns[2].Text = "نقاط تصفية حساب";
            SupplierButtuns[2].Location = new Point(17, 230);

            SupplierButtuns[3].Text = "كشف حساب مورد";
            SupplierButtuns[3].Location = new Point(17, 280);

            Titels[2].Text = "الموردين";
            Titels[2].Location = new Point(0, 330);

            SupplierButtuns[4].Text = "كشف حساب الموردين ";
            SupplierButtuns[4].Location = new Point(17, 380);


            panelControl3.Controls.Add(Titels[0]);
            panelControl3.Controls.Add(Titels[1]);
            panelControl3.Controls.Add(Titels[2]);

            panelControl3.Controls.Add(SupplierButtuns[0]);
            panelControl3.Controls.Add(SupplierButtuns[1]);

            panelControl3.Controls.Add(SupplierButtuns[2]);
            panelControl3.Controls.Add(SupplierButtuns[3]);

            panelControl3.Controls.Add(SupplierButtuns[4]);


            SupplierButtuns[0].Click += new EventHandler(ShowSupplierAdd);
            SupplierButtuns[1].Click += new EventHandler(ShowSupplierUp);
            SupplierButtuns[2].Click += new EventHandler(ShowSupplierZeroPoints);
            SupplierButtuns[3].Click += new EventHandler(ShowSupplierAccountView);
            SupplierButtuns[4].Click += new EventHandler(ShowSuppliersAccountsView);
       

        }
      
        public void AddMoneyMenu()
        {
            panelControl3.Controls.Clear();

            SimpleButton[] MoneyButtuns = new SimpleButton[11];
            Label[] Titels = new Label[5];

            for (int i = 0; i < MoneyButtuns.Length; i++)
            {
                MoneyButtuns[i] = new SimpleButton();
                MoneyButtuns[i].PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
                MoneyButtuns[i].Font = btnProduct.Font;
                MoneyButtuns[i].Size = btnProduct.Size;
                MoneyButtuns[i].ForeColor = btnProduct.ForeColor;
                MoneyButtuns[i].Width = 300;
                MoneyButtuns[i].Height = 45;


            }
            for (int i = 0; i < Titels.Length; i++)
            {
                Titels[i] = new Label();
                Titels[i].Font = new System.Drawing.Font("Andalus", 18, FontStyle.Bold);
                Titels[i].Height = 35;
                Titels[i].Width = 285;
                Titels[i].TextAlign = ContentAlignment.MiddleRight;

            }

            Titels[0].Text = "المصروفات / الايرادات";
            Titels[0].Location = new Point(0, 40);

            MoneyButtuns[0].Text = "اضافة بنود مصروفات/ايرادات";
            MoneyButtuns[0].Location = new Point(17, 80);
            MoneyButtuns[1].Text = "تحديث بيانات البنود";
            MoneyButtuns[1].Location = new Point(17, 130);

            MoneyButtuns[2].Text = "اضافةمصروفات/ايرادات";
            MoneyButtuns[2].Location = new Point(17, 180);

            MoneyButtuns[3].Text = "تحديث مصروفات/ايرادات";
            MoneyButtuns[3].Location = new Point(17, 230);


            Titels[1].Text = " الخزنة";
            Titels[1].Location = new Point(0, 280);

            MoneyButtuns[4].Text = "تحديث قيمةالخزنة  ";
            MoneyButtuns[4].Location = new Point(17, 330);


            Titels[2].Text = " تسديدات مبيعات";
            Titels[2].Location = new Point(0, 380);

            MoneyButtuns[5].Text = "تسديد باقى فاتورة بيع";
            MoneyButtuns[5].Location = new Point(17, 430);

            MoneyButtuns[6].Text = "تحديث بيانات تسديدة";
            MoneyButtuns[6].Location = new Point(17, 480);

            Titels[3].Text = " تسديدات مشتريات";
            Titels[3].Location = new Point(0, 530);

            MoneyButtuns[7].Text = "تسديد باقى مشتريات";
            MoneyButtuns[7].Location = new Point(17, 580);

            MoneyButtuns[8].Text = "تحديث تسديدة باقى مشتريات";
            MoneyButtuns[8].Location = new Point(17, 630);


            Titels[4].Text = "تسديدات مرتجعات";
            Titels[4].Location = new Point(0, 680);

            MoneyButtuns[9].Text = "تسديد باقى مرتجع";
            MoneyButtuns[9].Location = new Point(17, 730);

            MoneyButtuns[10].Text = "تحديث بيانات التسديدة ";
            MoneyButtuns[10].Location = new Point(17, 780);

            panelControl3.Controls.Add(Titels[0]);
            panelControl3.Controls.Add(Titels[1]);
            panelControl3.Controls.Add(Titels[2]);
            panelControl3.Controls.Add(Titels[3]);
            panelControl3.Controls.Add(Titels[4]);


            panelControl3.Controls.Add(MoneyButtuns[0]);
            panelControl3.Controls.Add(MoneyButtuns[1]);
            panelControl3.Controls.Add(MoneyButtuns[2]);
            panelControl3.Controls.Add(MoneyButtuns[3]);
            panelControl3.Controls.Add(MoneyButtuns[4]);
            panelControl3.Controls.Add(MoneyButtuns[5]);
            panelControl3.Controls.Add(MoneyButtuns[6]);
            panelControl3.Controls.Add(MoneyButtuns[7]);
            panelControl3.Controls.Add(MoneyButtuns[8]);
            panelControl3.Controls.Add(MoneyButtuns[9]);
            panelControl3.Controls.Add(MoneyButtuns[10]);


            MoneyButtuns[0].Click += new EventHandler(ShowPayRevTypesAdd);
            MoneyButtuns[1].Click += new EventHandler(ShowPayRevTypesUp);
            MoneyButtuns[2].Click += new EventHandler(ShowPayRevAdd);
            MoneyButtuns[3].Click += new EventHandler(ShowPayRevUp);
            MoneyButtuns[4].Click += new EventHandler(ShowSafeUp);
            MoneyButtuns[5].Click += new EventHandler(ShowPayBackOrderAdd);
            MoneyButtuns[6].Click += new EventHandler(ShowPayBackOrderUp);
            MoneyButtuns[7].Click += new EventHandler(ShowPayBackPuchAdd);
            MoneyButtuns[8].Click += new EventHandler(ShowPayBackPurchUp);
            MoneyButtuns[9].Click += new EventHandler(ShowPayBackReternAdd);
            MoneyButtuns[10].Click += new EventHandler(ShowPayBackReterUp);

            // add event to butons 

     

        }


        public void AddAboutMenu()
        {
            panelControl3.Controls.Clear();

            SimpleButton[] AboutButtuns = new SimpleButton[1];
            Label[] Titels = new Label[1];

            for (int i = 0; i < AboutButtuns.Length; i++)
            {
                AboutButtuns[i] = new SimpleButton();
                AboutButtuns[i].PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
                AboutButtuns[i].Font = btnProduct.Font;
                AboutButtuns[i].Size = btnProduct.Size;
                AboutButtuns[i].ForeColor = btnProduct.ForeColor;
                AboutButtuns[i].Width = 300;
                AboutButtuns[i].Height = 45;


            }
            for (int i = 0; i < Titels.Length; i++)
            {
                Titels[i] = new Label();
                Titels[i].Font = new System.Drawing.Font("Andalus", 18, FontStyle.Bold);
                Titels[i].Height = 35;
                Titels[i].Width = 285;
                Titels[i].TextAlign = ContentAlignment.MiddleRight;

            }

            Titels[0].Text = " عن المطوريين ";
            Titels[0].Location = new Point(0, 40);

            AboutButtuns[0].Text = " المطورين";
            AboutButtuns[0].Location = new Point(17, 80);
         


            panelControl3.Controls.Add(Titels[0]);
           


            panelControl3.Controls.Add(AboutButtuns[0]);


            AboutButtuns[0].Click += new EventHandler(ShowAbout);
      



        }

        public void AddReportMenu()
        {
            panelControl3.Controls.Clear();

            SimpleButton[] ReportButtuns = new SimpleButton[5];
            Label[] Titels = new Label[9];

            for (int i = 0; i < ReportButtuns.Length; i++)
            {
                ReportButtuns[i] = new SimpleButton();
                ReportButtuns[i].PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
                ReportButtuns[i].Font = btnProduct.Font;
                ReportButtuns[i].Size = btnProduct.Size;
                ReportButtuns[i].ForeColor = btnProduct.ForeColor;
                ReportButtuns[i].Width = 300;
                ReportButtuns[i].Height = 45;

            }
            for (int i = 0; i < Titels.Length; i++)
            {
                Titels[i] = new Label();
                Titels[i].Font = new System.Drawing.Font("Andalus", 18, FontStyle.Bold);
                Titels[i].Height = 35;
                Titels[i].Width = 285;
                Titels[i].TextAlign = ContentAlignment.MiddleRight;

            }

            Titels[0].Text = "تقارير المنتجات";
            Titels[0].Location = new Point(0, 40);
            ReportButtuns[0].Text = "المنتجات الموجودة بالنظام";
            ReportButtuns[0].Location = new Point(17,80);
            ReportButtuns[1].Text = "تنبيه الكميات المتوفرة بالمخزن";
            ReportButtuns[1].Location = new Point(17, 130);
            ReportButtuns[3].Text = "منتج اوشكت صلاحيته ع الانتهاء";
            ReportButtuns[3].Location = new Point(17, 180);

            Titels[1].Text = " تقارير الموردين";
            Titels[1].Location = new Point(0, 230);

            Titels[2].Text = "تقارير العملاء ";
            Titels[2].Location = new Point(0, 360);

            Titels[3].Text = "تقارير الماليات ";
            Titels[3].Location = new Point(0, 520);
            ReportButtuns[2].Text = "مصروفات وايرادات ";
            ReportButtuns[2].Location = new Point(17, 570);
            Titels[4].Text = "تقارير المشتريات ";
            Titels[4].Location = new Point(0, 680);

            Titels[5].Text = "تقارير المبيعات ";
            Titels[5].Location = new Point(0, 840);

            Titels[6].Text = "تقارير المرتجعات ";
            Titels[6].Location = new Point(0, 1000);


            Titels[7].Text = "تقارير الارباح ";
            Titels[7].Location = new Point(0, 1200);

            Titels[8].Text = "تقارير مستخدم النظام ";
            Titels[8].Location = new Point(0, 1300);

            panelControl3.Controls.Add(Titels[0]);
            panelControl3.Controls.Add(Titels[1]);
            panelControl3.Controls.Add(Titels[2]);
            panelControl3.Controls.Add(Titels[3]);
            panelControl3.Controls.Add(Titels[4]);
            panelControl3.Controls.Add(Titels[5]);
            panelControl3.Controls.Add(Titels[6]);
            panelControl3.Controls.Add(Titels[7]);
            panelControl3.Controls.Add(Titels[8]);


            panelControl3.Controls.Add(ReportButtuns[0]);
            panelControl3.Controls.Add(ReportButtuns[1]);
            panelControl3.Controls.Add(ReportButtuns[2]);
            panelControl3.Controls.Add(ReportButtuns[3]);


            ReportButtuns[0].Click += new EventHandler(ShowALlProductInSystem);
            ReportButtuns[1].Click += new EventHandler(ShowProducQuantityAlert);
            ReportButtuns[2].Click += new EventHandler(ShowPayRev);
            ReportButtuns[3].Click += new EventHandler(ShowProductWillExpire);






        }

        private void ShowProductWillExpire(object sender, EventArgs e)
        {
            if (ProductWillExpire == null || ProductWillExpire.IsDisposed == true)
            {
                ProductWillExpire = new ProductWillExpire();
            } ProductWillExpire.MdiParent = this;
            ProductWillExpire.Show();
            ProductWillExpire.Select();
        }

        private void ShowPayRev(object sender, EventArgs e)
        {
            if (RevPay_Rep == null || RevPay_Rep.IsDisposed == true)
            {
                RevPay_Rep = new RevPay_Rep();
            } RevPay_Rep.MdiParent = this;
            RevPay_Rep.Show();
            RevPay_Rep.Select();
        }

        private void ShowProducQuantityAlert(object sender, EventArgs e)
        {

            if (ProductQuantityAlert == null || ProductQuantityAlert.IsDisposed == true)
            {
                ProductQuantityAlert = new ProductQuantityAlert();
            } ProductQuantityAlert.MdiParent = this;
            ProductQuantityAlert.Show();
            ProductQuantityAlert.Select();
        }
        
     
        private void ShowAbout(Object sender, EventArgs e)
        {
            if (AboutUs == null || AboutUs.IsDisposed == true)
            {
                AboutUs = new AboutUs();
            } AboutUs.MdiParent = this;
            AboutUs.Show();
            AboutUs.Select();

        }

        private void ShowMediaPa(object sender, EventArgs e)
        {
            if (MediaPath == null || MediaPath.IsDisposed == true)
            {
                MediaPath = new MediaPath();
            } MediaPath.MdiParent = this;
            MediaPath.Show();
            MediaPath.Select();
        }
    

        private void Home_Activated(object sender, EventArgs e)
        {
          
        }
        public void DisablePict()
        {
            B.Dispose();
        }
        public string CurrentUser()
        {
            return LaUserName.Text;
        }
        public void SetNewImage(string Path)
        {
            B = new Bitmap(Path);
            UserPic.Image = B;
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {

            try
            {
               
                log Obj = new log();
                Obj.Show();
                this.Hide();
            
            
            }
            catch { }



        }

        private void skinDropDownButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
          

        }

     

        

        private void skinDropDownButtonItem1_HyperlinkClick_1(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {
         
            
        }

        private void skinBarSubItem1_CloseUp(object sender, EventArgs e)
        {
            
        }

        private void skinBarSubItem1_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {
            
        }

        private void skinBarSubItem1_PaintMenuBar(object sender, DevExpress.XtraBars.BarCustomDrawEventArgs e)
        {
            
        }

     

        private void skinDropDownButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
         // w
        }

        private void simpleButton11_Click_1(object sender, EventArgs e)
        {
            if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }
            if (label4.Text != "قائمة المبيعات")
            {
                label4.Text = "قائمة المبيعات";
                AddOrderMenu();
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }
            if (label4.Text != "قائمة المبيعات")
            {
                label4.Text = "قائمة المبيعات";
                AddOrderMenu();
            }
        }

        private void Home_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                changeColor(UserLookAndFeel.Default.SkinName.ToString());

                var SkinPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                SkinPath = SkinPath + @"\SkinName.txt";
                StreamWriter SW = new StreamWriter(SkinPath);
                SW.Write(UserLookAndFeel.Default.SkinName.ToString());
                SW.Close();

            }
            catch { }
            
            Skin currentSkin = CommonSkins.GetSkin(UserLookAndFeel.Default);
            Color color= currentSkin.Colors.GetColor(DevExpress.Skins.CommonColors.DisabledControl);

            LaUserName.BackColor = color;
            label1.BackColor = color;
            label2.BackColor = color;
            label4.BackColor = color;
            label5.BackColor = color;

            pictureBox1.BackColor = color;
            pictureBox2.BackColor = color;
            pictureBox3.BackColor = color;
            pictureBox4.BackColor = color;
            pictureBox5.BackColor = color;
            pictureBox6.BackColor = color;
            pictureBox7.BackColor = color;
            pictureBox8.BackColor = color;
            pictureBox9.BackColor = color;
            pictureBox10.BackColor = color;
            pictureBox12.BackColor = color;
            pictureBox13.BackColor = color;
            



        }

        private void btnReterns_Click(object sender, EventArgs e)
        {
            
             if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }

            if (  label4.Text != "قائمة المرتجعات")
            {
                label4.Text = "قائمة المرتجعات";
                AddReternsMenu();
            }
            
        }

        private void pictureBox11_Click_1(object sender, EventArgs e)
        {

            if (panelControl2.Visible == false)
            {
                panelControl2.Visible = true;
                panelControl3.Visible = true;

            }

            if (label4.Text != "قائمة المرتجعات")
            {
                label4.Text = "قائمة المرتجعات";
                AddReternsMenu();
            }
        }


        private void ShowAddProduct(Object sender, EventArgs e)
        {
            if (ProductAdd == null || ProductAdd.IsDisposed == true)
            {
                ProductAdd = new ProductAdd();
            } ProductAdd.MdiParent = this;
            ProductAdd.Show();
            ProductAdd.Select();

        }


        private void ShowProductUp(Object sender, EventArgs e)
        {
            if (ProductUp == null || ProductUp.IsDisposed == true)
            {
                ProductUp = new ProductUp();
            } ProductUp.MdiParent = this;
            ProductUp.Show();
            ProductUp.Select();

        }

        private void ShowCataAdd(Object sender, EventArgs e)
        {
            if (CatagoryAdd == null || CatagoryAdd.IsDisposed == true)
            {
                CatagoryAdd = new CatagoryAdd();
            } CatagoryAdd.MdiParent = this;
            CatagoryAdd.Show();
            CatagoryAdd.Select();

        }
        private void ShowCataUp(Object sender, EventArgs e)
        {
            if (CatagoryUp == null || CatagoryUp.IsDisposed == true)
            {
                CatagoryUp = new CatagoryUp();
            } CatagoryUp.MdiParent = this;
            CatagoryUp.Show();
            CatagoryUp.Select();

        }
        private void ShowProductMovem(Object sender, EventArgs e)
        {
            if (ProductMovement == null || ProductMovement.IsDisposed == true)
            {
                ProductMovement = new ProductMovement();
            } ProductMovement.MdiParent = this;
            ProductMovement.Show();
            ProductMovement.Select();

        }
        private void ShowBarcodeGer(Object sender, EventArgs e)
        {
            if (BarcodeGenerator == null || BarcodeGenerator.IsDisposed == true)
            {
                BarcodeGenerator = new BarcodeGenerator();
            } BarcodeGenerator.MdiParent = this;
            BarcodeGenerator.Show();
            BarcodeGenerator.Select();

        }

        private void ShowUniteAdd(Object sender, EventArgs e)
        {
            if (UniteAdd == null || UniteAdd.IsDisposed == true)
            {
                UniteAdd = new UniteAdd();
            } UniteAdd.MdiParent = this;
            UniteAdd.Show();
            UniteAdd.Select();

        }
        private void ShowUniteUp(Object sender, EventArgs e)
        {
            if (UniteUp == null || UniteUp.IsDisposed == true)
            {
                UniteUp = new UniteUp();
            } UniteUp.MdiParent = this;
            UniteUp.Show();
            UniteUp.Select();

        }
        private void ShowCompanyInfo(Object sender, EventArgs e)
        {
            if (CompanyInfo == null || CompanyInfo.IsDisposed == true)
            {
                CompanyInfo = new CompanyInfo();
            } CompanyInfo.MdiParent = this;
            CompanyInfo.Show();
            CompanyInfo.Select();

        }

        private void ShowExpireDate(Object sender, EventArgs e)
        {
            if (ExpireDateAlert == null || ExpireDateAlert.IsDisposed == true)
            {
                ExpireDateAlert = new ExpireDateAlert();
            } ExpireDateAlert.MdiParent = this;
            ExpireDateAlert.Show();
            ExpireDateAlert.Select();

        }
        private void ShowMediaPath(Object sender, EventArgs e)
        {
            if (MediaPath == null || MediaPath.IsDisposed == true)
            {
                MediaPath = new MediaPath();
            } MediaPath.MdiParent = this;
            MediaPath.Show();
            MediaPath.Select();

        }

        private void ShowStoreToZero(Object sender, EventArgs e)
        {
            if (StoreToZero == null || StoreToZero.IsDisposed == true)
            {
                StoreToZero = new StoreToZero();
            } StoreToZero.MdiParent = this;
            StoreToZero.Show();
            StoreToZero.Select();
        }

        private void ShowCustomerAdd(Object sender, EventArgs e)
        {
            if (CustomerAdd == null || CustomerAdd.IsDisposed == true)
            {
                CustomerAdd = new CustomerAdd();
            } CustomerAdd.MdiParent = this;
            CustomerAdd.Show();
            CustomerAdd.Select();
        }
        private void ShowCustomerUp(Object sender, EventArgs e)
        {
            if (CustomerUp == null || CustomerUp.IsDisposed == true)
            {
                CustomerUp = new CustomerUp();
            } CustomerUp.MdiParent = this;
            CustomerUp.Show();
            CustomerUp.Select();
        }

        private void ShowCustomerAccountView(Object sender, EventArgs e)
        {
            if (CustomerAccountView == null || CustomerAccountView.IsDisposed == true)
            {
                CustomerAccountView = new CustomerAccountView();
            } CustomerAccountView.MdiParent = this;
            CustomerAccountView.Show();
            CustomerAccountView.Select();
        }

        private void ShowCustomerZaeroPay(Object sender, EventArgs e)
        {
            if (CustomerZaeroPay == null || CustomerZaeroPay.IsDisposed == true)
            {
                CustomerZaeroPay = new CustomerZaeroPay();
            } CustomerZaeroPay.MdiParent = this;
            CustomerZaeroPay.Show();
            CustomerZaeroPay.Select();
        }
        private void ShowCustumersPaymentsView(Object sender, EventArgs e)
        {
            if (CustumersPaymentsView == null || CustumersPaymentsView.IsDisposed == true)
            {
                CustumersPaymentsView = new CustumersPaymentsView();
            } CustumersPaymentsView.MdiParent = this;
            CustumersPaymentsView.Show();
            CustumersPaymentsView.Select();
        }
        private void ShowPayBackOrderAdd(Object sender, EventArgs e)
        {
            if (PayBackOrderAdd == null || PayBackOrderAdd.IsDisposed == true)
            {
                PayBackOrderAdd = new PayBackOrderAdd();
            } PayBackOrderAdd.MdiParent = this;
            PayBackOrderAdd.Show();
            PayBackOrderAdd.Select();
        }
        private void ShowPayBackOrderUp(Object sender, EventArgs e)
        {
            if (PayBackOrderUp == null || PayBackOrderUp.IsDisposed == true)
            {
                PayBackOrderUp = new PayBackOrderUp();
            } PayBackOrderUp.MdiParent = this;
            PayBackOrderUp.Show();
            PayBackOrderUp.Select();
        }

        private void ShowPayBackPuchAdd(Object sender, EventArgs e)
        {
            if (PayBackPuchAdd == null || PayBackPuchAdd.IsDisposed == true)
            {
                PayBackPuchAdd = new PayBackPuchAdd();
            } PayBackPuchAdd.MdiParent = this;
            PayBackPuchAdd.Show();
            PayBackPuchAdd.Select();
        }
        private void ShowPayBackPurchUp(Object sender, EventArgs e)
        {
            if (PayBackPurchUp == null || PayBackPurchUp.IsDisposed == true)
            {
                PayBackPurchUp = new PayBackPurchUp();
            } PayBackPurchUp.MdiParent = this;
            PayBackPurchUp.Show();
            PayBackPurchUp.Select();
        }

        private void ShowPayBackReternAdd(Object sender, EventArgs e)
        {
            if (PayBackReternAdd == null || PayBackReternAdd.IsDisposed == true)
            {
                PayBackReternAdd = new PayBackReternAdd();
            } PayBackReternAdd.MdiParent = this;
            PayBackReternAdd.Show();
            PayBackReternAdd.Select();
        }

        private void ShowPayBackReterUp(Object sender, EventArgs e)
        {
            if (PayBackReterUp == null || PayBackReterUp.IsDisposed == true)
            {
                PayBackReterUp = new PayBackReterUp();
            } PayBackReterUp.MdiParent = this;
            PayBackReterUp.Show();
            PayBackReterUp.Select();
        }

        private void ShowPayRevAdd(Object sender, EventArgs e)
        {
            if (PayRevAdd == null || PayRevAdd.IsDisposed == true)
            {
                PayRevAdd = new PayRevAdd();
            } PayRevAdd.MdiParent = this;
            PayRevAdd.Show();
            PayRevAdd.Select();
        }

        private void ShowPayRevTypesAdd(Object sender, EventArgs e)
        {
            if (PayRevTypesAdd == null || PayRevTypesAdd.IsDisposed == true)
            {
                PayRevTypesAdd = new PayRevTypesAdd();
            } PayRevTypesAdd.MdiParent = this;
            PayRevTypesAdd.Show();
            PayRevTypesAdd.Select();
        }
        private void ShowPayRevTypesUp(Object sender, EventArgs e)
        {
            if (PayRevTypesUp == null || PayRevTypesUp.IsDisposed == true)
            {
                PayRevTypesUp = new PayRevTypesUp();
            } PayRevTypesUp.MdiParent = this;
            PayRevTypesUp.Show();
            PayRevTypesUp.Select();
        }
        private void ShowPayRevUp(Object sender, EventArgs e)
        {
            if (PayRevUp == null || PayRevUp.IsDisposed == true)
            {
                PayRevUp = new PayRevUp();
            } PayRevUp.MdiParent = this;
            PayRevUp.Show();
            PayRevUp.Select();

        }

        private void ShowOrderAdd(Object sender, EventArgs e)
        {
            if (OrderAdd == null || OrderAdd.IsDisposed == true)
            {
                OrderAdd = new OrderAdd();
            } OrderAdd.MdiParent = this;
            OrderAdd.Show();
            OrderAdd.Select();

        }

        private void ShowOrderPriceAdd(Object sender, EventArgs e)
        {
            if (OrderPriceAdd == null || OrderPriceAdd.IsDisposed == true)
            {
                OrderPriceAdd = new OrderPriceAdd();
            } OrderPriceAdd.MdiParent = this;
            OrderPriceAdd.Show();
            OrderPriceAdd.Select();

        }

        private void ShowOrderPriceView(Object sender, EventArgs e)
        {
            if (OrderPriceView == null || OrderPriceView.IsDisposed == true)
            {
                OrderPriceView = new OrderPriceView();
            } OrderPriceView.MdiParent = this;
            OrderPriceView.Show();
            OrderPriceView.Select();

        }
        private void ShowStoreQuantity(Object sender, EventArgs e)
        {
            if (StoreQuantity == null || StoreQuantity.IsDisposed == true)
            {
                StoreQuantity = new StoreQuantity();
            } StoreQuantity.MdiParent = this;
            StoreQuantity.Show();
            StoreQuantity.Select();

        }
        private void ShowTotalProductOrder(Object sender, EventArgs e)
        {
            if (TotalProductOrder == null || TotalProductOrder.IsDisposed == true)
            {
                TotalProductOrder = new TotalProductOrder();
            } TotalProductOrder.MdiParent = this;
            TotalProductOrder.Show();
            TotalProductOrder.Select();

        }

        private void ShowAcceptPurch(Object sender, EventArgs e)
        {
            if (AcceptPurch == null || AcceptPurch.IsDisposed == true)
            {
                AcceptPurch = new AcceptPurch();
            } AcceptPurch.MdiParent = this;
            AcceptPurch.Show();
            AcceptPurch.Select();

        }
        private void ShowPurchesAdd(Object sender, EventArgs e)
        {
            if (PurchesAdd == null || PurchesAdd.IsDisposed == true)
            {
                PurchesAdd = new PurchesAdd();
            } PurchesAdd.MdiParent = this;
            PurchesAdd.Show();
            PurchesAdd.Select();

        }

        private void ShowPurcheDele(Object sender, EventArgs e)
        {
            if (PucheDele == null || PucheDele.IsDisposed == true)
            {
                PucheDele = new PucheDele();
            } PucheDele.MdiParent = this;
            PucheDele.Show();
            PucheDele.Select();

        }
        private void ShowTotalPurch(Object sender, EventArgs e)
        {
            if (TotalOrderPurch == null || TotalOrderPurch.IsDisposed == true)
            {
                TotalOrderPurch = new TotalPurch();
            } TotalOrderPurch.MdiParent = this;
            TotalOrderPurch.Show();
            TotalOrderPurch.Select();

        }


        private void ShowBackupAndRestore(Object sender, EventArgs e)
        {
            if (BackupAndRestore == null || BackupAndRestore.IsDisposed == true)
            {
                BackupAndRestore = new BackupAndRestore();
            } BackupAndRestore.MdiParent = this;
            BackupAndRestore.Show();
            BackupAndRestore.Select();

        }

        private void ShowConncetionSettings(Object sender, EventArgs e)
        {
            if (ConncetionSettings == null || ConncetionSettings.IsDisposed == true)
            {
                ConncetionSettings = new ConncetionSettings();
            } ConncetionSettings.MdiParent = this;
            ConncetionSettings.Show();
            ConncetionSettings.Select();

        }
        private void ShowSystemUserAdd(Object sender, EventArgs e)
        {
            if (SystemUserAdd == null || SystemUserAdd.IsDisposed == true)
            {
                SystemUserAdd = new SystemUserAdd();
            } SystemUserAdd.MdiParent = this;
            SystemUserAdd.Show();
            SystemUserAdd.Select();

        }
        private void ShowSystemUserUp(Object sender, EventArgs e)
        {
            if (SystemUserUp == null || SystemUserUp.IsDisposed == true)
            {
                SystemUserUp = new SystemUserUp();
            } SystemUserUp.MdiParent = this;
            SystemUserUp.Show();
            SystemUserUp.Select();

        }

        private void ShowSafeUp(Object sender, EventArgs e)
        {
            if (SafeUp == null || SafeUp.IsDisposed == true)
            {
                SafeUp = new SafeUp();
            } SafeUp.MdiParent = this;
            SafeUp.Show();
            SafeUp.Select();

        }
        private void ShowSupplierAdd(Object sender, EventArgs e)
        {
            if (SupplierAdd == null || SupplierAdd.IsDisposed == true)
            {
                SupplierAdd = new SupplierAdd();
            } SupplierAdd.MdiParent = this;
            SupplierAdd.Show();
            SupplierAdd.Select();

        }
        private void ShowSupplierUp(Object sender, EventArgs e)
        {
            if (SupplierUp == null || SupplierUp.IsDisposed == true)
            {
                SupplierUp = new SupplierUp();
            } SupplierUp.MdiParent = this;
            SupplierUp.Show();
            SupplierUp.Select();

        }
        private void ShowSupplierAccountView(Object sender, EventArgs e)
        {
            if (SupplierAccountView == null || SupplierAccountView.IsDisposed == true)
            {
                SupplierAccountView = new SupplierAccountView();
            } SupplierAccountView.MdiParent = this;
            SupplierAccountView.Show();
            SupplierAccountView.Select();

        }
        private void ShowSuppliersAccountsView(Object sender, EventArgs e)
        {
            if (SuppliersAccountsView == null || SuppliersAccountsView.IsDisposed == true)
            {
                SuppliersAccountsView = new SuppliersAccountsView();
            } SuppliersAccountsView.MdiParent = this;
            SuppliersAccountsView.Show();
            SuppliersAccountsView.Select();

        }
        private void ShowSupplierZeroPoints(Object sender, EventArgs e)
        {
            if (SupplierZeroPoints == null || SupplierZeroPoints.IsDisposed == true)
            {
                SupplierZeroPoints = new SupplierZeroPoints();
            } SupplierZeroPoints.MdiParent = this;
            SupplierZeroPoints.Show();
            SupplierZeroPoints.Select();

        }

        private void ShowALlProductInSystem(Object sender, EventArgs e)
        {
            if (ALlProductInSystem == null || ALlProductInSystem.IsDisposed == true)
            {
                ALlProductInSystem = new ALlProductInSystem();
            } ALlProductInSystem.MdiParent = this;
            ALlProductInSystem.Show();
            ALlProductInSystem.Select();

        }
    }

}