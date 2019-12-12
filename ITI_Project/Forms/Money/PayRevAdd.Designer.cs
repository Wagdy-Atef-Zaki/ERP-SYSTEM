namespace ITI_Project.Forms.Money
{
    partial class PayRevAdd
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
            this.comboBoxEdit5 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ComPand = new System.Windows.Forms.ComboBox();
            this.payRevTypeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_DBDataSet = new ITI_Project.Project_DBDataSet();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Data = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.RTSName = new System.Windows.Forms.Label();
            this.TXTValue = new DevExpress.XtraEditors.TextEdit();
            this.TXTDes = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payRevTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payRevDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payRevAmountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payRevDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payRevTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_DBDataSet1 = new ITI_Project.Project_DBDataSet();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.pay_Rev_Type_TableTableAdapter = new ITI_Project.Project_DBDataSetTableAdapters.Pay_Rev_Type_TableTableAdapter();
            this.pay_Rev_TableTableAdapter = new ITI_Project.Project_DBDataSetTableAdapters.Pay_Rev_TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.payRevTypeTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTValue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTDes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payRevTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxEdit5
            // 
            this.comboBoxEdit5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEdit5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEdit5.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEdit5.FormattingEnabled = true;
            this.comboBoxEdit5.Items.AddRange(new object[] {
            "مصروفات",
            "ايرادات"});
            this.comboBoxEdit5.Location = new System.Drawing.Point(419, 51);
            this.comboBoxEdit5.Name = "comboBoxEdit5";
            this.comboBoxEdit5.Size = new System.Drawing.Size(281, 39);
            this.comboBoxEdit5.TabIndex = 73;
            this.comboBoxEdit5.SelectedIndexChanged += new System.EventHandler(this.comboBoxEdit5_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(5, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 70;
            this.label1.Text = "*";
            this.label1.Visible = false;
            // 
            // ComPand
            // 
            this.ComPand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComPand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComPand.DataSource = this.payRevTypeTableBindingSource;
            this.ComPand.DisplayMember = "Pay_Rev_Type_Name";
            this.ComPand.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComPand.ForeColor = System.Drawing.Color.Black;
            this.ComPand.FormattingEnabled = true;
            this.ComPand.Location = new System.Drawing.Point(32, 48);
            this.ComPand.Name = "ComPand";
            this.ComPand.Size = new System.Drawing.Size(281, 39);
            this.ComPand.TabIndex = 69;
            this.ComPand.ValueMember = "Pay_Rev_Type_ID";
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
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(337, 100);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(49, 34);
            this.labelControl5.TabIndex = 38;
            this.labelControl5.Text = "التاريخ :";
            // 
            // Data
            // 
            this.Data.EditValue = null;
            this.Data.Location = new System.Drawing.Point(32, 99);
            this.Data.Name = "Data";
            this.Data.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.Data.Properties.Appearance.Options.UseFont = true;
            this.Data.Properties.AutoHeight = false;
            this.Data.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Data.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Data.Size = new System.Drawing.Size(281, 42);
            this.Data.TabIndex = 37;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(337, 49);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(38, 34);
            this.labelControl4.TabIndex = 34;
            this.labelControl4.Text = "البند :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(724, 49);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(63, 34);
            this.labelControl3.TabIndex = 28;
            this.labelControl3.Text = "نوع المبلغ :";
            // 
            // RTSName
            // 
            this.RTSName.AutoSize = true;
            this.RTSName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTSName.ForeColor = System.Drawing.Color.Red;
            this.RTSName.Location = new System.Drawing.Point(390, 110);
            this.RTSName.Name = "RTSName";
            this.RTSName.Size = new System.Drawing.Size(23, 25);
            this.RTSName.TabIndex = 27;
            this.RTSName.Text = "*";
            this.RTSName.Visible = false;
            // 
            // TXTValue
            // 
            this.TXTValue.Location = new System.Drawing.Point(419, 96);
            this.TXTValue.Name = "TXTValue";
            this.TXTValue.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F);
            this.TXTValue.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TXTValue.Properties.Appearance.Options.UseFont = true;
            this.TXTValue.Properties.Appearance.Options.UseForeColor = true;
            this.TXTValue.Properties.AutoHeight = false;
            this.TXTValue.Properties.Mask.BeepOnError = true;
            this.TXTValue.Properties.Mask.EditMask = "c";
            this.TXTValue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.TXTValue.Size = new System.Drawing.Size(281, 46);
            this.TXTValue.TabIndex = 0;
            // 
            // TXTDes
            // 
            this.TXTDes.Location = new System.Drawing.Point(17, 152);
            this.TXTDes.Name = "TXTDes";
            this.TXTDes.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXTDes.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.TXTDes.Properties.Appearance.Options.UseFont = true;
            this.TXTDes.Properties.Appearance.Options.UseForeColor = true;
            this.TXTDes.Properties.AutoHeight = false;
            this.TXTDes.Size = new System.Drawing.Size(683, 81);
            this.TXTDes.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(724, 154);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 34);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "البيان :";
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
            this.simpleButton1.Location = new System.Drawing.Point(12, 454);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(806, 43);
            this.simpleButton1.TabIndex = 23;
            this.simpleButton1.Text = "اضافة البيانات";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            this.flagDataGridViewTextBoxColumn,
            this.payRevTypeNameDataGridViewTextBoxColumn,
            this.payRevDateDataGridViewTextBoxColumn,
            this.payRevAmountDataGridViewTextBoxColumn,
            this.payRevDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.payRevTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(806, 172);
            this.dataGridView1.TabIndex = 22;
            // 
            // flagDataGridViewTextBoxColumn
            // 
            this.flagDataGridViewTextBoxColumn.DataPropertyName = "Flag";
            this.flagDataGridViewTextBoxColumn.HeaderText = "نوع المبلغ";
            this.flagDataGridViewTextBoxColumn.Name = "flagDataGridViewTextBoxColumn";
            this.flagDataGridViewTextBoxColumn.ReadOnly = true;
            this.flagDataGridViewTextBoxColumn.Width = 77;
            // 
            // payRevTypeNameDataGridViewTextBoxColumn
            // 
            this.payRevTypeNameDataGridViewTextBoxColumn.DataPropertyName = "Pay_Rev_Type_Name";
            this.payRevTypeNameDataGridViewTextBoxColumn.HeaderText = "البند";
            this.payRevTypeNameDataGridViewTextBoxColumn.Name = "payRevTypeNameDataGridViewTextBoxColumn";
            this.payRevTypeNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.payRevTypeNameDataGridViewTextBoxColumn.Width = 52;
            // 
            // payRevDateDataGridViewTextBoxColumn
            // 
            this.payRevDateDataGridViewTextBoxColumn.DataPropertyName = "Pay_Rev_Date";
            this.payRevDateDataGridViewTextBoxColumn.HeaderText = "التاريخ";
            this.payRevDateDataGridViewTextBoxColumn.Name = "payRevDateDataGridViewTextBoxColumn";
            this.payRevDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.payRevDateDataGridViewTextBoxColumn.Width = 60;
            // 
            // payRevAmountDataGridViewTextBoxColumn
            // 
            this.payRevAmountDataGridViewTextBoxColumn.DataPropertyName = "Pay_Rev_Amount";
            this.payRevAmountDataGridViewTextBoxColumn.HeaderText = "المبلغ";
            this.payRevAmountDataGridViewTextBoxColumn.Name = "payRevAmountDataGridViewTextBoxColumn";
            this.payRevAmountDataGridViewTextBoxColumn.ReadOnly = true;
            this.payRevAmountDataGridViewTextBoxColumn.Width = 59;
            // 
            // payRevDescriptionDataGridViewTextBoxColumn
            // 
            this.payRevDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Pay_Rev_Description";
            this.payRevDescriptionDataGridViewTextBoxColumn.HeaderText = "البيان";
            this.payRevDescriptionDataGridViewTextBoxColumn.Name = "payRevDescriptionDataGridViewTextBoxColumn";
            this.payRevDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.payRevDescriptionDataGridViewTextBoxColumn.Width = 56;
            // 
            // payRevTableBindingSource
            // 
            this.payRevTableBindingSource.DataMember = "Pay_Rev_Table";
            this.payRevTableBindingSource.DataSource = this.project_DBDataSet1;
            // 
            // project_DBDataSet1
            // 
            this.project_DBDataSet1.DataSetName = "Project_DBDataSet";
            this.project_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(724, 101);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "المبلغ :";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.comboBoxEdit5);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.ComPand);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.Data);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.RTSName);
            this.groupControl1.Controls.Add(this.TXTValue);
            this.groupControl1.Controls.Add(this.TXTDes);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 9);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(806, 248);
            this.groupControl1.TabIndex = 21;
            this.groupControl1.Text = "البيانات";
            // 
            // pay_Rev_Type_TableTableAdapter
            // 
            this.pay_Rev_Type_TableTableAdapter.ClearBeforeFill = true;
            // 
            // pay_Rev_TableTableAdapter
            // 
            this.pay_Rev_TableTableAdapter.ClearBeforeFill = true;
            // 
            // PayRevAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 507);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "PayRevAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة مصروفات / ايرادات";
            this.Load += new System.EventHandler(this.PayRevAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.payRevTypeTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTValue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTDes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payRevTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEdit5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComPand;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.DateEdit Data;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Label RTSName;
        private DevExpress.XtraEditors.TextEdit TXTValue;
        private DevExpress.XtraEditors.TextEdit TXTDes;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private Project_DBDataSet project_DBDataSet;
        private System.Windows.Forms.BindingSource payRevTypeTableBindingSource;
        private Project_DBDataSetTableAdapters.Pay_Rev_Type_TableTableAdapter pay_Rev_Type_TableTableAdapter;
        private Project_DBDataSet project_DBDataSet1;
        private System.Windows.Forms.BindingSource payRevTableBindingSource;
        private Project_DBDataSetTableAdapters.Pay_Rev_TableTableAdapter pay_Rev_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payRevTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payRevDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payRevAmountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payRevDescriptionDataGridViewTextBoxColumn;

    }
}