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

namespace ITI_Project.Forms.Purch
{
    public partial class PurchesAdd : DevExpress.XtraEditors.XtraForm
    {
        private string ExpireOrNot = "لا توجد صلاحية", ExpirDate = "";
        private List<String> ProductNames = new List<String>();
        private List<int> ProductIDs = new List<int>();
        private int  RowID = 0;
        private float orderTotal = 0;
        private float total;
        private string[] row;
        private bool getfunction = false;
        string UserId="0";
        PurchRec PurchRec;
        Busniss_Logic BussinessObj;

        public PurchesAdd()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();
        }

        private void PurchesAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet.Cus_Sup_Table' table. You can move, or remove it, as needed.
            this.cus_Sup_TableTableAdapter.FillByFlag(this.project_DBDataSet.Cus_Sup_Table, 1);
            // TODO: This line of code loads data into the 'project_DBDataSet.Product_Table' table. You can move, or remove it, as needed.
            this.product_TableTableAdapter.Fill(this.project_DBDataSet.Product_Table);
            dataGridView1.ColumnCount = 11;
            dataGridView1.Columns[0].Name = "م";
            dataGridView1.Columns[1].Name = "اسم الصنف";
            dataGridView1.Columns[2].Name = "اسم المنتج";
            dataGridView1.Columns[3].Name = "تاريخ الانتهاء";
            dataGridView1.Columns[4].Name = "الصلاحية";
            dataGridView1.Columns[5].Name = "سعر الشراء";
            dataGridView1.Columns[6].Name = "سعر قطاعى ";
            dataGridView1.Columns[7].Name = "سعر جملة ";
            dataGridView1.Columns[8].Name = " الكمية";
            dataGridView1.Columns[9].Name = "اجمالى الشراء ";
            dataGridView1.Columns[10].Name = " معرف المنتج ";

            dataGridView1.Columns[10].Visible = false;
            dateEdit1.DateTime = DateTime.Now;
            Date2.DateTime = DateTime.Now;
            comboBox3.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                if (ValidationClass.ISDigit(SellingPrice.Text) && ValidationClass.ISDigit(Quantity.Text) && ValidationClass.ISDigit(Pric1.Text))
                {
                    AddProduct(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(Quantity.Text), float.Parse(SellingPrice.Text), float.Parse(Pric1.Text), Price2.Text);
                }
                else
                {
                    XtraMessageBox.Show("يرجى اضافة بيانات الكمية والاسعار قبل محاولة الاضافة");
                }
            }
        }


        public void AddProduct(int ProductId, int Quntity, float SellingPrice, float Price1, string Price2)
        {
            Product_Table Obj = BussinessObj.Product_tb_search_by_ID(ProductId);
            if (Obj != null)
            {
                total = Quntity * SellingPrice;
                if (dataGridView1.RowCount == 0)
                {
                    RowID = dataGridView1.RowCount + 1;
                    row = new string[] { (RowID++).ToString(), Obj.Category_Table.Catagory_Name, Obj.Product_Name, ExpirDate, ExpireOrNot, SellingPrice.ToString(), Price1.ToString(), Price2.ToString(), Quantity.Text, total.ToString(), ProductId.ToString() };
                    dataGridView1.Rows.Add(row);
                    if (!ProductNames.Contains(comboBox1.Text))
                    {
                        ProductNames.Add(comboBox1.Text);
                    }
                }
                else
                {
                    if (ProductNames.Contains(comboBox1.Text))
                    {
                        for (int i = 0; i < ProductNames.Capacity; i++)
                        {
                            if (ProductNames[i] == comboBox1.Text)
                            {
                                dataGridView1[5, (i)].Value = SellingPrice.ToString();
                                dataGridView1[6, (i)].Value = Price1.ToString();
                                dataGridView1[7, (i)].Value = Price2.ToString();
                                dataGridView1[8, (i)].Value = (int.Parse(dataGridView1[8, (i)].Value.ToString()) + Quntity).ToString();
                                dataGridView1[9, (i)].Value = (int.Parse(dataGridView1[8, (i)].Value.ToString()) * float.Parse(dataGridView1[5, (i)].Value.ToString())).ToString();
                                break;
                            }
                        }
                    }
                    else
                    {
                        RowID = dataGridView1.RowCount + 1;
                        row = new string[] { (RowID++).ToString(), Obj.Category_Table.Catagory_Name, Obj.Product_Name, ExpirDate, ExpireOrNot, SellingPrice.ToString(), Price1.ToString(), Price2.ToString(), Quantity.Text, total.ToString(), ProductId.ToString() };
                        dataGridView1.Rows.Add(row);
                        if (!ProductNames.Contains(comboBox1.Text))
                        {
                            ProductNames.Add(comboBox1.Text);
                        }
                    }
                }

            }


            orderTotal = 0;
            for (int r = 0; r < dataGridView1.RowCount; r++)
            {
                orderTotal = orderTotal + float.Parse((dataGridView1[9, r].Value.ToString()));

            }
            textEdit6.Text = orderTotal.ToString();
            if (ValidationClass.ISDigit(Pauid.Text))
            {
                float Paid = float.Parse(Pauid.Text);
                Remin.Text = (orderTotal - Paid).ToString();
            }


        }

        private void chec_CheckedChanged(object sender, EventArgs e)
        {
            if (chec.Checked == true)
            {
                Date2.Enabled = false;
                ExpireOrNot = "لا توجد صلاحية";
                ExpirDate = "";
            }
            else
            {
                Date2.Enabled = true;
                ExpireOrNot = "توجد";

                string Date, Day, Month;

                if (Date2.DateTime.Month < 10)
                {
                    Month = "0" + Date2.DateTime.Month;
                }
                else
                { Month = Date2.DateTime.Month.ToString(); }

                if (Date2.DateTime.Day < 10)
                {
                    Day = "0" + Date2.DateTime.Day;
                }
                else
                { Day = Date2.DateTime.Day.ToString(); }

                Date = Date2.DateTime.Year + "-" + Month + "-" + Day;

                ExpirDate = Date.Replace("12:00:00 AM", "");

            }
        }

        private void Barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ValidationClass.StringNotEmpty(Barcode.Text))
                {
                    Product_Table Ob = BussinessObj.Product_tb_search_by_Barecode(Barcode.Text);

                    if (ValidationClass.ISDigit(SellingPrice.Text) && ValidationClass.ISDigit(Quantity.Text) && ValidationClass.ISDigit(Pric1.Text))
                    {
                        AddProduct(Ob.Product_ID, int.Parse(Quantity.Text), float.Parse(SellingPrice.Text), float.Parse(Pric1.Text), Price2.Text);
                    }
                    else
                    {
                        XtraMessageBox.Show("يرجى اضافة بيانات الكمية والاسعار قبل محاولة الاضافة");
                    }
                }
                Barcode.Text = "";
            }
        }

        private void Pauid_EditValueChanged(object sender, EventArgs e)
        {
            if (ValidationClass.ISDigit(Pauid.Text))
            {
                Remin.Text = (float.Parse(Pauid.Text) - orderTotal).ToString();

                if (float.Parse(Pauid.Text) > orderTotal)
                {
                    Remin.BackColor = Color.Green;
                }
                else if (float.Parse(Pauid.Text) < orderTotal)
                {
                    Remin.BackColor = Color.Red;

                }
                else
                {
                    Remin.BackColor = SystemColors.Control;
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    orderTotal = orderTotal - float.Parse(dataGridView1[9, this.dataGridView1.SelectedRows[0].Index].Value.ToString());
                    textEdit6.Text = orderTotal.ToString();
                    ProductNames.Remove(dataGridView1[2, this.dataGridView1.SelectedRows[0].Index].Value.ToString());
                    dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);

                }
                if (ValidationClass.ISDigit(Pauid.Text))
                {
                        float Paid = float.Parse(Pauid.Text);
                        Remin.Text = (orderTotal - Paid).ToString();
                }
            }
            else
            {
                XtraMessageBox.Show("يرجى تحديد المنتج اولا");

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (simpleButton3.Text == "تعديل بيانات منتج ")
            {
                simpleButton3.Text = "حفظ البيانات";
                CQuen.Enabled = true;
                CSel.Enabled = true;
                CPrice1.Enabled = true;
                Cpric2.Enabled = true;

            }
            else if (simpleButton3.Text == "حفظ البيانات")
            {
                if (ValidationClass.ISDigit(CQuen.Text))
                {
                    dataGridView1[8, this.dataGridView1.SelectedRows[0].Index].Value = CQuen.Text;
                }
                if (ValidationClass.StringNotEmpty(CSel.Text))
                {
                    dataGridView1[5, this.dataGridView1.SelectedRows[0].Index].Value = CSel.Text;

                }
                if (ValidationClass.StringNotEmpty(CPrice1.Text))
                {
                    dataGridView1[6, this.dataGridView1.SelectedRows[0].Index].Value = CPrice1.Text;

                }
                if (ValidationClass.StringNotEmpty(Cpric2.Text))
                {
                    dataGridView1[7, this.dataGridView1.SelectedRows[0].Index].Value = Cpric2.Text;

                }
                CQuen.Enabled = false;
                CSel.Enabled = false;
                CPrice1.Enabled = false;
                Cpric2.Enabled = false;
                simpleButton3.Text = "تعديل بيانات منتج ";


            }
            dataGridView1[9, this.dataGridView1.SelectedRows[0].Index].Value = (int.Parse(dataGridView1[8, this.dataGridView1.SelectedRows[0].Index].Value.ToString()) * float.Parse(dataGridView1[5, this.dataGridView1.SelectedRows[0].Index].Value.ToString())).ToString();

            orderTotal = 0;
            for (int r = 0; r < dataGridView1.RowCount; r++)
            {
                orderTotal = orderTotal + float.Parse((dataGridView1[9, r].Value.ToString()));

            }
            textEdit6.Text = orderTotal.ToString();
            if (ValidationClass.ISDigit(Pauid.Text))
            {
                float Paid = float.Parse(Pauid.Text);
                Remin.Text = (orderTotal - Paid).ToString();
            }
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            bool valid1=false,valid2=false,valid3=false;

               string Date, Day, Month;
            if (dateEdit1.DateTime.Month < 10)
            {
                Month = "0" + dateEdit1.DateTime.Month;
            }
            else
            { Month = dateEdit1.DateTime.Month.ToString(); }
            if (dateEdit1.DateTime.Day < 10)
            { Day = "0" + dateEdit1.DateTime.Day; }
            else
            { Day = dateEdit1.DateTime.Day.ToString(); }

            Date = dateEdit1.DateTime.Year + "-" + Month + "-" + Day;

            string PurchID="0";
            if (comboBox2.SelectedValue != null)
            {
                double Reming = 0;
                if (comboBox3.SelectedIndex == 0)
                {
                    if (float.Parse(Remin.Text) >= 0)
                    {
                        valid3 = true;
                        Reming = 0;
                    }
                    else
                    {
                        XtraMessageBox.Show("فى حالة اختيار نوع الفاتورة نقدى يرجى سداد قيمةالفاتورة كاملة او التغير للنوع اجل");
                        valid3 = false;
                    }
                }
                else
                {
                    if (float.Parse(Remin.Text) * -1 < float.Parse(textEdit6.Text))
                    {
                        valid3 = true;
                        Reming = double.Parse(Remin.Text);
                    }
                    else
                    {
                        XtraMessageBox.Show("يرجى التاكد من اقيمة المبلغ المدفوع");
                        valid3 = false;
                    }
                }

                if (valid3)
                {
                    if (dataGridView1.RowCount > 0)
                    {

                        valid1 = BussinessObj.Purch_Table_insert(DateTime.Parse(Date), comboBox2.SelectedValue.ToString(), double.Parse(textEdit6.Text), double.Parse(Pauid.Text), Reming, Note.Text, int.Parse(UserId));

                        if (valid1)
                        {
                            PurchID = BussinessObj.SelectLastOrderByMobile(comboBox2.SelectedValue.ToString(), decimal.Parse(textEdit6.Text), decimal.Parse(Pauid.Text), DateTime.Parse(Date));

                            for (int i = 0; i < dataGridView1.RowCount; i++)
                            {
                                valid2 = BussinessObj.purch_detail_insert(int.Parse(PurchID), int.Parse(dataGridView1[10, i].Value.ToString()), dataGridView1[3, i].Value.ToString(), dataGridView1[4, i].Value.ToString(), int.Parse(dataGridView1[8, i].Value.ToString()), decimal.Parse(dataGridView1[5, i].Value.ToString()), decimal.Parse(dataGridView1[6, i].Value.ToString()), dataGridView1[7, i].Value.ToString() == "" ? 0 : decimal.Parse(dataGridView1[7, i].Value.ToString()), decimal.Parse(dataGridView1[9, i].Value.ToString()));
                                if (valid2)
                                {
                                    BussinessObj.Stock_Purch_Table_insert(int.Parse(PurchID), int.Parse(dataGridView1[10, i].Value.ToString()), int.Parse(dataGridView1[8, i].Value.ToString()), 0);
                                }
                            }
                        }
                    }
                }


                if (valid1 && valid2)
                {
                    XtraMessageBox.Show(" تم اضافة بيانات الفاتورة يرجى استلام الفاتورة بالمخزن  ");

                    if (PurchRec == null || PurchRec.IsDisposed == true)
                    {
                        PurchRec = new PurchRec(int.Parse(PurchID),comboBox2.SelectedValue.ToString());
                    } 
                    PurchRec.Show();
                    PurchRec.Select();
                    ///claran
                    ///
                    dataGridView1.Rows.Clear();
                    Quantity.Text = "";
                    Pric1.Text = "";
                    Price2.Text = "";
                    SellingPrice.Text = "";
                    textEdit6.Text = "";
                    Remin.Text = "";
                    Pauid.Text = "";

                }
                else
                {
                    XtraMessageBox.Show("توجد مشكلة فى اضافة البيانات ");
                }

            }
            else
            {
                XtraMessageBox.Show("يرجى تحديد مورد ");

            }

        }

    }


}