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
using ItI_Project;
using System.IO;

namespace ITI_Project.Forms.Settings
{
    public partial class SystemUserUp : DevExpress.XtraEditors.XtraForm
    {
        string UserImage = "", SubPath = "", NewPath = "", lastImage = "";
        Bitmap B;
        Busniss_Logic Busniss_Object;

        public SystemUserUp()
        {
            InitializeComponent();
            Busniss_Object = new Busniss_Logic();
        }

        private void SystemUserUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet.System_Users_Table' table. You can move, or remove it, as needed.
            this.system_Users_TableTableAdapter.Fill(this.project_DBDataSet.System_Users_Table);

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedValue != null)
            {
                System_Users_Table Obj = Busniss_Object.SelectUserByID(int.Parse(comboBox4.SelectedValue.ToString()));
                if (Obj != null)
                {
                    UserN.Text = Obj.Sys_Username;
                    Pass.Text = Obj.Sys_Pass;
                    if (File.Exists(Obj.Sys_User_Imagr_Path))
                    {
                        B = new Bitmap(Obj.Sys_User_Imagr_Path);
                        pictureEdit1.Image = B;
                        lastImage = Obj.Sys_User_Imagr_Path;
                    }
                    else
                    {
                        pictureEdit1.Image = Properties.Resources.user1;
                        lastImage = "";
                    }
                }
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
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

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedItem != null)
            {
                if (UserN.Text.Replace(" ", "") != ((Home)ParentForm).CurrentUser().Replace(" ", ""))
                {
                    bool x = Busniss_Object.system_user_delete(int.Parse( comboBox4.SelectedValue.ToString()));
                    if (x == true)
                    {
                        XtraMessageBox.Show("تم حذف البيانات ");
                        UserN.Text = "";
                        Pass.Text = "";
                        pictureEdit1.Image = Properties.Resources.user1;
                        try
                        {
                            if (File.Exists(lastImage))
                            {
                                B.Dispose();
                                File.Delete(lastImage);
                            }
                        }
                        catch (Exception E)
                        { }

                    }
                    else
                    {
                        XtraMessageBox.Show("توجد مشكلة فى حذف البيانات ");
                    }
                }
                else
                {
                    XtraMessageBox.Show("لا يمكن حذف المستخدم وانت تستخدمه ");

                }
            }
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
            if (Directory.Exists(SubPath))
            {
                NewPath = Path.Combine(SubPath + UserN.Text.Replace(" ", "") + "_" + StringDate + "_" + StringTime + Path.GetExtension(UserImage));

                if (!File.Exists(NewPath) && File.Exists(UserImage))
                {
                    File.Copy(UserImage, NewPath);
                }

            }
            else
            {
                Directory.CreateDirectory(SubPath);
                NewPath = Path.Combine(SubPath + UserN.Text.Replace(" ", "") + "_" + StringDate + "_" + StringTime + Path.GetExtension(UserImage));
                if (!File.Exists(NewPath) && File.Exists(UserImage))
                {
                    File.Copy(UserImage, NewPath);
                }


            }
            if (lastImage != UserImage)
            {

                try
                {
                    if (File.Exists(lastImage))
                    {
                        ((Home)ParentForm).DisablePict();
                        B.Dispose();
                        File.Delete(lastImage);
                    }
                }
                catch (Exception E)
                { }
            }
            bool x = Busniss_Object.system_user_update(int.Parse(comboBox4.SelectedValue.ToString()), UserN.Text, Pass.Text, "", NewPath);

            if (x == true)
            {
                XtraMessageBox.Show("تم تحديث البيانات ");

            }
            else
            {
                XtraMessageBox.Show("توجد مشكلة فى تحديث البيانات ");
                ValidationClass.showStar(RTSName, x);
                ValidationClass.showStar(label1, x);
            }

            if (UserN.Text.Replace(" ", "") == ((Home)ParentForm).CurrentUser().Replace(" ", ""))
            {
                B = new Bitmap(NewPath);
                pictureEdit1.Image = B;
                ((Home)ParentForm).SetNewImage(NewPath);
            }

        }
    }
}