namespace ITI_Project.Forms.Money
{
    partial class PayRevTypesUp
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.flagDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payRevTypeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payRevTypeDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payRevTypeTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.project_DBDataSet = new ITI_Project.Project_DBDataSet();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.comboBoxEdit5 = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.RTSName = new System.Windows.Forms.Label();
            this.PaytYName = new DevExpress.XtraEditors.TextEdit();
            this.PayTypDes = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.payRevTypeTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pay_Rev_Type_TableTableAdapter = new ITI_Project.Project_DBDataSetTableAdapters.Pay_Rev_Type_TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payRevTypeTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaytYName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayTypDes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payRevTypeTableBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.payRevTypeDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.payRevTypeTableBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(502, 195);
            this.dataGridView1.TabIndex = 44;
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
            this.payRevTypeDescriptionDataGridViewTextBoxColumn.HeaderText = "وصف البند";
            this.payRevTypeDescriptionDataGridViewTextBoxColumn.Name = "payRevTypeDescriptionDataGridViewTextBoxColumn";
            this.payRevTypeDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.payRevTypeDescriptionDataGridViewTextBoxColumn.Width = 79;
            // 
            // payRevTypeTableBindingSource1
            // 
            this.payRevTypeTableBindingSource1.DataMember = "Pay_Rev_Type_Table";
            this.payRevTypeTableBindingSource1.DataSource = this.project_DBDataSet;
            // 
            // project_DBDataSet
            // 
            this.project_DBDataSet.DataSetName = "Project_DBDataSet";
            this.project_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(47, 17);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 34);
            this.labelControl4.TabIndex = 41;
            this.labelControl4.Text = "اسم البند :";
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
            this.simpleButton2.Location = new System.Drawing.Point(282, 500);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(236, 43);
            this.simpleButton2.TabIndex = 39;
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
            this.simpleButton1.Location = new System.Drawing.Point(16, 500);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(236, 43);
            this.simpleButton1.TabIndex = 38;
            this.simpleButton1.Text = "تحديث البيانات";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
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
            this.comboBoxEdit5.Location = new System.Drawing.Point(46, 44);
            this.comboBoxEdit5.Name = "comboBoxEdit5";
            this.comboBoxEdit5.Size = new System.Drawing.Size(335, 39);
            this.comboBoxEdit5.TabIndex = 71;
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
            // PaytYName
            // 
            this.PaytYName.Location = new System.Drawing.Point(46, 92);
            this.PaytYName.Name = "PaytYName";
            this.PaytYName.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F);
            this.PaytYName.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.PaytYName.Properties.Appearance.Options.UseFont = true;
            this.PaytYName.Properties.Appearance.Options.UseForeColor = true;
            this.PaytYName.Properties.AutoHeight = false;
            this.PaytYName.Size = new System.Drawing.Size(335, 46);
            this.PaytYName.TabIndex = 0;
            // 
            // PayTypDes
            // 
            this.PayTypDes.Location = new System.Drawing.Point(46, 148);
            this.PayTypDes.Name = "PayTypDes";
            this.PayTypDes.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PayTypDes.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.PayTypDes.Properties.Appearance.Options.UseFont = true;
            this.PayTypDes.Properties.Appearance.Options.UseForeColor = true;
            this.PayTypDes.Properties.AutoHeight = false;
            this.PayTypDes.Size = new System.Drawing.Size(335, 70);
            this.PayTypDes.TabIndex = 3;
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
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.comboBoxEdit5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.RTSName);
            this.groupControl1.Controls.Add(this.PaytYName);
            this.groupControl1.Controls.Add(this.PayTypDes);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(16, 56);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(502, 227);
            this.groupControl1.TabIndex = 37;
            this.groupControl1.Text = "البيانات";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.payRevTypeTableBindingSource;
            this.comboBox1.DisplayMember = "Pay_Rev_Type_Name";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(137, 7);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(335, 39);
            this.comboBox1.TabIndex = 72;
            this.comboBox1.ValueMember = "Pay_Rev_Type_ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // payRevTypeTableBindingSource
            // 
            this.payRevTypeTableBindingSource.DataMember = "Pay_Rev_Type_Table";
            this.payRevTypeTableBindingSource.DataSource = this.project_DBDataSet;
            // 
            // pay_Rev_Type_TableTableAdapter
            // 
            this.pay_Rev_Type_TableTableAdapter.ClearBeforeFill = true;
            // 
            // PayRevTypesUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 555);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "PayRevTypesUp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحديث بيانات البنود";
            this.Load += new System.EventHandler(this.PayRevTypesUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payRevTypeTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PaytYName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PayTypDes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.payRevTypeTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.ComboBox comboBoxEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.Label RTSName;
        private DevExpress.XtraEditors.TextEdit PaytYName;
        private DevExpress.XtraEditors.TextEdit PayTypDes;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.ComboBox comboBox1;
        private Project_DBDataSet project_DBDataSet;
        private System.Windows.Forms.BindingSource payRevTypeTableBindingSource;
        private Project_DBDataSetTableAdapters.Pay_Rev_Type_TableTableAdapter pay_Rev_Type_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn flagDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payRevTypeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn payRevTypeDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource payRevTypeTableBindingSource1;

    }
}