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

namespace ITI_Project.Forms.Company
{
    public partial class MediaPath : DevExpress.XtraEditors.XtraForm
    {
        Busniss_Logic BussinessObj;

        public MediaPath()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(CompanyName))
            {
                bool x = BussinessObj.UPDATE_MediaPath(Path.Text);
                if (x == true)
                { XtraMessageBox.Show("تم تحديث البيانات "); }
                else
                { XtraMessageBox.Show("توجد مشكلة فى تحديث البيانات "); }
            }
        }

        private void btnBackBrow_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Path.Text = SaveFile.SelectedPath;
                }
                catch (Exception E)
                {
                    XtraMessageBox.Show(E.Message);
                }

            }
        }

        private void MediaPath_Load(object sender, EventArgs e)
        {
            Company_Info_Table Obj = BussinessObj.SelectCompanyInfo();

            if (Obj != null)
            {
                Path.Text = Obj.MediaPath;
            }
        }
    }
}