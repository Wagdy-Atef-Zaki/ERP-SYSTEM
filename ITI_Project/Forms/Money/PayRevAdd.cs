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

namespace ITI_Project.Forms.Money
{
    public partial class PayRevAdd : DevExpress.XtraEditors.XtraForm
    {
        Busniss_Logic BussinessObj;
        int UserId;
        public PayRevAdd()
        {
            InitializeComponent();
            BussinessObj= new Busniss_Logic();
        }

        private void PayRevAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet1.Pay_Rev_Table' table. You can move, or remove it, as needed.
            this.pay_Rev_TableTableAdapter.Fill(this.project_DBDataSet1.Pay_Rev_Table);
            // TODO: This line of code loads data into the 'project_DBDataSet.Pay_Rev_Type_Table' table. You can move, or remove it, as needed.
            this.pay_Rev_Type_TableTableAdapter.FillByFlag(this.project_DBDataSet.Pay_Rev_Type_Table, "مصروفات");
            comboBoxEdit5.SelectedIndex = 0;
            Data.DateTime = DateTime.Now;
        }

        private void comboBoxEdit5_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pay_Rev_Type_TableTableAdapter.FillByFlag(this.project_DBDataSet.Pay_Rev_Type_Table, comboBoxEdit5.SelectedItem.ToString());

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string Date, Day, Month;
            if (Data.DateTime.Month < 10)
            {
                Month = "0" + Data.DateTime.Month;}
            else
            { Month = Data.DateTime.Month.ToString();}
            if (Data.DateTime.Day < 10)
            { Day = "0" + Data.DateTime.Day; }
            else
            {Day = Data.DateTime.Day.ToString(); }

            Date = Data.DateTime.Year + "-" + Month + "-" + Day;


            bool x = false;
           
                x = BussinessObj.insert_into_pay_rev_table(decimal.Parse(TXTValue.Text), Date, TXTDes.Text, int.Parse( ComPand.SelectedValue.ToString()),UserId,comboBoxEdit5.SelectedItem.ToString());

               
            if (x == true)
            {
                if (comboBoxEdit5.SelectedIndex == 0)
                {
                    Safe_Table obj = BussinessObj.Safe_Table_Update(-decimal.Parse(TXTValue.Text), Date);
                }
                else
                {
                    Safe_Table obj = BussinessObj.Safe_Table_Update(decimal.Parse(TXTValue.Text), Date);
                }
                XtraMessageBox.Show("تم اضافة البيانات ");
                this.pay_Rev_TableTableAdapter.Fill(this.project_DBDataSet1.Pay_Rev_Table);
                TXTValue.Text = "";
                TXTDes.Text = "";
                Data.DateTime = DateTime.Now;
            }
            else
            {
                XtraMessageBox.Show("توجد مشكلة فى اضافة البيانات ");
                ValidationClass.showStar(RTSName, x);
                ValidationClass.showStar(label1, x);


            }
        }
    }
}