namespace ITI_Project.Forms.Money
{
    partial class PayRevTypesAdd
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
            this.Ident = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.RTSName = new System.Windows.Forms.Label();
            this.PaTypeName = new DevExpress.XtraEditors.TextEdit();
            this.PayTypeDes = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.flagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payRevTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payRevTypeDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payRevTypeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_DBDataSet = new ITI_Project.Project_DBDataSet();
            this.pay_Rev_Type_TableTableAdapter = new ITI_Project.Project_DBDataSetTableAdapters.Pay_Rev_Type_TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayTypeDes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payRevTypeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.Ident);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.RTSName);
            this.groupControl1.Controls.Add(this.PaTypeName);
            this.groupControl1.Controls.Add(this.PayTypeDes);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(15, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(502, 227);
            this.groupControl1.TabIndex = 22;
            this.groupControl1.Text = "البيانات";
            // 
            // Ident
            // 
            this.Ident.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Ident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ident.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ident.FormattingEnabled = true;
            this.Ident.Items.AddRange(new object[] {
            "مصروفات",
            "ايرادات"});
            this.Ident.Location = new System.Drawing.Point(46, 45);
            this.Ident.Name = "Ident";
            this.Ident.Size = new System.Drawing.Size(335, 39);
            this.Ident.TabIndex = 72;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(405, 45);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 34);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "نوع البند :";
            // 
            // RTSName
            // 
            this.RTSName.AutoSize = true;
            this.RTSName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTSName.ForeColor = System.Drawing.Color.Red;
            this.RTSName.Location = new System.Drawing.Point(17, 97);
            this.RTSName.Name = "RTSName";
            this.RTSName.Size = new System.Drawing.Size(23, 25);
            this.RTSName.TabIndex = 27;
            this.RTSName.Text = "*";
            this.RTSName.Visible = false;
            // 
            // PaTypeName
            // 
            this.PaTypeName.Location = new System.Drawing.Point(46, 92);
            this.PaTypeName.Name = "PaTypeName";
            this.PaTypeName.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F);
            this.PaTypeName.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.PaTypeName.Properties.Appearance.Options.UseFont = true;
            this.PaTypeName.Properties.Appearance.Options.UseForeColor = true;
            this.PaTypeName.Properties.AutoHeight = false;
            this.PaTypeName.Size = new System.Drawing.Size(335, 46);
            this.PaTypeName.TabIndex = 0;
            // 
            // PayTypeDes
            // 
            this.PayTypeDes.Location = new System.Drawing.Point(46, 148);
            this.PayTypeDes.Name = "PayTypeDes";
            this.PayTypeDes.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayTypeDes.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.PayTypeDes.Properties.Appearance.Options.UseFont = true;
            this.PayTypeDes.Properties.Appearance.Options.UseForeColor = true;
            this.PayTypeDes.Properties.AutoHeight = false;
            this.PayTypeDes.Size = new System.Drawing.Size(335, 70);
            this.PayTypeDes.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(405, 150);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 34);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "الوصف :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(405, 97);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(66, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اسم البند :";
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
            this.simpleButton1.Location = new System.Drawing.Point(15, 462);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(502, 43);
            this.simpleButton1.TabIndex = 24;
            this.simpleButton1.Text = "اضافة البيانات";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flagDataGridViewTextBoxColumn,
            this.payRevTypeNameDataGridViewTextBoxColumn,
            this.payRevTypeDescriptionDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.payRevTypeTableBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 258);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(504, 195);
            this.dataGridView2.TabIndex = 25;
            // 
            // flagDataGridViewTextBoxColumn
            // 
            this.flagDataGridViewTextBoxColumn.DataPropertyName = "Flag";
            this.flagDataGridViewTextBoxColumn.HeaderText = "نوع البند";
            this.flagDataGridViewTextBoxColumn.Name = "flagDataGridViewTextBoxColumn";
            this.flagDataGridViewTextBoxColumn.ReadOnly = true;
            this.flagDataGridViewTextBoxColumn.Width = 70;
            // 
            // payRevTypeNameDataGridViewTextBoxColumn
            // 
            this.payRevTypeNameDataGridViewTextBoxColumn.DataPropertyName = "Pay_Rev_Type_Name";
            this.payRevTypeNameDataGridViewTextBoxColumn.HeaderText = "اسم البند";
            this.payRevTypeNameDataGridViewTextBoxColumn.Name = "payRevTypeNameDataGridViewTextBoxColumn";
            this.payRevTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.payRevTypeNameDataGridViewTextBoxColumn.Width = 77;
            // 
            // payRevTypeDescriptionDataGridViewTextBoxColumn
            // 
            this.payRevTypeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Pay_Rev_Type_Description";
            this.payRevTypeDescriptionDataGridViewTextBoxColumn.HeaderText = "الوصف";
            this.payRevTypeDescriptionDataGridViewTextBoxColumn.Name = "payRevTypeDescriptionDataGridViewTextBoxColumn";
            this.payRevTypeDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.payRevTypeDescriptionDataGridViewTextBoxColumn.Width = 62;
            // 
            // payRevTypeTableBindingSource
            // 
            this.payRevTypeTableBindingSource.DataMember = "Pay_Rev_Type_Table";
            this.payRevTypeTableBindingSource.DataSource = this.project_DBDataSet;
            // 
            // project_DBDataSet
            // 
            this.project_DBDataSet.DataSetName = "Project_DBDataSet";
            this.project_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pay_Rev_Type_TableTableAdapter
            // 
            this.pay_Rev_Type_TableTableAdapter.ClearBeforeFill = true;
            // 
            // PayRevTypesAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 517);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dataGridView2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "PayRevTypesAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة بنود مصروفات / ايرادات";
            this.Load += new System.EventHandler(this.PayRevTypesAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PaTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayTypeDes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payRevTypeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox Ident;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Label RTSName;
        private DevExpress.XtraEditors.TextEdit PaTypeName;
        private DevExpress.XtraEditors.TextEdit PayTypeDes;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Project_DBDataSet project_DBDataSet;
        private System.Windows.Forms.BindingSource payRevTypeTableBindingSource;
        private Project_DBDataSetTableAdapters.Pay_Rev_Type_TableTableAdapter pay_Rev_Type_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payRevTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payRevTypeDescriptionDataGridViewTextBoxColumn;
    }
}