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
using System.Diagnostics;

namespace ItI_Project
{
    public partial class AboutUs : DevExpress.XtraEditors.XtraForm
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {

        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.facebook.com/pluto.it.solutions.eg/");
            Process.Start(sInfo);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://docs.google.com/forms/d/1Xkmp4qnmJJ2RPMTpEY8waTOrRZQnYsA-H9fHPrdpEZQ/prefill");
            Process.Start(sInfo);
        }
    }
}