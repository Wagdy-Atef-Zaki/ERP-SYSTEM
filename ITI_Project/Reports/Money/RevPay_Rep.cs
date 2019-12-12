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

namespace ITI_Project
{
    public partial class RevPay_Rep : DevExpress.XtraEditors.XtraForm
    {
        Report_Class ReportObj;
        private DataTable Payments, CopInf,Reven;
        string Logo;
        public RevPay_Rep()
        {
            InitializeComponent();
            ReportObj = new Report_Class();
        }

        private void RevPay_Rep_Load(object sender, EventArgs e)
        {
            dateEdit1.DateTime = DateTime.Now; 
            dateEdit2.DateTime = DateTime.Now;


        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string Date, Day, Month, Date2, Day2, Month2;
            if (dateEdit1.DateTime.Month < 10)
            {
                Month = "0" + dateEdit1.DateTime.Month;
            }
            else
            { Month = dateEdit1.DateTime.Month.ToString(); }
            if (dateEdit1.DateTime.Day < 10)
            { Day = "0" + dateEdit1.DateTime.Day; }
            else
            { Day = dateEdit1.DateTime.Day.ToString(); }

            Date = dateEdit1.DateTime.Year + "-" + Month + "-" + Day;

            if (dateEdit2.DateTime.Month < 10)
            {
                Month2 = "0" + dateEdit2.DateTime.Month;
            }
            else
            { Month2 = dateEdit2.DateTime.Month.ToString(); }
            if (dateEdit2.DateTime.Day < 10)
            { Day2 = "0" + dateEdit2.DateTime.Day; }
            else
            { Day2 = dateEdit2.DateTime.Day.ToString(); }

            Date2 = dateEdit2.DateTime.Year + "-" + Month2 + "-" + Day2;
            
            
            CopInf = ReportObj.LisSelectCompanyInfo();

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("CompanyInfo", CopInf));
            Logo = CopInf.Rows[0][8].ToString();

            Payments = ReportObj.SelectAllPayments(Date,Date2);

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Payments", Payments));

            Reven = ReportObj.SelectAllRev(Date, Date2);
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Reven", Reven));

            reportViewer1.LocalReport.DisplayName = "تقرير ايرادات ومصروفات المؤسسة ";
            reportViewer1.LocalReport.ReportEmbeddedResource = "ITI_Project.Reports.Money.paymentes.rdlc";
            ReportParameter parameter = new ReportParameter("Logo", Logo);
            this.reportViewer1.LocalReport.SetParameters(parameter);
            this.reportViewer1.RefreshReport();
        }
    }
}