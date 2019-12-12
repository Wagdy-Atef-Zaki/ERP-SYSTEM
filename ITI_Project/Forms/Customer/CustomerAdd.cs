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

namespace ITI_Project.Forms.Customer
{
    public partial class CustomerAdd : DevExpress.XtraEditors.XtraForm
    {
        Busniss_Logic BussinessObj;
        public CustomerAdd()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();
        }

        private void CustomerAdd_Load(object sender, EventArgs e)
        {
            //user 0
            // TODO: This line of code loads data into the 'project_DBDataSet.Cus_Sup_Table' table. You can move, or remove it, as needed.
            this.cus_Sup_TableTableAdapter.FillByFlag(this.project_DBDataSet.Cus_Sup_Table, 0);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool x = BussinessObj.insert_into_Cus_Sup_Table(CusMobile.Text, CusName.Text, CusComp.Text, CusEmail.Text, CusNotes.Text, 0, 0);
            if (x == true)
            {
                XtraMessageBox.Show("تم اضافة البيانات ");
                this.cus_Sup_TableTableAdapter.FillByFlag(this.project_DBDataSet.Cus_Sup_Table, 0);
                CusMobile.Text = "";
                CusName.Text = "";
                CusEmail.Text = "";
                CusNotes.Text = "";
                CusComp.Text = "";

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