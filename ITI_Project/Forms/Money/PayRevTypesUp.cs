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
    public partial class PayRevTypesUp : DevExpress.XtraEditors.XtraForm
    {
        Busniss_Logic BussinessObj;

        public PayRevTypesUp()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();
        }

        private void PayRevTypesUp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet.Pay_Rev_Type_Table' table. You can move, or remove it, as needed.
            this.pay_Rev_Type_TableTableAdapter.Fill(this.project_DBDataSet.Pay_Rev_Type_Table);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue!=null)
            {
            Pay_Rev_Type_Table Obj = BussinessObj.Pay_Rev_Type_SelectById(int.Parse( comboBox1.SelectedValue.ToString()));

            comboBoxEdit5.SelectedItem = Obj.Flag;
            PaytYName.Text = Obj.Pay_Rev_Type_Name;
            PayTypDes.Text = Obj.Pay_Rev_Type_Description;
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedValue != null)
            {
                bool  x = BussinessObj.Pay_Rev_Types_Delete(int.Parse(comboBox1.SelectedValue.ToString()));
                Pay_Rev_Type_Table Obj = BussinessObj.Pay_Rev_Type_SelectById(int.Parse(comboBox1.SelectedValue.ToString()));

                if (x == true)
                {
                    XtraMessageBox.Show("تم حذف البيانات ");
                    PaytYName.Text = "";
                    PayTypDes.Text = "";
                }
                else
                {
                    XtraMessageBox.Show("توجد مشكلة فى حذف البيانات ");
                    ValidationClass.showStar(RTSName, x);

                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                bool x = false;

                x = BussinessObj.Pay_Rev_Type_Table_updateBarcodeBytID(int.Parse(comboBox1.SelectedValue.ToString())  ,PaytYName.Text, PayTypDes.Text,comboBoxEdit5.SelectedItem.ToString());
                    Pay_Rev_Type_Table Obj = BussinessObj.Pay_Rev_Type_SelectById(int.Parse(comboBox1.SelectedValue.ToString()));

                if (x == true)
                {
                    XtraMessageBox.Show("تم تحديث البيانات ");

                }
                else
                {
                    XtraMessageBox.Show("توجد مشكلة فى تحديث البيانات ");
                    ValidationClass.showStar(RTSName, x);

                }
            }
        }
    }
}