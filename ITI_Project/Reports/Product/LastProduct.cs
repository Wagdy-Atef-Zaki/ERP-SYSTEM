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

namespace ITI_Project
{
    public partial class LastProduct : DevExpress.XtraEditors.XtraForm
    {
        public LastProduct()
        {
            InitializeComponent();
        }

        private void LastProduct_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Now;
            dateEdit2.DateTime = DateTime.Now;

        }
    }
}