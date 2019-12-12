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
    public partial class SupplierUp : DevExpress.XtraEditors.XtraForm
    {
        Busniss_Logic BussinessObj;

        public SupplierUp()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();

        }

        private void SupplierUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet.Cus_Sup_Table' table. You can move, or remove it, as needed.
            this.cus_Sup_TableTableAdapter.FillByFlag(this.project_DBDataSet.Cus_Sup_Table,1);

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedValue != null)
            {
                Cus_Sup_Table Obj = BussinessObj.Supplierbyid(int.Parse(comboBox4.SelectedValue.ToString()));

                SupName.Text = Obj.Cus_Sup_Name;
                SuppEmail.Text = Obj.Cus_Sup_Email;
                SuppCopm.Text = Obj.Cus_Sup_Company;
                SuppMobile.Text = Obj.Cus_Sup_Mobile;
                SuppNote.Text = Obj.Cus_Sup_Notes;

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

            if (comboBox4.SelectedValue != null)
            {
                bool x = BussinessObj.Delete_from_cust_sup_table(int.Parse(comboBox4.SelectedValue.ToString()), 1);
                if (x == true)
                {
                    XtraMessageBox.Show("تم حذف البيانات ");
                    this.cus_Sup_TableTableAdapter.FillByFlag(this.project_DBDataSet.Cus_Sup_Table, 1);

                    SupName.Text = "";
                    SuppCopm.Text = "";
                    SuppEmail.Text = "";
                    SuppMobile.Text = "";
                    SuppNote.Text = "";
                }
                else
                {
                    XtraMessageBox.Show("توجد مشكلة فى حذف البيانات ");

                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedValue != null)
            {
                bool x = BussinessObj.update_cust_sub_table(int.Parse(comboBox4.SelectedValue.ToString()), SuppMobile.Text, SupName.Text, SuppCopm.Text.ToString(), SuppEmail.Text, SuppNote.Text, 1);
                if (x == true)
                {
                    XtraMessageBox.Show("تم تحديث البيانات ");
                    this.cus_Sup_TableTableAdapter.FillByFlag(this.project_DBDataSet.Cus_Sup_Table, 1);

                }
                else
                {
                    XtraMessageBox.Show("توجد مشكلة فى تحديث البيانات ");

                }
            }
        }
    }
}