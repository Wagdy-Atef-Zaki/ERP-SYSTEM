namespace ITI_Project.Forms.Product
{
    partial class CatagoryAdd
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
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.catagoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagoryDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catagoryExistDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_DBDataSet = new ITI_Project.Project_DBDataSet();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.category_TableTableAdapter = new ITI_Project.Project_DBDataSetTableAdapters.Category_TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CataName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CataDes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.RTSName);
            this.groupControl1.Controls.Add(this.CataName);
            this.groupControl1.Controls.Add(this.CataDes);
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(14, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(502, 227);
            this.groupControl1.TabIndex = 14;
            this.groupControl1.Text = "البيانات";
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
            this.CataName.TabIndex = 0;
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
            // checkEdit1
            // 
            this.checkEdit1.EditValue = true;
            this.checkEdit1.Location = new System.Drawing.Point(334, 178);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.checkEdit1.Properties.Appearance.Options.UseFont = true;
            this.checkEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.checkEdit1.Properties.Caption = "   متوفر           ";
            this.checkEdit1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkEdit1.Size = new System.Drawing.Size(152, 44);
            this.checkEdit1.TabIndex = 2;
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
            this.labelControl1.Location = new System.Drawing.Point(402, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(84, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اسم المجموعة :";
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
            this.dataGridView1.DataSource = this.categoryTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 258);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(502, 195);
            this.dataGridView1.TabIndex = 15;
            // 
            // catagoryNameDataGridViewTextBoxColumn
            // 
            this.catagoryNameDataGridViewTextBoxColumn.DataPropertyName = "Catagory_Name";
            this.catagoryNameDataGridViewTextBoxColumn.HeaderText = "اسم المجموعة";
            this.catagoryNameDataGridViewTextBoxColumn.Name = "catagoryNameDataGridViewTextBoxColumn";
            this.catagoryNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.catagoryNameDataGridViewTextBoxColumn.Width = 94;
            // 
            // catagoryDescriptionDataGridViewTextBoxColumn
            // 
            this.catagoryDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Catagory_Description";
            this.catagoryDescriptionDataGridViewTextBoxColumn.HeaderText = "وصف المجموعة";
            this.catagoryDescriptionDataGridViewTextBoxColumn.Name = "catagoryDescriptionDataGridViewTextBoxColumn";
            this.catagoryDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.catagoryDescriptionDataGridViewTextBoxColumn.Width = 96;
            // 
            // catagoryExistDataGridViewTextBoxColumn
            // 
            this.catagoryExistDataGridViewTextBoxColumn.DataPropertyName = "Catagory_Exist";
            this.catagoryExistDataGridViewTextBoxColumn.HeaderText = "متوفر";
            this.catagoryExistDataGridViewTextBoxColumn.Name = "catagoryExistDataGridViewTextBoxColumn";
            this.catagoryExistDataGridViewTextBoxColumn.ReadOnly = true;
            this.catagoryExistDataGridViewTextBoxColumn.Width = 57;
            // 
            // categoryTableBindingSource
            // 
            this.categoryTableBindingSource.DataMember = "Category_Table";
            this.categoryTableBindingSource.DataSource = this.project_DBDataSet;
            // 
            // project_DBDataSet
            // 
            this.project_DBDataSet.DataSetName = "Project_DBDataSet";
            this.project_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.simpleButton1.Location = new System.Drawing.Point(14, 462);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(502, 43);
            this.simpleButton1.TabIndex = 16;
            this.simpleButton1.Text = "اضافة البيانات";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // category_TableTableAdapter
            // 
            this.category_TableTableAdapter.ClearBeforeFill = true;
            // 
            // CatagoryAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 517);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.simpleButton1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CatagoryAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة بيانات المجموعات الرئيسية";
            this.Load += new System.EventHandler(this.CatagoryAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CataName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CataDes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label RTSName;
        private DevExpress.XtraEditors.TextEdit CataName;
        private DevExpress.XtraEditors.TextEdit CataDes;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private Project_DBDataSet project_DBDataSet;
        private System.Windows.Forms.BindingSource categoryTableBindingSource;
        private Project_DBDataSetTableAdapters.Category_TableTableAdapter category_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoryDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn catagoryExistDataGridViewTextBoxColumn;
    }
}