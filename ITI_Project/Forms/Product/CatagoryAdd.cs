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

namespace ITI_Project.Forms.Product
{
    public partial class CatagoryAdd : DevExpress.XtraEditors.XtraForm
    {
        Busniss_Logic BussinessObj;

        public CatagoryAdd()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int Exist = 0;
            if (checkEdit1.Checked == true)
            {
                Exist = 1;
            }
            else
            {
                Exist = 0;
            }

            bool x = BussinessObj.Category_Table_insert(CataName.Text, CataDes.Text, Exist);
            if (x == true)
            {
                XtraMessageBox.Show("تم اضافة البيانات ");
                this.category_TableTableAdapter.Fill(this.project_DBDataSet.Category_Table);
                checkEdit1.Checked = false;
                CataName.Text = "";
                CataDes.Text = "";
            }
            else
            {
                XtraMessageBox.Show("توجد مشكلة فى اضافة البيانات ");
                ValidationClass.showStar(RTSName, x);

            }
        }

        private void CatagoryAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet.Category_Table' table. You can move, or remove it, as needed.
            this.category_TableTableAdapter.Fill(this.project_DBDataSet.Category_Table);
           

        }
    }
}