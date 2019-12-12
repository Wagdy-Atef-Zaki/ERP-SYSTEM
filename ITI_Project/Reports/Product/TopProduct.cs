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
    public partial class TopProduct : DevExpress.XtraEditors.XtraForm
    {
        public TopProduct()
        {
            InitializeComponent();
        }

        private void TopProduct_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Now;
            dateEdit2.DateTime = DateTime.Now;
        }
    }
}