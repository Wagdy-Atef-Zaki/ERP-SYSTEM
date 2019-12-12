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
    public partial class CustomerUp : DevExpress.XtraEditors.XtraForm
    {
        Busniss_Logic BussinessObj;
        public CustomerUp()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();

        }

        private void CustomerUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet.Cus_Sup_Table' table. You can move, or remove it, as needed.
            this.cus_Sup_TableTableAdapter.FillByFlag(this.project_DBDataSet.Cus_Sup_Table,0);
            // TODO: This line of code loads data into the 'project_DBDataSet.Lenses_Size_Table' table. You can move, or remove it, as needed.

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedValue != null)
            {
                Cus_Sup_Table Obj = BussinessObj.Customerbyid(int.Parse(comboBox4.SelectedValue.ToString()));

                CusName.Text = Obj.Cus_Sup_Name;
                CusEmail.Text = Obj.Cus_Sup_Email;
                CusCop.Text = Obj.Cus_Sup_Company;
                CusMobile.Text = Obj.Cus_Sup_Mobile;
                CusNote.Text = Obj.Cus_Sup_Notes;
                
            }

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (comboBox4.SelectedValue != null)
            {
                bool x = BussinessObj.Delete_from_cust_sup_table(int.Parse(comboBox4.SelectedValue.ToString()),0);
                if (x == true)
                {
                    XtraMessageBox.Show("تم حذف البيانات ");
                    this.cus_Sup_TableTableAdapter.FillByFlag(this.project_DBDataSet.Cus_Sup_Table, 0);
                    CusName.Text = "";
                    CusEmail.Text = "";
                    CusCop.Text = "";
                    CusMobile.Text = "";
                    CusNote.Text ="";
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
                bool x = BussinessObj.update_cust_sub_table( int.Parse(comboBox4.SelectedValue.ToString()), CusMobile.Text, CusName.Text, CusCop.Text.ToString(), CusEmail.Text,CusNote.Text, 0);
                if (x == true)
                {
                    XtraMessageBox.Show("تم تحديث البيانات ");
                    this.cus_Sup_TableTableAdapter.FillByFlag(this.project_DBDataSet.Cus_Sup_Table, 0);

                }
                else
                {
                    XtraMessageBox.Show("توجد مشكلة فى تحديث البيانات ");

                }
            }
        }
    }
}