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
    public partial class UniteUp : DevExpress.XtraEditors.XtraForm
    {
        Busniss_Logic BussinessObj;

        public UniteUp()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();
        }

        private void UniteUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet.Unite_Table' table. You can move, or remove it, as needed.
            this.unite_TableTableAdapter.Fill(this.project_DBDataSet.Unite_Table);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                Unite_Table Obj = BussinessObj.SelectUniteByID(int.Parse(comboBox1.SelectedValue.ToString()));

                if (Obj != null)
                {
                    UniteName.Text = Obj.Unite_Name;
                    UniteDes.Text = Obj.Unite_Description;

                }

            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                bool x = BussinessObj.unite_table_update(int.Parse(comboBox1.SelectedValue.ToString()), UniteName.Text, UniteDes.Text);
                if (x == true)
                {
                    XtraMessageBox.Show("تم تحديث البيانات ");
                    this.unite_TableTableAdapter.Fill(this.project_DBDataSet.Unite_Table);

                }
                else
                {
                    XtraMessageBox.Show("توجد مشكلة فى تحديث البيانات ");
                    ValidationClass.showStar(RTSName, x);

                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                bool x = BussinessObj.unite_table_delete(int.Parse(comboBox1.SelectedValue.ToString()));
                if (x == true)
                {
                    XtraMessageBox.Show("تم حذف البيانات ");
                    this.unite_TableTableAdapter.Fill(this.project_DBDataSet.Unite_Table);

                }
                else
                {
                    XtraMessageBox.Show("توجد مشكلة فى حذف البيانات ");
                    ValidationClass.showStar(RTSName, x);

                }
            }
        }
    }
}