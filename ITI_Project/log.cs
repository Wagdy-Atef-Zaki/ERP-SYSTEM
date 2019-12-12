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
using System.ServiceProcess;
using System.Data.SqlClient;
using System.Threading;
using System.IO;
using System.Diagnostics;
using ITI_Project.Properties;
using DevExpress.LookAndFeel;
using DevExpress.Skins;
using ItI_Project.HelpClass;
using ITI_Project;

namespace ItI_Project
{

    public partial class log : DevExpress.XtraEditors.XtraForm
    {
        private int Count;
        
        private ServiceController[] scServices;
        private ServiceController sc;
        private int TotalACAddress = 0, TotalBoardProductId = 0;
        bool ExistDataBase = false;
        string skinname, PictPath="";
      
        String BIOSserNo;
        String BoardProductId;
        Busniss_Logic BussinesObj;
        public log()
        {
            InitializeComponent();
            BIOSserNo = HardwareInfo.GetBIOSserNo();
            BoardProductId = HardwareInfo.GetBoardProductId();
             BussinesObj = new Busniss_Logic();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            if (Count < 5)
            {

                try
                {
                    System_Users_Table Object = BussinesObj.SelectUserName(txtusername.Text);
                     
                    String Pass = txtpassword.Text.Replace(" ", "");
                    if (Object.Sys_Pass.Replace(" ", "")== Pass)
                    {
                        Home M = new Home();
                        M.Show();
                        this.Hide();

                    }
                    else
                    {
                        XtraMessageBox.Show("الرجاء التاكد من كلمة المرور ثم المحاولة لاحقا ");
                    }

                   
                }
                catch (Exception E)
                {

                    if (E.Message == "Object reference not set to an instance of an object.")
                    {
                        XtraMessageBox.Show("اسم المستخدم غير موجود يرجى التاكد من اسم المستخدم ");
                    }
                    else
                    {
                      //  XtraMessageBox.Show(E.Message);
                    }


                }
                finally
                {
                    try
                    {
                        
                    }
                    catch (Exception Mes)
                    {
                        if (Mes.Message == "Object reference not set to an instance of an object.")
                        {

                            DialogResult dialogResult = MessageBox.Show("توجد مشكلة فى الاتصال بالسيرفر هل تريد العمل على النسخة المحلية لقواعد البيانات", " معلومات الاتصال", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {

                                ExistDataBase = CheckDatabase("Project_DB");

                                /// attach database 
                                if (ExistDataBase == false)
                                {
                                    try
                                    {

                                        string FileName = Path.Combine(Path.GetFullPath(@"DataBase\"));

                                        SqlConnection conn = new SqlConnection("Server=.;Data Source=;Integrated Security=SSPI");
                                        SqlCommand cmd = new SqlCommand("", conn);



                                        cmd.CommandText = "CREATE DATABASE Project_DB ON " +
                                             "( FILENAME =  '" + FileName + "Project_DB.mdf' )," +
                                              "( FILENAME ='" + FileName + "Project_DB_log.ldf')" +
                                             "FOR ATTACH";

                                        conn.Open();
                                        cmd.ExecuteNonQuery();
                                        cmd.Dispose();
                                        conn.Close();

                                    }
                                    catch { }

                                }
                                DataBaseConnection.ServerName = ".";
                                DataBaseConnection.UserName = "admin";
                                DataBaseConnection.Password = "admin";

                            }
                        }
                    }

                }


                Count++;

            }
            else
            {
                XtraMessageBox.Show("لقد تم استنفاذ محاولات الدخول ... سيتم اغلاق البرنامج الان");
                Application.Exit(); 
            }



        }
        public void changeColor(string SkinName)
        {

            if (SkinName.Contains("Dark") || SkinName.Contains("dark"))
            {
                labelControl1.ForeColor = Color.White;
                labelControl2.ForeColor = Color.White;
                checkEdit1.ForeColor = Color.White;


            }
            else
            {
                labelControl1.ForeColor = Color.Black;
                labelControl2.ForeColor = Color.Black;
                checkEdit1.ForeColor = Color.Black;

            }

        }

        private void log_Load(object sender, EventArgs e)
        {
            
            try
            {
                var SkinPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                SkinPath = SkinPath + @"\SkinName.txt";
                if (File.Exists(SkinPath))
                {

                    string name = File.ReadAllText(SkinPath);
                    UserLookAndFeel.Default.SkinName = name;
                    skinname = name;
                    changeColor(name);

                }
            }
            catch
            { }


            ExistDataBase = CheckDatabase("Project_DB");
            var CoonctionPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var Coonction = CoonctionPath + "\\POSConnection.txt";
           
            if (File.Exists(Coonction))
            {
                StreamReader SR = new StreamReader(Coonction);

                string[] Setting = SR.ReadToEnd().Split(new string[] { "#" }, StringSplitOptions.None);

                if (!string.IsNullOrEmpty(Setting[0]) && !string.IsNullOrEmpty(Setting[1]) && !string.IsNullOrEmpty(Setting[2]))
                {
                    DataBaseConnection.ISLocal = false;
                    DataBaseConnection.ServerName =Setting[0];
                    DataBaseConnection.UserName = Setting[1];
                    DataBaseConnection.Password = Setting[2];
                    ExistDataBase = true;

                }
                else
                {
                    DataBaseConnection.ISLocal = true;

                }
                SR.Close();
            }
            else
            {
                DataBaseConnection.ISLocal = true;

            }
           
            bool servicesRun = false;
            
            scServices = ServiceController.GetServices();

            foreach (ServiceController scTemp in scServices)
            {
                if (scTemp.ServiceName == "MSSQLSERVER" || scTemp.ServiceName == "SQLEXPRESS")
                {
                    if (scTemp.ServiceName == "MSSQLSERVER")
                    {
                        sc = new ServiceController("MSSQLSERVER");
                    }
                    else if (scTemp.ServiceName == "SQLEXPRESS")
                    {
                        sc = new ServiceController("SQLEXPRESS");

                    }
                    if (sc.Status == ServiceControllerStatus.Stopped)
                    {
                        try
                        {
                            sc.Start();
                            while (sc.Status == ServiceControllerStatus.Stopped)
                            {
                                Thread.Sleep(1000);
                                sc.Refresh();
                            }
                        }
                        catch (Exception E)
                        {
                            XtraMessageBox.Show(E.Message + "هناك مشكلة فى الاتصال بقاعدة البيانات يرجى التواصل مع المطور");
                            Application.Exit();
                        }
                    }
                    else if (sc.Status == ServiceControllerStatus.Running)
                    {
                        servicesRun = true;
                        break;
                    }

                }
            }

            if (servicesRun == true)
            {

                Process[] pname = Process.GetProcessesByName("POSProject");
                if (pname.Length > 1)
                {
                    XtraMessageBox.Show("فى نسخة تانى مفتوحة من البرنامج لو مش عارف تقفلها رستر الجهاز ");
                    
                    foreach (Process item in Process.GetProcessesByName("ITI_Project"))
                    {
                        item.Kill();
                    }
                }
                else
                {
                    Count = 0;
                    try
                    {
                        DateTime StartDate = DateTime.Now.Date;
                        String[] Dates = new string[2];


                        if (ExistDataBase)
                        {
                            try
                            {
                                Company_Info_Table ob = BussinesObj.SelectCompanyInfo();


                                PictPath = ob.Company_Logo;
                                if (File.Exists(PictPath))
                                {
                                    pictureEdit1.Image = Image.FromFile(PictPath);
                                }
                                else
                                {
                                    pictureEdit1.Image = ITI_Project.Properties.Resources.cashier;
                                }



                            }
                            catch (Exception E)
                            {



                            }
                            

                            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                            var filePath = roamingDirectory + "\\POSProject.txt";
                            byte[] ascii = Encoding.ASCII.GetBytes(BIOSserNo);
                             byte[] ascii2 = Encoding.ASCII.GetBytes(BoardProductId);

                             foreach (Byte b in ascii)
                             {

                                 TotalACAddress = TotalACAddress + int.Parse(b.ToString());
                             }
                             foreach (Byte b in ascii2)
                             {

                                 TotalBoardProductId = TotalBoardProductId + int.Parse(b.ToString());
                             }




                            var TrialLicence = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                            var TrialLicencePath = TrialLicence + "\\Trial2.txt";
                            
                           
                                if (File.Exists(TrialLicencePath))
                                {
                                    simpleButton2.Enabled = false;
                                    this.Height = 518;

                                    StreamReader SR = new StreamReader(TrialLicencePath);
                                    String DataResult = SR.ReadToEnd();
                                    try
                                    {
                                        DateTime Date = DateTime.Parse(SecurityClass.Decrypt(DataResult, "PosSystemEncraptionKey"));
                                        int result = DateTime.Compare(Date, DateTime.Now);

                                        if (result <= 0)
                                        {
                                            txtusername.Enabled = true;
                                            txtpassword.Enabled = true;
                                            simpleButton1.Enabled = true;
                                            checkEdit1.Enabled = true;
                                        }
                                        else
                                        {
                                            txtusername.Enabled = false;
                                            txtpassword.Enabled = false;
                                            simpleButton1.Enabled = false;
                                            checkEdit1.Enabled = false;
                                        }
                                    }
                                    catch { }

                                }
                                else
                                {
                                    simpleButton2.Enabled = true;
                                    this.Height = 600;

                                }
                            }

                        else
                        {
                            /// attach database 
                            /// 

                            try
                            {

                                string FileName = Path.Combine(Path.GetFullPath(@"DataBase\"));

                                SqlConnection conn = new SqlConnection("Server=.;Data Source=;Integrated Security=SSPI");
                                SqlCommand cmd = new SqlCommand("", conn);


                                cmd.CommandText = "CREATE DATABASE Project_DB ON " +
                                     "( FILENAME =  '" + FileName + "Project_DB.mdf' )," +
                                      "( FILENAME ='" + FileName + "Project_DB_log.ldf')" +
                                     "FOR ATTACH";

                                conn.Open();
                                cmd.ExecuteNonQuery();
                                cmd.Dispose();
                                conn.Close();
                                if (XtraMessageBox.Show(" تم تهيئة قواعد البيانات الخاصة بالنظام يرجى تشغيل النظام مرة اخرى") == DialogResult.OK)
                                {
                                    this.Close();
                                }
                            }
                            catch (Exception E)
                            {
                                if (E.Message.Contains("DataBase\\Project_DB.mdf\" is compressed but does not reside in a read-only database or filegroup. The file must be decompressed.\r\nCould not open File Control Bank (FCB) for invalid file ID 2 in database 'Project_DB'. Verify the file location. Execute DBCC CHECKDB.\r\nCould not open new database 'Project_DB'. CREATE DATABASE is aborted."))
                                {
                                    XtraMessageBox.Show("ملف قواعد البيانات مضغوط يرجا فك الضغط والمحاولة لاحقا");
                                    Application.Exit();
                                }
                                else
                                {
                                   // XtraMessageBox.Show(E.Message);\
                                }
                            }
                        }


                    }
                    catch (Exception E)
                    {
                        if (E.Message == "Object reference not set to an instance of an object.")
                        { }
                        else if (E.Message == "Salt is not at least eight bytes.")
                        { }
                        else
                        {
                          //  XtraMessageBox.Show(E.Message);
                        }
                    }
                }
            }
        }


     
        public static String GetWindowsServiceStatus(String SERVICENAME)
        {

            ServiceController sc = new ServiceController(SERVICENAME);

            switch (sc.Status)
            {
                case ServiceControllerStatus.Running:
                    return "Running";
                case ServiceControllerStatus.Stopped:
                    return "Stopped";
                case ServiceControllerStatus.Paused:
                    return "Paused";
                case ServiceControllerStatus.StopPending:
                    return "Stopping";
                case ServiceControllerStatus.StartPending:
                    return "Starting";
                default:
                    return "Status Changing";
            }
        }

        private bool CheckDatabase(string databaseName)
        {
            // You know it's a string, use var
            //   connetionString = @"Data Source=.;Initial Catalog=POC ;Integrated Security=True";

            var connString = "Server=.;Integrated Security=SSPI;database=master";
            // Note: It's better to take the connection string from the config file.

            var cmdText = "select count(*) from master.dbo.sysdatabases where name=@database";

            using (var sqlConnection = new SqlConnection(connString))
            {
                using (var sqlCmd = new SqlCommand(cmdText, sqlConnection))
                {
                    // Use parameters to protect against Sql Injection
                    sqlCmd.Parameters.Add("@database", System.Data.SqlDbType.NVarChar).Value = databaseName;

                    // Open the connection as late as possible
                    sqlConnection.Open();
                    // count(*) will always return an int, so it's safe to use Convert.ToInt32
                    return Convert.ToInt32(sqlCmd.ExecuteScalar()) == 1;
                }
            }

        }

        private void checkEdit1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEdit1.Checked)
            {
                txtpassword.Properties.PasswordChar = '\0';
            }
            else if (!checkEdit1.Checked)
            {
                txtpassword.Properties.PasswordChar = '*';
            }
        }

        private void log_Paint(object sender, PaintEventArgs e)
        {
            Skin currentSkin = CommonSkins.GetSkin(UserLookAndFeel.Default);
            // Color color = currentSkin.Colors.GetColor("Highlight");
            Color color = currentSkin.Colors.GetColor(DevExpress.Skins.CommonColors.DisabledControl);
            labelControl1.BackColor = color;
            labelControl2.BackColor = color;
            checkEdit1.BackColor = color;

        }

        private void log_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach (Process item in Process.GetProcessesByName("ITI_Project"))
            {
                item.Kill();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           

            string Date, Day, Month;

            if (DateTime.Now.Month < 10)
            { Month = "0" + DateTime.Now.Month; }
            else
            { Month = DateTime.Now.Month.ToString(); }
            if (DateTime.Now.Day < 10)
            {
                Day = "0" + DateTime.Now.Day;
            }
            else
            { Day = DateTime.Now.Day.ToString(); }

            Date = DateTime.Now.Year + "-" + Month + "-" + Day;
            var TrialLicence = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var TrialLicencePath = TrialLicence + "\\Trial2.txt";
            StreamWriter Sw = new StreamWriter(TrialLicencePath);
            Sw.Write(SecurityClass.Encrypt(Date, "PosSystemEncraptionKey"));
            Sw.Close();
            XtraMessageBox.Show("تم اضافة مدة تجربية 20 يوم بمجرد الانتهاء سيتم ايقاف البرنامج ");
            Application.Exit();
        }

    }
}