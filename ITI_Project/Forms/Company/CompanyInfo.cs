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

namespace ITI_Project.Forms.Company
{
    public partial class CompanyInfo : DevExpress.XtraEditors.XtraForm
    {
        Busniss_Logic BussinessObj;
        private String AttachPath, PictPath, CompName;

        public CompanyInfo()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();
        }

        private void CompanyInfo_Load(object sender, EventArgs e)
        {
            Company_Info_Table Obj = BussinessObj.SelectCompanyInfo();

            if (Obj != null)
            {
                CName.Text = Obj.Company_Name;
                Address.Text = Obj.Company_Address;
                Catagory.Text = Obj.Company_Catagory;
                Phone1.Text = Obj.Company_Phone1;
                Phone2.Text = Obj.Company_Phone2;
                phone3.Text = Obj.Company_Phone3;
                Manager.Text = Obj.Company_Manager;
                if (!string.IsNullOrEmpty(Obj.Company_Logo))
                {
                    PicLog.Image = Image.FromFile(Obj.Company_Logo);
                    AttachPath = Obj.Company_Logo;
                }
                else
                {
                    PicLog.Image = null;

                }
            }

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            bool x = false;

            x = BussinessObj.UPDATE_info_company(CName.Text, Catagory.Text, Address.Text, Manager.Text, Phone1.Text, Phone2.Text, phone3.Text, AttachPath);
            if (x == true)
            {
                XtraMessageBox.Show("تم تحديث البيانات ");

            }
            else
            {
                XtraMessageBox.Show("توجد مشكلة فى اضافة البيانات ");
                ValidationClass.showStar(RTSName, x);
                ValidationClass.showStar(label1, x);
                ValidationClass.showStar(label2, x);
                ValidationClass.showStar(label3, x);


            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XtraOpenFileDialog OFD = new XtraOpenFileDialog();
            OFD.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            OFD.FilterIndex = 1;
            DialogResult resul = OFD.ShowDialog();
            if (resul == DialogResult.OK)
            {
                try
                {

                    AttachPath = OFD.FileName;
                    PicLog.Image = Image.FromFile(AttachPath);



                }
                catch (Exception E)
                {


                    XtraMessageBox.Show(E.Message);
                }



            }
            else if (resul == DialogResult.Cancel)
            {
                PicLog.Image = null;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            PictPath = Path.Combine(Path.GetFullPath(@"CompanyLogo.jpg"));

            PicLog.Image = null;
        }
    }
}