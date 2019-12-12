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
    public partial class PayRevUp : DevExpress.XtraEditors.XtraForm
    {
        Busniss_Logic BussinessObj;
        int UserId;
        public PayRevUp()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();
        }

        private void PayRevUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet.Pay_Rev_Type_Table' table. You can move, or remove it, as needed.
            this.pay_Rev_Type_TableTableAdapter.Fill(this.project_DBDataSet.Pay_Rev_Type_Table);
            // TODO: This line of code loads data into the 'project_DBDataSet.Pay_Rev_Table' table. You can move, or remove it, as needed.
            this.pay_Rev_TableTableAdapter.Fill(this.project_DBDataSet.Pay_Rev_Table);

        }

        private void comboBoxEdit5_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.pay_Rev_Type_TableTableAdapter.FillByFlag(this.project_DBDataSet.Pay_Rev_Type_Table, comboBoxEdit5.SelectedItem.ToString());

        }

        private void comboBoxEdit3_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> Obj = BussinessObj.Pay_Rev_Dates(comboBoxEdit3.SelectedItem.ToString());
            comboBox1.DataSource = Obj;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            List<string> Obj = BussinessObj.Pay_Rev_Ides(comboBoxEdit3.SelectedItem.ToString(), comboBox1.SelectedItem.ToString());
            comboBox2.DataSource = Obj;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                Pay_Rev_Table Obj= BussinessObj.Pay_Rev_byid(int.Parse(comboBox2.SelectedItem.ToString()));
                if (Obj != null)
                {
                    comboBoxEdit5.SelectedItem = Obj.Flag;
                    ComPand.SelectedValue = Obj.Pay_Rev_Type_ID;
                    TXTValue.Text = Obj.Pay_Rev_Amount.ToString();
                    TxtDes.Text = Obj.Pay_Rev_Description;
                    Date.DateTime = Obj.Pay_Rev_Date;
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            bool x = false;
             string Datestr, Day, Month;
                if (Date.DateTime.Month < 10)
                { Month = "0" + Date.DateTime.Month; }
                else
                { Month = Date.DateTime.Month.ToString();}

                if (Date.DateTime.Day < 10)
                { Day = "0" + Date.DateTime.Day; }
                else
                { Day = Date.DateTime.Day.ToString();}

                Datestr = Date.DateTime.Year + "-" + Month + "-" + Day;
            if (comboBox2.SelectedItem != null)
            {

                x = BussinessObj.Pay_Rev_deleteByID(int.Parse(comboBox2.SelectedItem.ToString()));
  

                    TXTValue.Text = "";
                    TxtDes.Text = "";
                    ComPand.SelectedValue = "";
                    Date.DateTime = DateTime.Now;
              
            }
            if (x == true)
            {
                if (comboBoxEdit5.SelectedIndex == 0)
                {
                    Safe_Table obj = BussinessObj.Safe_Table_Update(+decimal.Parse(TXTValue.Text), Datestr);
                }
                else
                {
                    Safe_Table obj = BussinessObj.Safe_Table_Update(-decimal.Parse(TXTValue.Text), Datestr);
                }
                XtraMessageBox.Show("تم حذف البيانات ");

            }
            else
            {
                XtraMessageBox.Show("توجد مشكلة فى حذف البيانات ");
                ValidationClass.showStar(RTSName, x);

            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ////
        }
    }
}