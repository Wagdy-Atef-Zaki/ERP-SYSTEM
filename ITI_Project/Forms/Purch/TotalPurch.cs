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

namespace ITI_Project.Forms.Purch
{
    public partial class TotalPurch : DevExpress.XtraEditors.XtraForm
    {
        public TotalPurch()
        {
            InitializeComponent();
        }

        private void TotalPurch_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            UpdateDataGridView();


        }

        private void UpdateDataGridView()
        {
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "م";
            dataGridView1.Columns[1].Name = " اسم الصنف";
            dataGridView1.Columns[2].Name = " اسم المنتج";
            dataGridView1.Columns[3].Name = "عدد القطع ";
            dataGridView1.Columns[4].Name = "متوسط سعر الشراء";
            dataGridView1.Columns[5].Name = "متوسط سعر البيع";
            dataGridView1.Columns[6].Name = "اجمالى الشراء ";

        }
    }
}