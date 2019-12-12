namespace ITI_Project.Forms.Customer
{
    partial class CustomerAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.CusEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.CusMobile = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.RTSName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cusSupCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusSupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusSupMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusSupEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusSupNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusSupTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_DBDataSet = new ITI_Project.Project_DBDataSet();
            this.CusName = new DevExpress.XtraEditors.TextEdit();
            this.CusNotes = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.CusComp = new DevExpress.XtraEditors.TextEdit();
            this.cus_Sup_TableTableAdapter = new ITI_Project.Project_DBDataSetTableAdapters.Cus_Sup_TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.CusEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusSupTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CusComp.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(14, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "*";
            this.label1.Visible = false;
            // 
            // CusEmail
            // 
            this.CusEmail.Location = new System.Drawing.Point(43, 190);
            this.CusEmail.Name = "CusEmail";
            this.CusEmail.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusEmail.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.CusEmail.Properties.Appearance.Options.UseFont = true;
            this.CusEmail.Properties.Appearance.Options.UseForeColor = true;
            this.CusEmail.Properties.AutoHeight = false;
            this.CusEmail.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CusEmail.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CusEmail.Properties.Mask.BeepOnError = true;
            this.CusEmail.Properties.Mask.EditMask = "";
            this.CusEmail.Properties.Mask.IgnoreMaskBlank = false;
            this.CusEmail.Properties.Mask.ShowPlaceHolders = false;
            this.CusEmail.Properties.MaxLength = 11;
            this.CusEmail.Size = new System.Drawing.Size(335, 44);
            this.CusEmail.TabIndex = 55;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(384, 193);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(92, 34);
            this.labelControl4.TabIndex = 54;
            this.labelControl4.Text = "بريد الكترونى :";
            // 
            // CusMobile
            // 
            this.CusMobile.Location = new System.Drawing.Point(43, 140);
            this.CusMobile.Name = "CusMobile";
            this.CusMobile.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusMobile.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.CusMobile.Properties.Appearance.Options.UseFont = true;
            this.CusMobile.Properties.Appearance.Options.UseForeColor = true;
            this.CusMobile.Properties.AutoHeight = false;
            this.CusMobile.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CusMobile.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CusMobile.Properties.Mask.BeepOnError = true;
            this.CusMobile.Properties.Mask.EditMask = "([0-9]{11})";
            this.CusMobile.Properties.Mask.IgnoreMaskBlank = false;
            this.CusMobile.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.CusMobile.Properties.Mask.ShowPlaceHolders = false;
            this.CusMobile.Properties.MaxLength = 11;
            this.CusMobile.Size = new System.Drawing.Size(335, 44);
            this.CusMobile.TabIndex = 53;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(384, 143);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 34);
            this.labelControl3.TabIndex = 52;
            this.labelControl3.Text = "رقم تليفون :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(384, 99);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(80, 34);
            this.labelControl6.TabIndex = 50;
            this.labelControl6.Text = "اسم الشركة :";
            // 
            // RTSName
            // 
            this.RTSName.AutoSize = true;
            this.RTSName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTSName.ForeColor = System.Drawing.Color.Red;
            this.RTSName.Location = new System.Drawing.Point(14, 51);
            this.RTSName.Name = "RTSName";
            this.RTSName.Size = new System.Drawing.Size(23, 25);
            this.RTSName.TabIndex = 27;
            this.RTSName.Text = "*";
            this.RTSName.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cusSupCompanyDataGridViewTextBoxColumn,
            this.cusSupNameDataGridViewTextBoxColumn,
            this.cusSupMobileDataGridViewTextBoxColumn,
            this.cusSupEmailDataGridViewTextBoxColumn,
            this.cusSupNotesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cusSupTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 346);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(502, 177);
            this.dataGridView1.TabIndex = 20;
            // 
            // cusSupCompanyDataGridViewTextBoxColumn
            // 
            this.cusSupCompanyDataGridViewTextBoxColumn.DataPropertyName = "Cus_Sup_Company";
            this.cusSupCompanyDataGridViewTextBoxColumn.HeaderText = "اسم الشركة";
            this.cusSupCompanyDataGridViewTextBoxColumn.Name = "cusSupCompanyDataGridViewTextBoxColumn";
            this.cusSupCompanyDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusSupCompanyDataGridViewTextBoxColumn.Width = 91;
            // 
            // cusSupNameDataGridViewTextBoxColumn
            // 
            this.cusSupNameDataGridViewTextBoxColumn.DataPropertyName = "Cus_Sup_Name";
            this.cusSupNameDataGridViewTextBoxColumn.HeaderText = "اسم العميل";
            this.cusSupNameDataGridViewTextBoxColumn.Name = "cusSupNameDataGridViewTextBoxColumn";
            this.cusSupNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusSupNameDataGridViewTextBoxColumn.Width = 88;
            // 
            // cusSupMobileDataGridViewTextBoxColumn
            // 
            this.cusSupMobileDataGridViewTextBoxColumn.DataPropertyName = "Cus_Sup_Mobile";
            this.cusSupMobileDataGridViewTextBoxColumn.HeaderText = "رقم تليفون";
            this.cusSupMobileDataGridViewTextBoxColumn.Name = "cusSupMobileDataGridViewTextBoxColumn";
            this.cusSupMobileDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusSupMobileDataGridViewTextBoxColumn.Width = 81;
            // 
            // cusSupEmailDataGridViewTextBoxColumn
            // 
            this.cusSupEmailDataGridViewTextBoxColumn.DataPropertyName = "Cus_Sup_Email";
            this.cusSupEmailDataGridViewTextBoxColumn.HeaderText = "بريد الكترونى";
            this.cusSupEmailDataGridViewTextBoxColumn.Name = "cusSupEmailDataGridViewTextBoxColumn";
            this.cusSupEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusSupEmailDataGridViewTextBoxColumn.Width = 92;
            // 
            // cusSupNotesDataGridViewTextBoxColumn
            // 
            this.cusSupNotesDataGridViewTextBoxColumn.DataPropertyName = "Cus_Sup_Notes";
            this.cusSupNotesDataGridViewTextBoxColumn.HeaderText = "ملاحظات";
            this.cusSupNotesDataGridViewTextBoxColumn.Name = "cusSupNotesDataGridViewTextBoxColumn";
            this.cusSupNotesDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusSupNotesDataGridViewTextBoxColumn.Width = 73;
            // 
            // cusSupTableBindingSource
            // 
            this.cusSupTableBindingSource.DataMember = "Cus_Sup_Table";
            this.cusSupTableBindingSource.DataSource = this.project_DBDataSet;
            // 
            // project_DBDataSet
            // 
            this.project_DBDataSet.DataSetName = "Project_DBDataSet";
            this.project_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CusName
            // 
            this.CusName.Location = new System.Drawing.Point(43, 46);
            this.CusName.Name = "CusName";
            this.CusName.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F);
            this.CusName.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.CusName.Properties.Appearance.Options.UseFont = true;
            this.CusName.Properties.Appearance.Options.UseForeColor = true;
            this.CusName.Properties.AutoHeight = false;
            this.CusName.Size = new System.Drawing.Size(335, 46);
            this.CusName.TabIndex = 0;
            // 
            // CusNotes
            // 
            this.CusNotes.Location = new System.Drawing.Point(43, 240);
            this.CusNotes.Name = "CusNotes";
            this.CusNotes.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusNotes.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.CusNotes.Properties.Appearance.Options.UseFont = true;
            this.CusNotes.Properties.Appearance.Options.UseForeColor = true;
            this.CusNotes.Properties.AutoHeight = false;
            this.CusNotes.Size = new System.Drawing.Size(335, 70);
            this.CusNotes.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(384, 251);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 34);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "ملاحظات :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(384, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اسم العميل :";
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
            this.simpleButton1.Location = new System.Drawing.Point(14, 532);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(502, 43);
            this.simpleButton1.TabIndex = 21;
            this.simpleButton1.Text = "اضافة البيانات";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.CusComp);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.CusEmail);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.CusMobile);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.RTSName);
            this.groupControl1.Controls.Add(this.CusName);
            this.groupControl1.Controls.Add(this.CusNotes);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(14, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(502, 328);
            this.groupControl1.TabIndex = 19;
            this.groupControl1.Text = "البيانات";
            // 
            // CusComp
            // 
            this.CusComp.Location = new System.Drawing.Point(44, 96);
            this.CusComp.Name = "CusComp";
            this.CusComp.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusComp.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.CusComp.Properties.Appearance.Options.UseFont = true;
            this.CusComp.Properties.Appearance.Options.UseForeColor = true;
            this.CusComp.Properties.AutoHeight = false;
            this.CusComp.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CusComp.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.CusComp.Properties.Mask.BeepOnError = true;
            this.CusComp.Properties.Mask.EditMask = "";
            this.CusComp.Properties.Mask.IgnoreMaskBlank = false;
            this.CusComp.Properties.Mask.ShowPlaceHolders = false;
            this.CusComp.Properties.MaxLength = 11;
            this.CusComp.Size = new System.Drawing.Size(335, 38);
            this.CusComp.TabIndex = 57;
            // 
            // cus_Sup_TableTableAdapter
            // 
            this.cus_Sup_TableTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 587);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CustomerAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة بيانات العميل";
            this.Load += new System.EventHandler(this.CustomerAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CusEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusSupTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CusComp.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit CusEmail;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit CusMobile;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Label RTSName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.TextEdit CusName;
        private DevExpress.XtraEditors.TextEdit CusNotes;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit CusComp;
        private Project_DBDataSet project_DBDataSet;
        private System.Windows.Forms.BindingSource cusSupTableBindingSource;
        private Project_DBDataSetTableAdapters.Cus_Sup_TableTableAdapter cus_Sup_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusSupCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusSupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusSupMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusSupEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusSupNotesDataGridViewTextBoxColumn;
    }
}