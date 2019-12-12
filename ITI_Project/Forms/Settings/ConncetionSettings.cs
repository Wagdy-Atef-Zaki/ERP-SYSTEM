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

namespace ITI_Project.Forms.Settings
{
    public partial class ConncetionSettings : DevExpress.XtraEditors.XtraForm
    {
        public ConncetionSettings()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var filePath = roamingDirectory + "\\POSConnection.txt";
            if (radioButton1.Checked == true)
            {
                File.Delete(filePath);
            }
            else if (radioButton2.Checked == true)
            {

                StreamWriter SW = new StreamWriter(filePath);

                SW.Write(ServerName.Text + "#" + UserName.Text + "#" + Password.Text);
                SW.Close();
            }
            XtraMessageBox.Show("تم اضافة بيانات الاتصال");
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = false;
            ServerName.Text = "";
            UserName.Text = "";
            Password.Text = "";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;

        }

        private void ConncetionSettings_Load(object sender, EventArgs e)
        {

            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var filePath = roamingDirectory + "\\POSConnection.txt";
            if (File.Exists(filePath))
            {
                StreamReader SR = new StreamReader(filePath);

                string[] Setting = SR.ReadToEnd().Split(new string[] { "#" }, StringSplitOptions.None);
                SR.Close();
                radioButton2.Checked = true;
                ServerName.Text = Setting[0];
                UserName.Text = Setting[1];
                Password.Text = Setting[2];

            }
            else
            {
                radioButton1.Checked = true;
                ServerName.Text = "";
                UserName.Text = "";
                Password.Text = "";
            }
        }
    }
}