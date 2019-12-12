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
    public partial class PayRevTypesAdd : DevExpress.XtraEditors.XtraForm
    {
        Busniss_Logic BussinessObj;
        public PayRevTypesAdd()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();
        }

        private void PayRevTypesAdd_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet.Pay_Rev_Type_Table' table. You can move, or remove it, as needed.
            this.pay_Rev_Type_TableTableAdapter.Fill(this.project_DBDataSet.Pay_Rev_Type_Table);

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool x = false;

            x = BussinessObj.Pay_Rev_Types_Insert(PaTypeName.Text, PayTypeDes.Text,Ident.SelectedItem.ToString());
                this.pay_Rev_Type_TableTableAdapter.Fill(this.project_DBDataSet.Pay_Rev_Type_Table);

            if (x == true)
            {
                XtraMessageBox.Show("تم اضافة البيانات ");
                PaTypeName.Text = "";
                PayTypeDes.Text = "";
            }
            else
            {
                XtraMessageBox.Show("توجد مشكلة فى اضافة البيانات ");
                ValidationClass.showStar(RTSName, x);

            }
        }
    }
}