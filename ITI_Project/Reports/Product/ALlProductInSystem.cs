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
using Microsoft.Reporting.WinForms;
using ItI_Project;
using ITI_Project.HelpClass;
using ITI_Project.Bussiness_Logic;

namespace ITI_Project
{
    public partial class ALlProductInSystem : DevExpress.XtraEditors.XtraForm
    {
        Report_Class ReportObj;
        private DataTable AllProduct ,CopInf;
        string Logo;
        public ALlProductInSystem()
        {
            InitializeComponent();
            ReportObj = new Report_Class();
        }

        private void ALlProductInSystem_Load(object sender, EventArgs e)
        {

                
                CopInf = ReportObj.LisSelectCompanyInfo();

                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("CompanyInfo", CopInf));
                Logo = CopInf.Rows[0][8].ToString();

                AllProduct = ReportObj.SelectAllProduct();

                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("AllProduct", AllProduct));


                reportViewer1.LocalReport.DisplayName = "تقرير بالمنتجات المضافة بالنظام ";
                reportViewer1.LocalReport.ReportEmbeddedResource = "ITI_Project.Reports.Product.AllProduct.rdlc";
                ReportParameter parameter = new ReportParameter("Logo", Logo);
                this.reportViewer1.LocalReport.SetParameters(parameter);
                this.reportViewer1.RefreshReport();
        }
    }
}