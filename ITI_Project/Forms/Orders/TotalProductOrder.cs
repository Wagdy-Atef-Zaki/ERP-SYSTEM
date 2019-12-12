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

namespace ITI_Project.Forms.Orders
{
    public partial class TotalProductOrder : DevExpress.XtraEditors.XtraForm
    {
        public TotalProductOrder()
        {
            InitializeComponent();
        }

        private void TotalProductOrder_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            UpdateDataGridView();
        }
        public void UpdateDataGridView()
        {
            dataGridView1.ColumnCount = 6;
            dataGridView1.Columns[0].Name = "م";
            dataGridView1.Columns[1].Name = " اسم الصنف";
            dataGridView1.Columns[2].Name = " اسم المنتج";
            dataGridView1.Columns[3].Name = "عدد القطع ";
            dataGridView1.Columns[4].Name = "اجمالى الخصم";
            dataGridView1.Columns[5].Name = "اجمالى الفواتير";

        }
    }
}