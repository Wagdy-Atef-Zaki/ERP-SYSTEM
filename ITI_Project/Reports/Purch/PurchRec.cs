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
using ItI_Project;

namespace ITI_Project
{
    public partial class PurchRec : DevExpress.XtraEditors.XtraForm
    {
         Report_Class ReportObj;
         DataTable SupplierTabl, PurchDetail, PurchTable, CopInf;
         private decimal Total, Reming, Paiud;
         List<CurrencyInfo> currencies = new List<CurrencyInfo>();
         ToWord TotalWord, ReminWord, PaiudWord;
         string Logo, Supplier_Mobile, Barcode;

        int purchID;
        public PurchRec()
        {
            InitializeComponent();
            ReportObj = new Report_Class();
        }
        public PurchRec(int _purchID, string _Supplier_Mobile)
        {
            InitializeComponent();
            ReportObj = new Report_Class();
            purchID = _purchID;
            Supplier_Mobile = _Supplier_Mobile;
        }

        private void PurchRec_Load(object sender, EventArgs e)
        {
            CopInf = ReportObj.LisSelectCompanyInfo();

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("CompanyInfo", CopInf));
            Logo = CopInf.Rows[0][8].ToString();

            SupplierTabl = ReportObj.SupplierData(Supplier_Mobile);
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Supplier", SupplierTabl));

            PurchTable = ReportObj.SellectPurch(purchID);
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("PurchTable", PurchTable));
            Total = 0;
            Reming = 0;
            Paiud = 0;

            Total = decimal.Parse( PurchTable.Rows[0][4].ToString());
            Paiud = decimal.Parse(PurchTable.Rows[0][2].ToString());
            Reming = decimal.Parse(PurchTable.Rows[0][3].ToString());

            //
            PurchDetail = ReportObj.PurchDeatiles(purchID);
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("PurchDetails", PurchDetail));



            try
            {

                currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Syria));
                TotalWord = new ToWord(Total, currencies[Convert.ToInt32(0)]);
                if (Reming < 0)
                {
                    ReminWord = new ToWord(Reming * -1, currencies[Convert.ToInt32(0)]);
                }
                else
                {
                    ReminWord = new ToWord(Reming, currencies[Convert.ToInt32(0)]);

                }
                PaiudWord = new ToWord(Paiud, currencies[Convert.ToInt32(0)]);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            reportViewer1.LocalReport.DisplayName = "فاتورة شراء رقم " + purchID;
            reportViewer1.LocalReport.ReportEmbeddedResource = "ITI_Project.Reports.Purch.PurchReceipt.rdlc";
            ReportParameter p = new ReportParameter("Total", TotalWord.ConvertToArabic());
            ReportParameter p2 = new ReportParameter("Remin", ReminWord.ConvertToArabic());
            ReportParameter p3 = new ReportParameter("Paid", PaiudWord.ConvertToArabic());
            reportViewer1.LocalReport.EnableExternalImages = true;
            ReportParameter P4 = new ReportParameter("Logo", Logo);

            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p, p2, p3, P4 });
            this.reportViewer1.RefreshReport();
            reportViewer1.Refresh();
        }
    }
}