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
    public partial class ProductAdd : DevExpress.XtraEditors.XtraForm
    {
        Busniss_Logic BussinessObj;
        string SProductID = "";
        public ProductAdd()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();

        }

        private void ProductAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet.Unite_Table' table. You can move, or remove it, as needed.
            this.unite_TableTableAdapter.Fill(this.project_DBDataSet.Unite_Table);
            // TODO: This line of code loads data into the 'project_DBDataSet.Product_Table' table. You can move, or remove it, as needed.
            this.product_TableTableAdapter.Fill(this.project_DBDataSet.Product_Table);
            // TODO: This line of code loads data into the 'project_DBDataSet.Product_Table' table. You can move, or remove it, as needed.
            this.category_TableTableAdapter.Fill(this.project_DBDataSet.Category_Table);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            int Exist = 0;
            if (checkEdit1.Checked == true)
            {
                Exist = 1;
            }
            else
            {
                Exist = 0;
            }
            bool x = false;

            if (CombUnit.SelectedValue != null && ComCatagory.SelectedValue != null)
            {

                x = BussinessObj.Product_Table_insert(ProductName.Text, Barcode.Text, int.Parse(ComCatagory.SelectedValue.ToString()), int.Parse(CombUnit.SelectedValue.ToString()), ProducDes.Text, Exist, "", ProduQue.Text.ToString(), CombProdSize.SelectedItem.ToString(), SProductID, SproduQue.Text);
            }
            if (x == true)
            {
                XtraMessageBox.Show("تم اضافة البيانات ");
                this.product_TableTableAdapter.Fill(this.project_DBDataSet.Product_Table);

                ProductName.Text = "";
                Barcode.Text = "";
                ProducDes.Text = "";
                ProduQue.Text = "";
                SproduQue.Text = "";

                try
                {
                    CombUnit.SelectedIndex = 0;
                    ComCatagory.SelectedIndex = 0;
                    CombUnit.SelectedIndex = 0;
                    CombProdSize.SelectedIndex = 0;
                }
                catch { }

            }
            else
            {
                XtraMessageBox.Show("توجد مشكلة فى اضافة البيانات ");
                ValidationClass.showStar(RTSName, x);
                ValidationClass.showStar(label1, x);
                ValidationClass.showStar(label2, x);


            }
        }
    }
}