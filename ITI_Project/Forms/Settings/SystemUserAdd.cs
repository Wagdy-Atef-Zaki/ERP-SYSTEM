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
using ItI_Project;

namespace ITI_Project.Forms.Settings
{
    public partial class SystemUserAdd : DevExpress.XtraEditors.XtraForm
    {
        string UserImage = "", SubPath = "", NewPath = "";
        Busniss_Logic Busniss_Object;
        public SystemUserAdd()
        {
            InitializeComponent();
            Busniss_Object = new Busniss_Logic();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string StringDate, Day, Month;
            if (DateTime.Now.Month < 10)
            { Month = "0" + DateTime.Now.Month; }
            else
            { Month = DateTime.Now.Month.ToString(); }

            if (DateTime.Now.Day < 10)
            { Day = "0" + DateTime.Now.Day; }
            else
            { Day = DateTime.Now.Day.ToString(); }

            StringDate = DateTime.Now.Year + "-" + Month + "-" + Day;

            string StringTime, Minute, Second, Hour;
            if (DateTime.Now.Hour < 10)
            { Hour = "0" + DateTime.Now.Hour; }
            else
            { Hour = DateTime.Now.Hour.ToString(); }
            if (DateTime.Now.Minute < 10)
            { Minute = "0" + DateTime.Now.Minute; }
            else
            { Minute = DateTime.Now.Minute.ToString(); }
            if (DateTime.Now.Second < 10)
            { Second = "0" + DateTime.Now.Second; }
            else
            { Second = DateTime.Now.Second.ToString(); }
            StringTime = Hour + "-" + Minute + "-" + Second;


            if (File.Exists(SubPath))
            {
                NewPath = Path.Combine(SubPath + UserN.Text.Replace(" ", "") + "_" + StringDate + "_" + StringTime + Path.GetExtension(UserImage));

                if (!File.Exists(NewPath))
                {
                    File.Copy(UserImage, NewPath);
                }

            }
            else
            {
                Directory.CreateDirectory(SubPath);
                NewPath = Path.Combine(SubPath + UserN.Text.Replace(" ", "") + "_" + StringDate + "_" + StringTime + Path.GetExtension(UserImage));

                if (!File.Exists(NewPath))
                {
                    File.Copy(UserImage, NewPath);
                }
            }

            bool x = Busniss_Object.system_user_insert(UserN.Text, Pass.Text, "", NewPath);

            if (x == true)
            {
                XtraMessageBox.Show("تم اضافة البيانات ");

            }
            else
            {
                XtraMessageBox.Show("توجد مشكلة فى اضافة البيانات ");
                ValidationClass.showStar(RTSName, x);
                ValidationClass.showStar(label1, x);


            }
        }

        private void SystemUserAdd_Load(object sender, EventArgs e)
        {
            Company_Info_Table Obj = Busniss_Object.SelectCompanyInfo();

            if (Obj.MediaPath != null)
            {

                SubPath = Path.Combine(Obj.MediaPath + @"Media\SystemMedia\\Users\\");

            }
            else
            {
                SubPath = Path.Combine(Path.GetFullPath(@"Media\SystemMedia\\Users\\"));
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            OpenFile.Multiselect = false;
            OpenFile.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                pictureEdit1.Image = Image.FromFile(OpenFile.FileName);
                UserImage = OpenFile.FileName;

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            pictureEdit1.Image = Properties.Resources.user1;
            NewPath = "";
        }
    }
}