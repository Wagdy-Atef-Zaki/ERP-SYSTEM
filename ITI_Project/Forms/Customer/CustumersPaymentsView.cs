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

namespace ITI_Project.Forms.Customer
{
    public partial class CustumersPaymentsView : DevExpress.XtraEditors.XtraForm
    {
        public CustumersPaymentsView()
        {
            InitializeComponent();
        }
        private void UpdateDataGridView2()
        {
            dataGridView2.ColumnCount = 6;
            dataGridView2.Columns[0].Name = "م";
            dataGridView2.Columns[1].Name = " اسم العميل";
            dataGridView2.Columns[2].Name = " رقم العميل";
            dataGridView2.Columns[3].Name = "اجمالى الفواتير ";
            dataGridView2.Columns[4].Name = " اجمالى المدفوع";
            dataGridView2.Columns[5].Name = "المتبقى اجمالى";

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "عرض الفواتير";
            btn.Name = "Button";
            btn.Text = "عرض ";
            btn.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(btn);
        }
        public void UpdateDataGridView()
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "م";
            dataGridView1.Columns[1].Name = " اسم العميل";
            dataGridView1.Columns[2].Name = " رقم العميل";
            dataGridView1.Columns[3].Name = "اجمالى الفواتير ";
            dataGridView1.Columns[4].Name = " اجمالى المدفوع";
            dataGridView1.Columns[5].Name = "المتبقى اجمالى";

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "عرض الفواتير";
            btn.Name = "Button";
            btn.Text = "عرض ";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);


        }
        private void CustumersPaymentsView_Load(object sender, EventArgs e)
        {

        }
    }
}