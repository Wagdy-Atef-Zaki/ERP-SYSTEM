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
    public partial class UniteAdd : DevExpress.XtraEditors.XtraForm
    {
        Busniss_Logic BussinessObj;

        public UniteAdd()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();

        }

        private void UniteAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet.Unite_Table' table. You can move, or remove it, as needed.
            this.unite_TableTableAdapter.Fill(this.project_DBDataSet.Unite_Table);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool x = BussinessObj.unite_table_insert(UniteName.Text, UniteDes.Text);
            if (x == true)
            {
                XtraMessageBox.Show("تم اضافة البيانات ");
                this.unite_TableTableAdapter.Fill(this.project_DBDataSet.Unite_Table);
                UniteName.Text = "";
                UniteDes.Text = "";
            }
            else
            {
                XtraMessageBox.Show("توجد مشكلة فى اضافة البيانات ");
                ValidationClass.showStar(RTSName, x);


            }
        }
    }
}