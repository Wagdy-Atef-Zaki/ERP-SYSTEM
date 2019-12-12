namespace ITI_Project.Forms.Product
{
    partial class CatagoryUp
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
            this.RTSName = new System.Windows.Forms.Label();
            this.CataName = new DevExpress.XtraEditors.TextEdit();
            this.CataDes = new DevExpress.XtraEditors.TextEdit();
            this.chec = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.catagoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagoryDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagoryExistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.project_DBDataSet = new ITI_Project.Project_DBDataSet();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.categoryTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.category_TableTableAdapter = new ITI_Project.Project_DBDataSetTableAdapters.Category_TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CataName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CataDes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chec.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.RTSName);
            this.groupControl1.Controls.Add(this.CataName);
            this.groupControl1.Controls.Add(this.CataDes);
            this.groupControl1.Controls.Add(this.chec);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(21, 59);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(502, 227);
            this.groupControl1.TabIndex = 40;
            this.groupControl1.Text = "البيانات";
            // 
            // RTSName
            // 
            this.RTSName.AutoSize = true;
            this.RTSName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTSName.ForeColor = System.Drawing.Color.Red;
            this.RTSName.Location = new System.Drawing.Point(14, 57);
            this.RTSName.Name = "RTSName";
            this.RTSName.Size = new System.Drawing.Size(23, 25);
            this.RTSName.TabIndex = 28;
            this.RTSName.Text = "*";
            this.RTSName.Visible = false;
            // 
            // CataName
            // 
            this.CataName.Location = new System.Drawing.Point(43, 46);
            this.CataName.Name = "CataName";
            this.CataName.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F);
            this.CataName.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.CataName.Properties.Appearance.Options.UseFont = true;
            this.CataName.Properties.Appearance.Options.UseForeColor = true;
            this.CataName.Properties.AutoHeight = false;
            this.CataName.Size = new System.Drawing.Size(335, 46);
            this.CataName.TabIndex = 4;
            // 
            // CataDes
            // 
            this.CataDes.Location = new System.Drawing.Point(43, 102);
            this.CataDes.Name = "CataDes";
            this.CataDes.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CataDes.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.CataDes.Properties.Appearance.Options.UseFont = true;
            this.CataDes.Properties.Appearance.Options.UseForeColor = true;
            this.CataDes.Properties.AutoHeight = false;
            this.CataDes.Size = new System.Drawing.Size(335, 70);
            this.CataDes.TabIndex = 3;
            // 
            // chec
            // 
            this.chec.EditValue = true;
            this.chec.Location = new System.Drawing.Point(334, 178);
            this.chec.Name = "chec";
            this.chec.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chec.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.chec.Properties.Appearance.Options.UseFont = true;
            this.chec.Properties.Appearance.Options.UseForeColor = true;
            this.chec.Properties.Caption = "   متوفر           ";
            this.chec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chec.Size = new System.Drawing.Size(152, 44);
            this.chec.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Appearance.Options.UseForeColor = true;
            this.labelControl2.Location = new System.Drawing.Point(384, 113);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(102, 34);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "وصف المجموعة :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(402, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اسم المجموعة :";
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
            this.simpleButton1.Location = new System.Drawing.Point(21, 497);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(236, 43);
            this.simpleButton1.TabIndex = 42;
            this.simpleButton1.Text = "تحديث البيانات";
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
            this.catagoryNameDataGridViewTextBoxColumn,
            this.catagoryDescriptionDataGridViewTextBoxColumn,
            this.catagoryExistDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoryTableBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(21, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(502, 177);
            this.dataGridView1.TabIndex = 41;
            // 
            // catagoryNameDataGridViewTextBoxColumn
            // 
            this.catagoryNameDataGridViewTextBoxColumn.DataPropertyName = "Catagory_Name";
            this.catagoryNameDataGridViewTextBoxColumn.HeaderText = "اسم المجموعة";
            this.catagoryNameDataGridViewTextBoxColumn.Name = "catagoryNameDataGridViewTextBoxColumn";
            this.catagoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.catagoryNameDataGridViewTextBoxColumn.Width = 102;
            // 
            // catagoryDescriptionDataGridViewTextBoxColumn
            // 
            this.catagoryDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Catagory_Description";
            this.catagoryDescriptionDataGridViewTextBoxColumn.HeaderText = "الوصف";
            this.catagoryDescriptionDataGridViewTextBoxColumn.Name = "catagoryDescriptionDataGridViewTextBoxColumn";
            this.catagoryDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.catagoryDescriptionDataGridViewTextBoxColumn.Width = 62;
            // 
            // catagoryExistDataGridViewTextBoxColumn
            // 
            this.catagoryExistDataGridViewTextBoxColumn.DataPropertyName = "Catagory_Exist";
            this.catagoryExistDataGridViewTextBoxColumn.HeaderText = "متوفر";
            this.catagoryExistDataGridViewTextBoxColumn.Name = "catagoryExistDataGridViewTextBoxColumn";
            this.catagoryExistDataGridViewTextBoxColumn.ReadOnly = true;
            this.catagoryExistDataGridViewTextBoxColumn.Width = 57;
            // 
            // categoryTableBindingSource1
            // 
            this.categoryTableBindingSource1.DataMember = "Category_Table";
            this.categoryTableBindingSource1.DataSource = this.project_DBDataSet;
            // 
            // project_DBDataSet
            // 
            this.project_DBDataSet.DataSetName = "Project_DBDataSet";
            this.project_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.DataSource = this.categoryTableBindingSource;
            this.comboBox1.DisplayMember = "Catagory_Name";
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.Black;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(145, 10);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(335, 39);
            this.comboBox1.TabIndex = 44;
            this.comboBox1.ValueMember = "Catagory_ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // categoryTableBindingSource
            // 
            this.categoryTableBindingSource.DataMember = "Category_Table";
            this.categoryTableBindingSource.DataSource = this.project_DBDataSet;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(37, 10);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(84, 34);
            this.labelControl3.TabIndex = 39;
            this.labelControl3.Text = "اسم المجموعة :";
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
            this.simpleButton2.Location = new System.Drawing.Point(287, 497);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(236, 43);
            this.simpleButton2.TabIndex = 43;
            this.simpleButton2.Text = "حذف البيانات";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // category_TableTableAdapter
            // 
            this.category_TableTableAdapter.ClearBeforeFill = true;
            // 
            // CatagoryUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 551);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.simpleButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CatagoryUp";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تحديث بيانات المجموعات الرئيسية";
            this.Load += new System.EventHandler(this.CatagoryUp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CataName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CataDes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chec.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTableBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label RTSName;
        private DevExpress.XtraEditors.TextEdit CataName;
        private DevExpress.XtraEditors.TextEdit CataDes;
        private DevExpress.XtraEditors.CheckEdit chec;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private Project_DBDataSet project_DBDataSet;
        private System.Windows.Forms.BindingSource categoryTableBindingSource;
        private Project_DBDataSetTableAdapters.Category_TableTableAdapter category_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoryDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoryExistDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoryTableBindingSource1;
    }
}