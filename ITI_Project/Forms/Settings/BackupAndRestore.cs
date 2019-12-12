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
using System.Data.SqlClient;
using ItI_Project;

namespace ITI_Project.Forms.Settings
{
    public partial class BackupAndRestore : DevExpress.XtraEditors.XtraForm
    {
        string FilePa = "", SQL = "", MediaPath = "";
        private SqlCommand command;

        public BackupAndRestore()
        {
            InitializeComponent();
        }

        private void BackupAndRestore_Load(object sender, EventArgs e)
        {
            BrowseBackupLoca.Filter = "Backup file (*.bak) | *.bak";


            if (BrowseBackupLoca.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    FilePa = BackupResPath.Text = BrowseBackupLoca.FileName;


                    BtnBackupRest.Enabled = true;

                }
                catch (Exception E)
                {
                    XtraMessageBox.Show(E.Message);
                }

            }
        }

        private void btnBackBrow_Click(object sender, EventArgs e)
        {
            String Name = "POS_System_Backup" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;

            SaveFile.FileName = Name.Replace("12:00:00 Am", "").Replace("12:00:00 ص", "");

            SaveFile.Filter = "Backup file (*.bak) | *.bak";

            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    BackupPath.Text = SaveFile.FileName.Replace("12:00:00 Am", "").Replace("12:00:00 ص", "");
                    BtnBack.Enabled = true;

                }
                catch (Exception E)
                {
                    XtraMessageBox.Show(E.Message);
                }

            }
            else
            {
                BtnBack.Enabled = false;
            }
        }

        private void BtnBackupRest_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(BackupResPath.Text))
            {
                try
                {
                    DataBaseConnection.StartConn();


                    string UseMaster = "USE master";
                    SqlCommand UseMasterCommand = new SqlCommand(UseMaster, DataBaseConnection.Connection());
                    UseMasterCommand.ExecuteNonQuery();

                    string Alter1 = @"ALTER DATABASE [Project_DB] SET Single_User WITH Rollback Immediate";
                    SqlCommand Alter1Cmd = new SqlCommand(Alter1, DataBaseConnection.Connection());
                    Alter1Cmd.ExecuteNonQuery();

                    string Restore = string.Format("Restore database Project_DB from disk= '" + BackupResPath.Text.ToString() + "' WITH REPLACE");
                    SqlCommand RestoreCmd = new SqlCommand(Restore, DataBaseConnection.Connection());
                    RestoreCmd.ExecuteNonQuery();

                    string Alter2 = @"ALTER DATABASE [Project_DB] SET Multi_User";
                    SqlCommand Alter2Cmd = new SqlCommand(Alter2, DataBaseConnection.Connection());
                    Alter2Cmd.ExecuteNonQuery();


                }

                catch (Exception)
                {
                    XtraMessageBox.Show("توجد مشكلة اثناء استرجاع قاعدة البيانات");
                }
                finally
                {
                    DataBaseConnection.CloseConn();
                }
            }
            else
            {
                XtraMessageBox.Show("يرجى تحديد مكان الملف قبل محاولة الاسترجاع");
            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            try
            {
                DataBaseConnection.StartConn();

                if (!string.IsNullOrEmpty(BackupPath.Text))
                {
                    SQL = "BACKUP DATABASE Project_DB  TO DISK ='" + BackupPath.Text.Replace("12:00:00 Am", "").Replace("12:00:00 ص", "") + "'";

                    command = new SqlCommand(SQL, DataBaseConnection.Connection());
                    command.ExecuteReader();

                    XtraMessageBox.Show("تم عمل نسخة احتياطية بنجاح  ");

                }
                else
                {
                    XtraMessageBox.Show("يرجى تحديد موقع تخزين النسخة الاحتياطية اولا ");
                }
            }
            catch (Exception E)
            {
                XtraMessageBox.Show(E.Message);
            }
            finally
            {
                command.Dispose();
                DataBaseConnection.CloseConn();
            }
        }
    }
}