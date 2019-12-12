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
using ITI_Project.HelpClass;
using Microsoft.Reporting.WinForms;
using ITI_Project.Bussiness_Logic;

namespace ITI_Project
{
    public partial class ProductQuantityAlert : DevExpress.XtraEditors.XtraForm
    {
        Report_Class ReportObj;
        private DataTable ProductQuantityStore, CopInf;
        string Logo;
        public ProductQuantityAlert()
        {
            InitializeComponent();
            ReportObj = new Report_Class();

        }

        private void ProductQuantityAlert_Load(object sender, EventArgs e)
        {
            CopInf = ReportObj.LisSelectCompanyInfo();

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("CompanyInfo", CopInf));
            Logo = CopInf.Rows[0][8].ToString();

            ProductQuantityStore =ReportObj.SelectAllProductQunatity();

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ProductQuantityStore", ProductQuantityStore));


            reportViewer1.LocalReport.DisplayName = "تنبيه الكميات المتوفرة بالمخزن ";
            reportViewer1.LocalReport.ReportEmbeddedResource = "ITI_Project.Reports.Product.StoreProductQuantity.rdlc";
            ReportParameter parameter = new ReportParameter("Logo", Logo);
            this.reportViewer1.LocalReport.SetParameters(parameter);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}