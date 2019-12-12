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
    public partial class ProductUp : DevExpress.XtraEditors.XtraForm
    {
        Busniss_Logic BussinessObj;
        string SProductID = "";
        public ProductUp()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();
        }

        private void ProductUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet1.Unite_Table' table. You can move, or remove it, as needed.
            this.unite_TableTableAdapter.Fill(this.project_DBDataSet1.Unite_Table);
            // TODO: This line of code loads data into the 'project_DBDataSet1.Category_Table' table. You can move, or remove it, as needed.
            this.category_TableTableAdapter.Fill(this.project_DBDataSet1.Category_Table);
            // TODO: This line of code loads data into the 'project_DBDataSet.Product_Table' table. You can move, or remove it, as needed.
            this.product_TableTableAdapter.Fill(this.project_DBDataSet.Product_Table);

        }

        private void textEdit7_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textEdit7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(textEdit7.Text))
                {
                    Product_Table Obj =BussinessObj.Product_tb_search_by_Barecode(textEdit7.Text);

                    if (Obj != null)
                    {
                        ProductName.Text = Obj.Product_Name;
                        ProducDes.Text = Obj.Description;

                        ComCatagory.SelectedValue = Obj.Catagory_ID;
                        Barcode.Text = Obj.BareCode;
                        if (Obj.Product_Size == "صغرى")
                        {
                            groupControl2.Visible = false;
                            SproduQue.Text = "";
                            CombProdSize.SelectedIndex = 0;

                        }
                        else if (Obj.Product_Size == "كبرى")
                        {
                            groupControl2.Visible = true;
                            CombProdSize.SelectedIndex = 1;
                            SComProdu.SelectedValue = Obj.SProduct_ID;
                            SproduQue.Text = Obj.SQuantity;

                        }
                        
                        CombUnit.SelectedValue = Obj.Unite_ID;
                      
                        ProduQue.Text = Obj.AlarmQuantity.ToString();

                        if (Obj.Product_Exist == 1)
                        { checkEdit1.Checked = true; }
                        else if (Obj.Product_Exist == 0)
                        {
                            checkEdit1.Checked = false;
                        }


                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {

                Product_Table Obj = BussinessObj.Product_tb_search_by_ID(int.Parse(comboBox1.SelectedValue.ToString()));

                if (Obj != null)
                {
                    ProductName.Text = Obj.Product_Name;
                    ProducDes.Text = Obj.Description;
                    ComCatagory.SelectedValue = Obj.Catagory_ID;
                    Barcode.Text = Obj.BareCode;
                    if (Obj.Product_Size == "صغرى")
                    {
                        groupControl2.Visible = false;
                        SproduQue.Text = "";
                        CombProdSize.SelectedIndex = 0;

                    }
                    else if (Obj.Product_Size == "كبرى")
                    {
                        groupControl2.Visible = true;
                        CombProdSize.SelectedIndex = 1;
                        SComProdu.SelectedValue = Obj.SProduct_ID;
                        SproduQue.Text = Obj.SQuantity;

                    }

                   
                    CombUnit.SelectedValue = Obj.Unite_ID;
                    
                    ProduQue.Text = Obj.AlarmQuantity.ToString();

                    if (Obj.Product_Exist == 1)
                    { checkEdit1.Checked = true; }
                    else if (Obj.Product_Exist == 0)
                    {
                        checkEdit1.Checked = false;
                    }


                }

            }
        
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            bool x = false;

            if (textEdit7.Text == Barcode.Text)
            {
                x = BussinessObj.Product_Table_deleteByBarcode(textEdit7.Text);
            }
            else
            {
                if (comboBox1.SelectedValue != null)
                {
                    x = x = BussinessObj.Product_Table_deleteByID(int.Parse(comboBox1.SelectedValue.ToString()));
                }

            }


            if (x == true)
            {
                comboBox1.Items.Remove(comboBox1.SelectedItem.ToString());
                XtraMessageBox.Show("تم حذف البيانات ");
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
                XtraMessageBox.Show("توجد مشكلة فى حذف البيانات ");

            }
        }

        private void SComProdu_DropDown(object sender, EventArgs e)
        {

        }

        private void SProductBar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!string.IsNullOrEmpty(SProductBar.Text))
                {
                    Product_Table Obj = BussinessObj.Product_tb_search_by_Barecode(SProductBar.Text);

                    if (Obj != null)
                    {
                        SComProdu.SelectedValue = Obj.Product_ID;

                    }
                }
            }
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
                if (textEdit7.Text == Barcode.Text)
                {
                    if (CombProdSize.SelectedIndex == 0)
                    {
                        x = BussinessObj.Product_Table_updateByBarcode(textEdit7.Text, ProductName.Text, int.Parse(ComCatagory.SelectedValue.ToString()), int.Parse(CombUnit.SelectedValue.ToString()), ProducDes.Text, Exist, "", ProduQue.Text.ToString(), CombProdSize.SelectedItem.ToString(), "", "");
                    }
                    else
                    {
                        x = BussinessObj.Product_Table_updateByBarcode(textEdit7.Text, ProductName.Text, int.Parse(ComCatagory.SelectedValue.ToString()), int.Parse(CombUnit.SelectedValue.ToString()), ProducDes.Text, Exist, "", ProduQue.Text.ToString(), CombProdSize.SelectedItem.ToString(), SComProdu.SelectedValue.ToString(), SproduQue.Text);

                    }
                }
                else
                {
                    if (CombProdSize.SelectedIndex == 0)
                    {
                        x = BussinessObj.Product_Table_updateByProductID(int.Parse(comboBox1.SelectedValue.ToString()), ProductName.Text, Barcode.Text, int.Parse(ComCatagory.SelectedValue.ToString()), int.Parse(CombUnit.SelectedValue.ToString()), ProducDes.Text, Exist, "", ProduQue.Text.ToString(), CombProdSize.SelectedItem.ToString(), "", "");
                    }
                    else
                    {
                        x = BussinessObj.Product_Table_updateByProductID(int.Parse(comboBox1.SelectedValue.ToString()), ProductName.Text, Barcode.Text, int.Parse(ComCatagory.SelectedValue.ToString()), int.Parse(CombUnit.SelectedValue.ToString()), ProducDes.Text, Exist, "", ProduQue.Text.ToString(), CombProdSize.SelectedItem.ToString(), SComProdu.SelectedValue.ToString(), SproduQue.Text);

                    }

                }
            }
            


            if (x == true)
            {
                XtraMessageBox.Show("تم تحديث البيانات ");
                this.product_TableTableAdapter.Fill(this.project_DBDataSet.Product_Table);

            }
            else
            {
                XtraMessageBox.Show("توجد مشكلة فى تحديث البيانات ");
                ValidationClass.showStar(RTSName, x);
                ValidationClass.showStar(label1, x);
                ValidationClass.showStar(label2, x);


            }
        }
    }
}