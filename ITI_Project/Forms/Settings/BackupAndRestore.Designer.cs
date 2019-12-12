namespace ITI_Project.Forms.Settings
{
    partial class BackupAndRestore
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
            this.folderBro = new DevExpress.XtraEditors.XtraFolderBrowserDialog(this.components);
            this.BtnBack = new DevExpress.XtraEditors.SimpleButton();
            this.btnBackBrow = new DevExpress.XtraEditors.SimpleButton();
            this.BackupPath = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.BrowseBackupLoca = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.SaveFile = new DevExpress.XtraEditors.XtraSaveFileDialog(this.components);
            this.BtnBackupRest = new DevExpress.XtraEditors.SimpleButton();
            this.BtnBrosBackRes = new DevExpress.XtraEditors.SimpleButton();
            this.BackupResPath = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.BackupPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupResPath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBro
            // 
            this.folderBro.SelectedPath = "xtraFolderBrowserDialog1";
            // 
            // BtnBack
            // 
            this.BtnBack.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.BtnBack.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBack.Appearance.Options.UseBackColor = true;
            this.BtnBack.Appearance.Options.UseFont = true;
            this.BtnBack.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.BtnBack.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.BtnBack.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.BtnBack.AppearanceHovered.Options.UseBackColor = true;
            this.BtnBack.AppearanceHovered.Options.UseBorderColor = true;
            this.BtnBack.Enabled = false;
            this.BtnBack.Location = new System.Drawing.Point(21, 102);
            this.BtnBack.Name = "BtnBack";
            this.BtnBack.Size = new System.Drawing.Size(732, 43);
            this.BtnBack.TabIndex = 39;
            this.BtnBack.Text = "عمل النسخة الاحتياطية ";
            this.BtnBack.Click += new System.EventHandler(this.BtnBack_Click);
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
            this.btnBackBrow.Location = new System.Drawing.Point(21, 53);
            this.btnBackBrow.Name = "btnBackBrow";
            this.btnBackBrow.Size = new System.Drawing.Size(149, 43);
            this.btnBackBrow.TabIndex = 25;
            this.btnBackBrow.Text = "استعراض";
            this.btnBackBrow.Click += new System.EventHandler(this.btnBackBrow_Click);
            // 
            // BackupPath
            // 
            this.BackupPath.Enabled = false;
            this.BackupPath.Location = new System.Drawing.Point(176, 53);
            this.BackupPath.Name = "BackupPath";
            this.BackupPath.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupPath.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BackupPath.Properties.Appearance.Options.UseFont = true;
            this.BackupPath.Properties.Appearance.Options.UseForeColor = true;
            this.BackupPath.Properties.AutoHeight = false;
            this.BackupPath.Size = new System.Drawing.Size(482, 43);
            this.BackupPath.TabIndex = 38;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(664, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 34);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "مسار الحفظ :";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.BtnBack);
            this.groupControl2.Controls.Add(this.btnBackBrow);
            this.groupControl2.Controls.Add(this.BackupPath);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(12, 172);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(763, 158);
            this.groupControl2.TabIndex = 44;
            this.groupControl2.Text = "اعدادات عمل نسخة احتياطية ";
            // 
            // BrowseBackupLoca
            // 
            this.BrowseBackupLoca.FileName = "xtraOpenFileDialog1";
            // 
            // SaveFile
            // 
            this.SaveFile.FileName = "xtraSaveFileDialog1";
            // 
            // BtnBackupRest
            // 
            this.BtnBackupRest.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.BtnBackupRest.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBackupRest.Appearance.Options.UseBackColor = true;
            this.BtnBackupRest.Appearance.Options.UseFont = true;
            this.BtnBackupRest.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.BtnBackupRest.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.BtnBackupRest.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.BtnBackupRest.AppearanceHovered.Options.UseBackColor = true;
            this.BtnBackupRest.AppearanceHovered.Options.UseBorderColor = true;
            this.BtnBackupRest.Enabled = false;
            this.BtnBackupRest.Location = new System.Drawing.Point(21, 102);
            this.BtnBackupRest.Name = "BtnBackupRest";
            this.BtnBackupRest.Size = new System.Drawing.Size(732, 43);
            this.BtnBackupRest.TabIndex = 39;
            this.BtnBackupRest.Text = "استرجاع النسخة الاحتياطية ";
            this.BtnBackupRest.Click += new System.EventHandler(this.BtnBackupRest_Click);
            // 
            // BtnBrosBackRes
            // 
            this.BtnBrosBackRes.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.BtnBrosBackRes.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBrosBackRes.Appearance.Options.UseBackColor = true;
            this.BtnBrosBackRes.Appearance.Options.UseFont = true;
            this.BtnBrosBackRes.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.BtnBrosBackRes.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.BtnBrosBackRes.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.BtnBrosBackRes.AppearanceHovered.Options.UseBackColor = true;
            this.BtnBrosBackRes.AppearanceHovered.Options.UseBorderColor = true;
            this.BtnBrosBackRes.Location = new System.Drawing.Point(21, 53);
            this.BtnBrosBackRes.Name = "BtnBrosBackRes";
            this.BtnBrosBackRes.Size = new System.Drawing.Size(149, 43);
            this.BtnBrosBackRes.TabIndex = 25;
            this.BtnBrosBackRes.Text = "استعراض";
            // 
            // BackupResPath
            // 
            this.BackupResPath.Enabled = false;
            this.BackupResPath.Location = new System.Drawing.Point(176, 53);
            this.BackupResPath.Name = "BackupResPath";
            this.BackupResPath.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupResPath.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.BackupResPath.Properties.Appearance.Options.UseFont = true;
            this.BackupResPath.Properties.Appearance.Options.UseForeColor = true;
            this.BackupResPath.Properties.AutoHeight = false;
            this.BackupResPath.Size = new System.Drawing.Size(482, 43);
            this.BackupResPath.TabIndex = 38;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(664, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "مسار الملف :";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.BtnBackupRest);
            this.groupControl1.Controls.Add(this.BtnBrosBackRes);
            this.groupControl1.Controls.Add(this.BackupResPath);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 8);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(763, 158);
            this.groupControl1.TabIndex = 43;
            this.groupControl1.Text = "اعدادات  استرجاع نسخة احتياطية ";
            // 
            // BackupAndRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 345);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "BackupAndRestore";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اعدادات النسخة الاحتياطية واسترجاع الملفات";
            this.Load += new System.EventHandler(this.BackupAndRestore_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BackupPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupResPath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraFolderBrowserDialog folderBro;
        private DevExpress.XtraEditors.SimpleButton BtnBack;
        private DevExpress.XtraEditors.SimpleButton btnBackBrow;
        private DevExpress.XtraEditors.TextEdit BackupPath;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.XtraOpenFileDialog BrowseBackupLoca;
        private DevExpress.XtraEditors.XtraSaveFileDialog SaveFile;
        private DevExpress.XtraEditors.SimpleButton BtnBackupRest;
        private DevExpress.XtraEditors.SimpleButton BtnBrosBackRes;
        private DevExpress.XtraEditors.TextEdit BackupResPath;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}