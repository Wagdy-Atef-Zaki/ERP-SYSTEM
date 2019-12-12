namespace ITI_Project.Forms.Supplier
{
    partial class SupplierUp
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
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.cusSupTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.project_DBDataSet = new ITI_Project.Project_DBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.SuppEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.SuppMobile = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.RTSName = new System.Windows.Forms.Label();
            this.SupName = new DevExpress.XtraEditors.TextEdit();
            this.SuppNote = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cusSupCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusSupNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusSupMobileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusSupEmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusSupNotesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cusSupTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.SuppCopm = new DevExpress.XtraEditors.TextEdit();
            this.cus_Sup_TableTableAdapter = new ITI_Project.Project_DBDataSetTableAdapters.Cus_Sup_TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.cusSupTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusSupTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuppCopm.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox4
            // 
            this.comboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox4.DataSource = this.cusSupTableBindingSource1;
            this.comboBox4.DisplayMember = "Cus_Sup_Name";
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(138, 10);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(335, 39);
            this.comboBox4.TabIndex = 76;
            this.comboBox4.ValueMember = "Cus_Sup_ID";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // cusSupTableBindingSource1
            // 
            this.cusSupTableBindingSource1.DataMember = "Cus_Sup_Table";
            this.cusSupTableBindingSource1.DataSource = this.project_DBDataSet;
            // 
            // project_DBDataSet
            // 
            this.project_DBDataSet.DataSetName = "Project_DBDataSet";
            this.project_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // SuppEmail
            // 
            this.SuppEmail.Location = new System.Drawing.Point(43, 190);
            this.SuppEmail.Name = "SuppEmail";
            this.SuppEmail.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppEmail.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.SuppEmail.Properties.Appearance.Options.UseFont = true;
            this.SuppEmail.Properties.Appearance.Options.UseForeColor = true;
            this.SuppEmail.Properties.AutoHeight = false;
            this.SuppEmail.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SuppEmail.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SuppEmail.Properties.Mask.BeepOnError = true;
            this.SuppEmail.Properties.Mask.EditMask = "";
            this.SuppEmail.Properties.Mask.IgnoreMaskBlank = false;
            this.SuppEmail.Properties.Mask.ShowPlaceHolders = false;
            this.SuppEmail.Properties.MaxLength = 11;
            this.SuppEmail.Size = new System.Drawing.Size(335, 44);
            this.SuppEmail.TabIndex = 55;
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
            // SuppMobile
            // 
            this.SuppMobile.Location = new System.Drawing.Point(43, 140);
            this.SuppMobile.Name = "SuppMobile";
            this.SuppMobile.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppMobile.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.SuppMobile.Properties.Appearance.Options.UseFont = true;
            this.SuppMobile.Properties.Appearance.Options.UseForeColor = true;
            this.SuppMobile.Properties.AutoHeight = false;
            this.SuppMobile.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SuppMobile.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SuppMobile.Properties.Mask.BeepOnError = true;
            this.SuppMobile.Properties.Mask.EditMask = "([0-9]{11})";
            this.SuppMobile.Properties.Mask.IgnoreMaskBlank = false;
            this.SuppMobile.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.SuppMobile.Properties.Mask.ShowPlaceHolders = false;
            this.SuppMobile.Properties.MaxLength = 11;
            this.SuppMobile.Size = new System.Drawing.Size(335, 44);
            this.SuppMobile.TabIndex = 53;
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
            // SupName
            // 
            this.SupName.Location = new System.Drawing.Point(43, 46);
            this.SupName.Name = "SupName";
            this.SupName.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F);
            this.SupName.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.SupName.Properties.Appearance.Options.UseFont = true;
            this.SupName.Properties.Appearance.Options.UseForeColor = true;
            this.SupName.Properties.AutoHeight = false;
            this.SupName.Size = new System.Drawing.Size(335, 46);
            this.SupName.TabIndex = 0;
            // 
            // SuppNote
            // 
            this.SuppNote.Location = new System.Drawing.Point(43, 240);
            this.SuppNote.Name = "SuppNote";
            this.SuppNote.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppNote.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.SuppNote.Properties.Appearance.Options.UseFont = true;
            this.SuppNote.Properties.Appearance.Options.UseForeColor = true;
            this.SuppNote.Properties.AutoHeight = false;
            this.SuppNote.Size = new System.Drawing.Size(335, 70);
            this.SuppNote.TabIndex = 3;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.simpleButton2.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.simpleButton2.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.simpleButton2.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton2.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton2.Location = new System.Drawing.Point(280, 574);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(236, 43);
            this.simpleButton2.TabIndex = 74;
            this.simpleButton2.Text = "حذف البيانات";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
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
            this.simpleButton1.Location = new System.Drawing.Point(14, 574);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(236, 43);
            this.simpleButton1.TabIndex = 73;
            this.simpleButton1.Text = "تحديث البيانات";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(14, 389);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(502, 177);
            this.dataGridView1.TabIndex = 72;
            // 
            // cusSupCompanyDataGridViewTextBoxColumn
            // 
            this.cusSupCompanyDataGridViewTextBoxColumn.DataPropertyName = "Cus_Sup_Company";
            this.cusSupCompanyDataGridViewTextBoxColumn.HeaderText = "اسم الشركة";
            this.cusSupCompanyDataGridViewTextBoxColumn.Name = "cusSupCompanyDataGridViewTextBoxColumn";
            this.cusSupCompanyDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusSupCompanyDataGridViewTextBoxColumn.Width = 84;
            // 
            // cusSupNameDataGridViewTextBoxColumn
            // 
            this.cusSupNameDataGridViewTextBoxColumn.DataPropertyName = "Cus_Sup_Name";
            this.cusSupNameDataGridViewTextBoxColumn.HeaderText = "اسم المورد";
            this.cusSupNameDataGridViewTextBoxColumn.Name = "cusSupNameDataGridViewTextBoxColumn";
            this.cusSupNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusSupNameDataGridViewTextBoxColumn.Width = 78;
            // 
            // cusSupMobileDataGridViewTextBoxColumn
            // 
            this.cusSupMobileDataGridViewTextBoxColumn.DataPropertyName = "Cus_Sup_Mobile";
            this.cusSupMobileDataGridViewTextBoxColumn.HeaderText = "رقم التليفون";
            this.cusSupMobileDataGridViewTextBoxColumn.Name = "cusSupMobileDataGridViewTextBoxColumn";
            this.cusSupMobileDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusSupMobileDataGridViewTextBoxColumn.Width = 81;
            // 
            // cusSupEmailDataGridViewTextBoxColumn
            // 
            this.cusSupEmailDataGridViewTextBoxColumn.DataPropertyName = "Cus_Sup_Email";
            this.cusSupEmailDataGridViewTextBoxColumn.HeaderText = "البريد الالكترونى";
            this.cusSupEmailDataGridViewTextBoxColumn.Name = "cusSupEmailDataGridViewTextBoxColumn";
            this.cusSupEmailDataGridViewTextBoxColumn.ReadOnly = true;
            this.cusSupEmailDataGridViewTextBoxColumn.Width = 97;
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
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(384, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(74, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اسم المورد :";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(58, 9);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(74, 34);
            this.labelControl5.TabIndex = 75;
            this.labelControl5.Text = "اسم المورد :";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.SuppCopm);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.SuppEmail);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.SuppMobile);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.RTSName);
            this.groupControl1.Controls.Add(this.SupName);
            this.groupControl1.Controls.Add(this.SuppNote);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(14, 55);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(502, 328);
            this.groupControl1.TabIndex = 71;
            this.groupControl1.Text = "البيانات";
            // 
            // SuppCopm
            // 
            this.SuppCopm.Location = new System.Drawing.Point(43, 98);
            this.SuppCopm.Name = "SuppCopm";
            this.SuppCopm.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SuppCopm.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.SuppCopm.Properties.Appearance.Options.UseFont = true;
            this.SuppCopm.Properties.Appearance.Options.UseForeColor = true;
            this.SuppCopm.Properties.AutoHeight = false;
            this.SuppCopm.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SuppCopm.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.SuppCopm.Properties.Mask.BeepOnError = true;
            this.SuppCopm.Properties.Mask.EditMask = "";
            this.SuppCopm.Properties.Mask.IgnoreMaskBlank = false;
            this.SuppCopm.Properties.Mask.ShowPlaceHolders = false;
            this.SuppCopm.Properties.MaxLength = 11;
            this.SuppCopm.Size = new System.Drawing.Size(335, 38);
            this.SuppCopm.TabIndex = 58;
            // 
            // cus_Sup_TableTableAdapter
            // 
            this.cus_Sup_TableTableAdapter.ClearBeforeFill = true;
            // 
            // SupplierUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 626);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SupplierUp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحديث بيانات المورد";
            this.Load += new System.EventHandler(this.SupplierUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cusSupTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SupName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SuppNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusSupTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SuppCopm.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit SuppEmail;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit SuppMobile;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.Label RTSName;
        private DevExpress.XtraEditors.TextEdit SupName;
        private DevExpress.XtraEditors.TextEdit SuppNote;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit SuppCopm;
        private Project_DBDataSet project_DBDataSet;
        private System.Windows.Forms.BindingSource cusSupTableBindingSource;
        private Project_DBDataSetTableAdapters.Cus_Sup_TableTableAdapter cus_Sup_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusSupCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusSupNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusSupMobileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusSupEmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cusSupNotesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cusSupTableBindingSource1;
    }
}