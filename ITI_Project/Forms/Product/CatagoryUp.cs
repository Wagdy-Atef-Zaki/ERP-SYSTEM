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
    public partial class CatagoryUp : DevExpress.XtraEditors.XtraForm
    {
        Busniss_Logic Busniss_Logic;
        public CatagoryUp()
        {
            InitializeComponent();
            Busniss_Logic = new Busniss_Logic();
        }

        private void CatagoryUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet.Category_Table' table. You can move, or remove it, as needed.
            this.category_TableTableAdapter.Fill(this.project_DBDataSet.Category_Table);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
             
                Category_Table Obj = Busniss_Logic.SelectCatag(int.Parse(comboBox1.SelectedValue.ToString()));
                CataName.Text = Obj.Catagory_Name;
                CataDes.Text = Obj.Catagory_Description;
                if (Obj.Catagory_Exist == 1)
                {
                    chec.Checked = true;
                }
                else
                { chec.Checked = false; }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool x = false;

            if (comboBox1.SelectedValue != null)
            {
                int Exist = 0;
                if (chec.Checked == true)
                {
                    Exist = 1;
                }
                else
                {
                    Exist = 0;
                }

                x = Busniss_Logic.Category_Table_update(int.Parse(comboBox1.SelectedValue.ToString()), CataName.Text, CataDes.Text, Exist);

                if (x == true)
                {
                    XtraMessageBox.Show("تم تحديث البيانات ");
                    this.category_TableTableAdapter.Fill(this.project_DBDataSet.Category_Table);

                }
                else
                {
                    XtraMessageBox.Show("توجد مشكلة فى اضافة البيانات ");
                    ValidationClass.showStar(RTSName, x);

                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            bool x = false;

            if (comboBox1.SelectedValue != null)
            {

                x = Busniss_Logic.Category_Table_delete(int.Parse(comboBox1.SelectedValue.ToString()));

                if (x == true)
                {
                    comboBox1.Items.Remove(comboBox1.SelectedItem.ToString());
                    XtraMessageBox.Show("تم حذف البيانات ");
                    this.category_TableTableAdapter.Fill(this.project_DBDataSet.Category_Table);

                    CataName.Text = "";
                    CataDes.Text = "";
                    chec.Checked = false;
                }
                else
                {
                    XtraMessageBox.Show("توجد مشكلة فى حذف البيانات ");

                }
            }
        }
    }
}