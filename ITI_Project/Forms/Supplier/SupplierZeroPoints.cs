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
    public partial class SupplierZeroPoints : DevExpress.XtraEditors.XtraForm
    {
        Busniss_Logic BussinessObj;
        List<Purchases_Table> Lis;
        private string[] row;

        public SupplierZeroPoints()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();
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
            if (comboBox4.SelectedValue != null)
            {
                Cus_Sup_Table Obj = BussinessObj.SupplierbyMobile(comboBox4.SelectedValue.ToString());
                CusName.Text = Obj.Cus_Sup_Name;
                CusComp.Text = Obj.Cus_Sup_Company;
                CusEmail.Text = Obj.Cus_Sup_Email;
                CusNotes.Text = Obj.Cus_Sup_Notes;
                CusMobile.Text = Obj.Cus_Sup_Mobile;

                Lis = BussinessObj.SellectPurchZeroByMobile(comboBox4.SelectedValue.ToString());

            }

            dataGridView1.Rows.Clear();
            UpdateDataGridView();
            dataGridView2.Rows.Clear();
            UpdateDataGridView2();

            if (Lis != null)
            {
                int x = dataGridView1.Rows.Count + 1;
                decimal Total = 0;
                foreach (Purchases_Table item in Lis)
                {
                    row = new string[] { (x++).ToString(),item.Purchases_ID.ToString(),item.Purch_Total.ToString(),item.Purch__Pauid.ToString(),item.Purch_Remin.ToString(),item.Addation_Date.ToString().Replace("12:00:00 Am", "").Replace("12:00:00 ص", ""),item.Notes};
                    dataGridView1.Rows.Add(row);
                    Total = Total+ item.Purch_Total;
                }
                textEdit1.Text = Total.ToString();
               

            }

        }

        private void SupplierZeroPoints_Load(object sender, EventArgs e)
        {
            this.cus_Sup_TableTableAdapter.FillByFlag(this.project_DBDataSet.Cus_Sup_Table, 1);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                int ID = int.Parse(dataGridView1[1, (e.RowIndex)].Value.ToString());
                //select order Id From Row and pass it as parameter 
                PurchRec OrederObj = new PurchRec(ID, CusMobile.Text);
                OrederObj.Show();
            }
        }
    }
}