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
using System.Text.RegularExpressions;
using Microsoft.Reporting.WinForms;
using System.IO;

namespace ITI_Project.Forms.Product
{
    public partial class BarcodeGenerator : DevExpress.XtraEditors.XtraForm
    {

        Busniss_Logic BussinessObj;
        bool NewItem;
        string OldBarcode;
        public BarcodeGenerator()
        {
            InitializeComponent();
            BussinessObj = new Busniss_Logic();
        }
        public string GenerateRandomNumber(int size)
        {
            Random random = new Random((int)DateTime.Now.Ticks);
            string builder = "";
            string s;
            for (int i = 0; i < size; i++)
            {
                s = Convert.ToString(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder = builder + s;
            }

            return builder;
        }
        private void BarcodeGenerator_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project_DBDataSet.Product_Table' table. You can move, or remove it, as needed.
            this.product_TableTableAdapter.Fill(this.project_DBDataSet.Product_Table);

            label4.Font = new Font("Code EAN13", label4.Font.Size, FontStyle.Regular);

        }
        public static System.Drawing.Bitmap ResizeImage(System.Drawing.Image image, int width, int height)
        {
            //a holder for the result 
            Bitmap result = new Bitmap(width, height);

            //use a graphics object to draw the resized image into the bitmap 
            using (Graphics graphics = Graphics.FromImage(result))
            {
                //set the resize quality modes to high quality 
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //draw the image into the target bitmap 
                graphics.DrawImage(image, 0, 0, result.Width, result.Height);
            }

            //return the resulting bitmap 
            return result;
        } 
        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = GenerateRandomNumber(7).ToString();
            textBox1.Text = textBox1.Text.Remove(13);
            if (textBox1.Text != OldBarcode && comboBox2.Visible)
            {
                button2.Visible = true;
            }
            else
            {
                button2.Visible = false;


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox4.Text = "0";
            textBox3.Text = "";
            if (comboBox1.SelectedValue!=null)
            {
                 Product_Table ProductObj=  BussinessObj.Product_tb_search_by_ID(int.Parse(comboBox1.SelectedValue.ToString()));
                 if (!String.IsNullOrEmpty(ProductObj.Product_Name))
                 {
                     textBox1.Text = ProductObj.BareCode;
                     textBox1.Enabled = false;
                     button2.Visible = false;
                 }
                 else
                 {
                     textBox1.Enabled = true;
                     button2.Visible = true;

                 }
                 textBox3.Text = ProductObj.Product_Name;
            }
            ////select price from purches 


            
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = false;
            NewItem = true;
            textBox1.Enabled = true;
            textBox3.Enabled = true;
            groupControl3.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = true;
            NewItem = false;
            textBox1.Enabled = false;
            textBox3.Enabled = false;
            groupControl3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                if (!string.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    bool x = BussinessObj.Product_Table_updateBarcodeByProductID(int.Parse(comboBox1.SelectedValue.ToString()),textBox1.Text);

                    if (x)
                    {
                        XtraMessageBox.Show("تم تحديث الباركود  ");

                    }
                    else
                    {
                        XtraMessageBox.Show("توجد مشكلة فى تحديث الباركود");

                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox1.Text)))
            {
                if (textBox1.Text.Length <= 13)
                {

                    String str = "[0-9]";

                    if (Regex.IsMatch(textBox1.Text, str))
                    {
                        string Barrcode, Check2Digits;

                        Check2Digits = textBox1.Text.PadRight(13, '0');
                        Barrcode = EAN13Class.EAN13(Check2Digits);
                        label4.Text = Barrcode;
                    }
                    else
                    {
                        MessageBox.Show("لا يسمح بكتابة حروف");
                        if (radioButton1.Checked == true)
                        {
                            if (radioButton1.Checked == true)
                            {
                                textBox1.Text = "1";
                            }
                        }
                    }



                    /// passing image to report 
                    /// 

                    string LastBarcode = Path.Combine(Path.GetFullPath(@"BarcodeImge\"));
                    Bitmap b = new Bitmap(label4.Width, label4.Height);
                    label4.DrawToBitmap(b, new Rectangle(0, 0, b.Width, b.Height));
                    if (Directory.Exists(LastBarcode))
                    {
                        LastBarcode = LastBarcode + "LastBarcode.jpg";
                    }
                    else
                    {
                        Directory.CreateDirectory(LastBarcode);
                    }


                    // LastBarcode = LastBarcode + "LastBarcode.jpg";
                    b.Save(LastBarcode);
                    if (File.Exists(LastBarcode))
                    {

                        reportViewer1.LocalReport.DisplayName = "الباركود الخاص بالمنتج " + textBox3.Text;
                        reportViewer1.LocalReport.ReportEmbeddedResource = "ITI_Project.Reports.Barcode.BarcodeSmallSize.rdlc";
                        ReportParameter p = new ReportParameter("BarcodeImage", LastBarcode);
                        ReportParameter p2 = new ReportParameter("ProductName", textBox3.Text);
                        ReportParameter p3 = new ReportParameter("PrpductPrice", textBox4.Text);
                        this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p, p2, p3 });
                        this.reportViewer1.RefreshReport();
                        reportViewer1.Refresh();
                    }


                }
                else
                {
                    XtraMessageBox.Show(" غير مسموح باكثر من 13 رقم ");
                }
            }
            else
            { MessageBox.Show("يرجى كتابة نص  اولا"); }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if ((!String.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox1.Text)))
            {
                if (textBox1.Text.Length <= 13)
                {
                    if (comboBox1.SelectedIndex != -1)
                    {
                        String str = "[0-9]";

                        if (Regex.IsMatch(textBox1.Text, str))
                        {
                            string Barrcode, Check2Digits;

                            Check2Digits = textBox1.Text.PadRight(13, '0');
                            Barrcode = EAN13Class.EAN13(Check2Digits);
                            label4.Text = Barrcode;
                        }
                        else
                        {
                            MessageBox.Show("لا يسمح بكتابة حروف");
                            if (radioButton1.Checked == true)
                            {
                                if (radioButton1.Checked == true)
                                {
                                    textBox1.Text = "1";
                                }
                            }
                        }


                        string LastBarcode = Path.Combine(Path.GetFullPath(@"BarcodeImge\"));
                        Bitmap b = new Bitmap(label4.Width, label4.Height);
                        label4.DrawToBitmap(b, new Rectangle(0, 0, b.Width, b.Height));
                        if (Directory.Exists(LastBarcode))
                        {
                            LastBarcode = LastBarcode + "LastBarcode.jpg";
                        }
                        else
                        {
                            Directory.CreateDirectory(LastBarcode);
                        }


                        // LastBarcode = LastBarcode + "LastBarcode.jpg";
                        b.Save(LastBarcode);
                        if (File.Exists(LastBarcode))
                        {
                            //صغير
                            //وسط
                            //كبير
                            //ضخم
                            if (comboBox1.SelectedIndex != -1)
                            {
                                // reportViewer1.Reset();
                                reportViewer1.LocalReport.DisplayName = "الباركود الخاص بالمنتج " + textBox3.Text + " حجم " + comboBox1.SelectedItem.ToString();
                                if (comboBox2.SelectedIndex == 0)
                                {
                                    reportViewer1.LocalReport.ReportEmbeddedResource = "ITI_Project.Reports.Barcode.A4BarcoderSmall.rdlc";
                                    ReportParameter p = new ReportParameter("BarcodeImage", LastBarcode);
                                    ReportParameter p2 = new ReportParameter("ProductName", textBox3.Text);
                                    ReportParameter p3 = new ReportParameter("PrpductPrice", textBox4.Text);
                                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p, p2, p3 });
                                    this.reportViewer1.RefreshReport();
                                    reportViewer1.Refresh();
                                }
                                else if (comboBox2.SelectedIndex == 1)
                                {
                                    reportViewer1.LocalReport.ReportEmbeddedResource = "ITI_Project.Reports.Barcode.A4BarcoderMeduim.rdlc";
                                    ReportParameter p = new ReportParameter("BarcodeImage", LastBarcode);
                                    ReportParameter p2 = new ReportParameter("ProductName", textBox3.Text);
                                    ReportParameter p3 = new ReportParameter("PrpductPrice", textBox4.Text);
                                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p, p2, p3 });
                                    this.reportViewer1.RefreshReport();
                                    reportViewer1.Refresh();
                                }
                                else if (comboBox2.SelectedIndex == 2)
                                {
                                    reportViewer1.LocalReport.ReportEmbeddedResource = "ITI_Project.Reports.Barcode.A4Barcoderdlc.rdlc";
                                    ReportParameter p = new ReportParameter("BarcodeImage", LastBarcode);
                                    ReportParameter p2 = new ReportParameter("ProductName", textBox3.Text);
                                    ReportParameter p3 = new ReportParameter("PrpductPrice", textBox4.Text);
                                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p, p2, p3 });
                                    this.reportViewer1.RefreshReport();
                                    reportViewer1.Refresh();
                                }
                                else if (comboBox2.SelectedIndex == 3)
                                {
                                    reportViewer1.LocalReport.ReportEmbeddedResource = "ITI_Project.Reports.Barcode.A4BarcoderLarg.rdlc";
                                    ReportParameter p = new ReportParameter("BarcodeImage", LastBarcode);
                                    ReportParameter p2 = new ReportParameter("ProductName", textBox3.Text);
                                    ReportParameter p3 = new ReportParameter("PrpductPrice", textBox4.Text);
                                    this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { p, p2, p3 });
                                    this.reportViewer1.RefreshReport();
                                    reportViewer1.Refresh();
                                }

                            }
                        }
                    }


                }

            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text) || !string.IsNullOrWhiteSpace(textBox1.Text))
            {
                // button3.Invoke(new Action(() => PrintDoc()));
                try
                {
                    reportViewer1.PrintDialog();
                }
                catch (Exception E)
                {
                    if (E.Message == "Operation is not valid due to the current state of the object.")
                    {
                        XtraMessageBox.Show("يجب انشاء الباركود اولا قبل محاولة الطباعة");
                    }
                }

            }
            else
            { XtraMessageBox.Show("يرجى كتابة نص  اولا"); }
        }
    }
}