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
using ITI_Project.Bussiness_Logic;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace ITI_Project
{
    public partial class ProductWillExpire : DevExpress.XtraEditors.XtraForm
    {
        Report_Class ReportObj;
        private DataTable ProductillExpir, CopInf;
        string Logo;
        int Dayes = 0;
        public ProductWillExpire()
        {
            InitializeComponent();
            ReportObj = new Report_Class();
        }
        private void ProductWillExpire_Load(object sender, EventArgs e)
        {


            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var filePath = roamingDirectory + "\\ProductExpireSetting.txt";

            if (File.Exists(filePath))
            {
                if (!string.IsNullOrEmpty(File.ReadAllText(filePath)) || !string.IsNullOrWhiteSpace(File.ReadAllText(filePath)))
                {
                    Dayes = int.Parse(File.ReadAllText(filePath));
                }
                else
                {
                    Dayes = -10;
                }
            }

            CopInf = ReportObj.LisSelectCompanyInfo();

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("CompanyInfo", CopInf));
            Logo = CopInf.Rows[0][8].ToString();

            ProductillExpir = ReportObj.WillExpire(Dayes);

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ProductillExpir", ProductillExpir));


            reportViewer1.LocalReport.DisplayName =  "منتجات اوشكت على صلاحيتها على الانتهاء";
            reportViewer1.LocalReport.ReportEmbeddedResource = "ITI_Project.Reports.Product.StoreProductExpire.rdlc";
            ReportParameter parameter = new ReportParameter("Logo", Logo);
            this.reportViewer1.LocalReport.SetParameters(parameter);
            this.reportViewer1.RefreshReport();
        }
    }
}