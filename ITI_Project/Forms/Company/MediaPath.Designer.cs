namespace ITI_Project.Forms.Company
{
    partial class MediaPath
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnBackBrow = new DevExpress.XtraEditors.SimpleButton();
            this.Path = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.SaveFile = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Path.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnBackBrow);
            this.groupControl1.Controls.Add(this.Path);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(711, 85);
            this.groupControl1.TabIndex = 49;
            this.groupControl1.Text = "مسار حفظ  ملقات الوسائط";
            // 
            // btnBackBrow
            // 
            this.btnBackBrow.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.btnBackBrow.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackBrow.Appearance.Options.UseBackColor = true;
            this.btnBackBrow.Appearance.Options.UseFont = true;
            this.btnBackBrow.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnBackBrow.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.btnBackBrow.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.btnBackBrow.AppearanceHovered.Options.UseBackColor = true;
            this.btnBackBrow.AppearanceHovered.Options.UseBorderColor = true;
            this.btnBackBrow.Location = new System.Drawing.Point(6, 29);
            this.btnBackBrow.Name = "btnBackBrow";
            this.btnBackBrow.Size = new System.Drawing.Size(149, 43);
            this.btnBackBrow.TabIndex = 47;
            this.btnBackBrow.Text = "استعراض";
            this.btnBackBrow.Click += new System.EventHandler(this.btnBackBrow_Click);
            // 
            // Path
            // 
            this.Path.Enabled = false;
            this.Path.Location = new System.Drawing.Point(161, 29);
            this.Path.Name = "Path";
            this.Path.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Path.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Path.Properties.Appearance.Options.UseFont = true;
            this.Path.Properties.Appearance.Options.UseForeColor = true;
            this.Path.Properties.AutoHeight = false;
            this.Path.Size = new System.Drawing.Size(486, 43);
            this.Path.TabIndex = 46;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(653, 32);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(49, 34);
            this.labelControl6.TabIndex = 45;
            this.labelControl6.Text = "المسار :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.simpleButton1.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.simpleButton1.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(12, 102);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(711, 43);
            this.simpleButton1.TabIndex = 50;
            this.simpleButton1.Text = "حفظ المسار";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.SelectedPath = "xtraFolderBrowserDialog1";
            // 
            // MediaPath
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 157);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "MediaPath";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعداد مسار حفظ الوسائط";
            this.Load += new System.EventHandler(this.MediaPath_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Path.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnBackBrow;
        private DevExpress.XtraEditors.TextEdit Path;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.XtraFolderBrowserDialog SaveFile;
    }
}