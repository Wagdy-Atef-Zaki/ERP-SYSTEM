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
    public partial class CustomerAccountView : DevExpress.XtraEditors.XtraForm
    {
        Busniss_Logic BussinessObj;
        public CustomerAccountView()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();
        }

        private void CustomerAccountView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet.Cus_Sup_Table' table. You can move, or remove it, as needed.
            this.cus_Sup_TableTableAdapter.FillByFlag(this.project_DBDataSet.Cus_Sup_Table,0);


        }

        private void UpdateDataGridView2()
        {
            dataGridView2.ColumnCount = 7;
            dataGridView2.Columns[0].Name = "م";
            dataGridView2.Columns[1].Name = " معرف الفاتورة";
            dataGridView2.Columns[2].Name = "اجمالى الفاتورة ";
            dataGridView2.Columns[3].Name = "المدفوع";
            dataGridView2.Columns[4].Name = "المتبقى";
            dataGridView2.Columns[5].Name = "التاريخ";
            dataGridView2.Columns[6].Name = "ملاحظات";

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "عرض الفاتورة";
            btn.Name = "Button";
            btn.Text = "عرض ";
            btn.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(btn);
        }
        public void UpdateDataGridView()
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "م";
            dataGridView1.Columns[1].Name = " معرف الفاتورة";
            dataGridView1.Columns[2].Name = "اجمالى الفاتورة ";
            dataGridView1.Columns[3].Name = "المدفوع";
            dataGridView1.Columns[4].Name = "المتبقى";
            dataGridView1.Columns[5].Name = "التاريخ";
            dataGridView1.Columns[6].Name = "ملاحظات";

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "عرض الفاتورة";
            btn.Name = "Button";
            btn.Text = "عرض ";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);


        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox4.SelectedValue!=null)
            {
            Cus_Sup_Table Obj = BussinessObj.Customerbyid(int.Parse(comboBox4.SelectedValue.ToString()));
                CusName.Text=Obj.Cus_Sup_Name;
                CusComp.Text=Obj.Cus_Sup_Company;
                CusEmail.Text=Obj.Cus_Sup_Email;
                CusNotes.Text=Obj.Cus_Sup_Notes;
                CusMobile.Text=Obj.Cus_Sup_Mobile;

            }
        }
    }
}