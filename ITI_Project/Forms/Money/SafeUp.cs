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
    public partial class SafeUp : DevExpress.XtraEditors.XtraForm
    {
        Busniss_Logic BussinessObj;
        public SafeUp()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void SafeUp_Load(object sender, EventArgs e)
        {

            Safe_Table Obj = BussinessObj.SelectSafe_Table();
            if (Obj != null)
            {
                txtValue.Text = Obj.Safe_Amount.ToString();
                Date.DateTime = Obj.Addation_Date;
            }


        }
    }
}