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
    public partial class ProductMovement : DevExpress.XtraEditors.XtraForm
    {

        Busniss_Logic BussinessObj;

        public ProductMovement()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();
        }

        private void ProductMovement_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet.Product_Table' table. You can move, or remove it, as needed.
            this.product_TableTableAdapter.Fill(this.project_DBDataSet.Product_Table);

            Date1.DateTime = DateTime.Now;
            Date2.DateTime = DateTime.Now;

        }
        private void UpdateDataGridView1()
        {
            dataGridView1.ColumnCount = 9;
            dataGridView1.Columns[0].Name = "م";
            dataGridView1.Columns[1].Name = "رقم الفاتورة";
            dataGridView1.Columns[2].Name = "تاريخ الفاتورة";
            dataGridView1.Columns[3].Name = "نوع الفاتورة";
            dataGridView1.Columns[4].Name = "رقم العميل";
            dataGridView1.Columns[5].Name = "العدد";
            dataGridView1.Columns[6].Name = "سعر المنتج";
            dataGridView1.Columns[7].Name = "خصم ";
            dataGridView1.Columns[8].Name = "اجمالى العدد";
            dataGridView1.Columns[4].Visible = false;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "عرض الفاتورة";
            btn.Name = "Button";
            btn.Text = "عرض ";
            btn.UseColumnTextForButtonValue = true;
            dataGridView1.Columns.Add(btn);
        }
        private void UpdateDataGridView2()
        {
            dataGridView2.ColumnCount = 9;
            dataGridView2.Columns[0].Name = "م";
            dataGridView2.Columns[1].Name = "رقم الفاتورة";
            dataGridView2.Columns[2].Name = "تاريخ الفاتورة";
            dataGridView2.Columns[3].Name = "نوع الفاتورة";
            dataGridView2.Columns[4].Name = "رقم العميل";
            dataGridView2.Columns[5].Name = "العدد";
            dataGridView2.Columns[6].Name = "سعر المنتج";
            dataGridView2.Columns[7].Name = "خصم ";
            dataGridView2.Columns[8].Name = "اجمالى العدد";
            dataGridView2.Columns[4].Visible = false;
            dataGridView2.Columns[3].Visible = false;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "عرض الفاتورة";
            btn.Name = "Button";
            btn.Text = "عرض ";
            btn.UseColumnTextForButtonValue = true;
            dataGridView2.Columns.Add(btn);
        }
        private void UpdateDataGridView3()
        {
            dataGridView3.ColumnCount = 8;
            dataGridView3.Columns[0].Name = "م";
            dataGridView3.Columns[1].Name = "رقم الفاتورة";
            dataGridView3.Columns[2].Name = "تاريخ الفاتورة";
            dataGridView3.Columns[3].Name = "رقم العميل";
            dataGridView3.Columns[4].Name = "العدد";
            dataGridView3.Columns[5].Name = "سعر البيع";
            dataGridView3.Columns[6].Name = "سعر الشراء";
            dataGridView3.Columns[7].Name = "اجمالى الشراء";
            dataGridView3.Columns[3].Visible = false;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "عرض الفاتورة";
            btn.Name = "Button";
            btn.Text = "عرض ";
            btn.UseColumnTextForButtonValue = true;
            dataGridView3.Columns.Add(btn);
        }
        private void UpdateDataGridView4()
        {
            dataGridView4.ColumnCount = 8;
            dataGridView4.Columns[0].Name = "م";
            dataGridView4.Columns[1].Name = "رقم الفاتورة";
            dataGridView4.Columns[2].Name = "تاريخ الفاتورة";
            dataGridView4.Columns[3].Name = "رقم العميل";
            dataGridView4.Columns[4].Name = "العدد";
            dataGridView4.Columns[5].Name = "سعر البيع";
            dataGridView4.Columns[6].Name = "سعر الشراء";
            dataGridView4.Columns[7].Name = "اجمالى الشراء";
            dataGridView4.Columns[3].Visible = false;
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "عرض الفاتورة";
            btn.Name = "Button";
            btn.Text = "عرض ";
            btn.UseColumnTextForButtonValue = true;
            dataGridView4.Columns.Add(btn);
        }
        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                ////orders
                dataGridView1.Rows.Clear();
                UpdateDataGridView1();

                List<Order_Details_Table> obj = BussinessObj.order_details_Table_searchByProductID(int.Parse(comboBox1.SelectedValue.ToString()));

                if (obj != null)
                {
 
                }

                ///order retens
                dataGridView2.Rows.Clear();
                UpdateDataGridView2();

                List<Order_Retern_Details_Table> obj2 = BussinessObj.order_retern_details_Table_searchByProductID(int.Parse(comboBox1.SelectedValue.ToString()));

                if (obj2 != null)
                {

                }
                ///purches
                dataGridView3.Rows.Clear();
                UpdateDataGridView3();

                List<Purchases_Details_Table> obj3 = BussinessObj.Purch_details_Table_searchByProductID(int.Parse(comboBox1.SelectedValue.ToString()));
                if (obj3 != null)
                {

                }
                //purch return
                dataGridView4.Rows.Clear();
                UpdateDataGridView4();

                List<Purch_Retern_Details_Table> obj4 = BussinessObj.Purch_Reterns_details_Table_searchByProductID(int.Parse(comboBox1.SelectedValue.ToString()));
                if (obj4 != null)
                {

                }
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

            string StingDate2, Day2, Month2, StingDate, Day, Month;

            if (Date2.DateTime.Month < 10)
            { Month2 = "0" + Date2.DateTime.Month;
            }
            else
            {Month2 = Date2.DateTime.Month.ToString();}
            if (Date2.DateTime.Day < 10)
            { Day2 = "0" + Date2.DateTime.Day;}
            else
            { Day2 = Date2.DateTime.Day.ToString();}

            StingDate2 = Date2.DateTime.Year + "-" + Month2 + "-" + Day2;

            if (Date1.DateTime.Month < 10)
            { Month = "0" + Date1.DateTime.Month;}
            else
            { Month = Date1.DateTime.Month.ToString(); }
            if (Date1.DateTime.Day < 10)
            { Day = "0" + Date1.DateTime.Day; }
            else
            { Day = Date1.DateTime.Day.ToString();}

            StingDate = Date1.DateTime.Year + "-" + Month + "-" + Day;

            if (comboBox1.SelectedValue != null)
            {
                ////orders
                dataGridView1.Rows.Clear();
                UpdateDataGridView1();

                List<Order_Details_Table> obj = BussinessObj.order_details_Table_searchByProductID_Date(int.Parse(comboBox1.SelectedValue.ToString()),StingDate,StingDate2);

                if (obj != null)
                {

                }
                ///order retens
                dataGridView2.Rows.Clear();
                UpdateDataGridView2();

                List<Order_Retern_Details_Table> obj2 = BussinessObj.order_retern_details_Table_searchByProductID_Date(int.Parse(comboBox1.SelectedValue.ToString()), StingDate, StingDate2);

                if (obj2 != null)
                {

                }
                ///purches
                dataGridView3.Rows.Clear();
                UpdateDataGridView3();

                List<Purchases_Details_Table> obj3 = BussinessObj.Purch_details_Table_searchByProductID_Date(int.Parse(comboBox1.SelectedValue.ToString()), StingDate, StingDate2);
                if (obj3 != null)
                {

                }
                //purch return
                dataGridView4.Rows.Clear();
                UpdateDataGridView4();

                List<Purch_Retern_Details_Table> obj4 = BussinessObj.Purch_Reterns_details_Table_searchByProductID_Date(int.Parse(comboBox1.SelectedValue.ToString()), StingDate, StingDate2);
                if (obj4 != null)
                {

                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {

                int ID = int.Parse(dataGridView1[1, (e.RowIndex)].Value.ToString());
                String Mobile = dataGridView1[4, (e.RowIndex)].Value.ToString();

                //OrderReport OrederObj = new OrderReport(ID, Mobile, 0);
                //OrederObj.Show();
            }
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {

                int ID = int.Parse(dataGridView3[1, (e.RowIndex)].Value.ToString());
                String Mobile = dataGridView3[3, (e.RowIndex)].Value.ToString();

                //PurchesReport OrederObj = new PurchesReport(ID, Mobile, 0);
                //OrederObj.Show();
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9)
            {

                int ID = int.Parse(dataGridView2[1, (e.RowIndex)].Value.ToString());
                String Mobile = dataGridView2[4, (e.RowIndex)].Value.ToString();


                //ReternsReport OrederObj = new ReternsReport(ID, Mobile, 0, 0);
                //OrederObj.Show();
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {

                int ID = int.Parse(dataGridView4[1, (e.RowIndex)].Value.ToString());
                String Mobile = dataGridView4[3, (e.RowIndex)].Value.ToString();

                //ReternsReport OrederObj = new ReternsReport(ID, Mobile, 0, 1);
                //OrederObj.Show();
            }
        }
    }
}