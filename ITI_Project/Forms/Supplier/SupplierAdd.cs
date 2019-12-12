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

namespace ITI_Project.Forms.Supplier
{
    public partial class SupplierAdd : DevExpress.XtraEditors.XtraForm
    {
        Busniss_Logic BussinessObj;

        public SupplierAdd()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();
        }

        private void SupplierAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet.Cus_Sup_Table' table. You can move, or remove it, as needed.
            this.cus_Sup_TableTableAdapter.FillByFlag(this.project_DBDataSet.Cus_Sup_Table,1);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //sippler take 1

            bool x = BussinessObj.insert_into_Cus_Sup_Table(SumMobile.Text, SupName.Text, SupComp.Text, SupEmail.Text, SupNotes.Text, 0,1);
            if (x == true)
            {
                XtraMessageBox.Show("تم اضافة البيانات ");
                this.cus_Sup_TableTableAdapter.FillByFlag(this.project_DBDataSet.Cus_Sup_Table, 1);
                SumMobile.Text = "";
                SupName.Text = "";
                SupEmail.Text = "";
                SupNotes.Text = "";
                SupComp.Text = "";

            }
            else
            {
                XtraMessageBox.Show("توجد مشكلة فى اضافة البيانات ");
                ValidationClass.showStar(RTSName, x);
                ValidationClass.showStar(label1, x);

            }
        }
    }
}