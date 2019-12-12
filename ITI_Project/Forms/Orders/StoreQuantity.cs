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

namespace ITI_Project.Forms.Orders
{
    public partial class StoreQuantity : DevExpress.XtraEditors.XtraForm
    {
        public StoreQuantity()
        {
            InitializeComponent();
        }

        private void StoreQuantity_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet.Stock_Quantity_Table' table. You can move, or remove it, as needed.
            this.stock_Quantity_TableTableAdapter.Fill(this.project_DBDataSet.Stock_Quantity_Table);
            // TODO: This line of code loads data into the 'project_DBDataSet.Product_Table' table. You can move, or remove it, as needed.
            this.product_TableTableAdapter.Fill(this.project_DBDataSet.Product_Table);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue != null)
            {
                this.stock_Quantity_TableTableAdapter.FillByID(this.project_DBDataSet.Stock_Quantity_Table, int.Parse(comboBox1.SelectedValue.ToString()));
            }
        }
    }
}