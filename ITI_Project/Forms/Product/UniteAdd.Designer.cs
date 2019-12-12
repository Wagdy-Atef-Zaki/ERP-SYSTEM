namespace ITI_Project.Forms.Product
{
    partial class UniteAdd
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
            this.UniteName = new DevExpress.XtraEditors.TextEdit();
            this.UniteDes = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uniteNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniteDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uniteTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_DBDataSet = new ITI_Project.Project_DBDataSet();
            this.unite_TableTableAdapter = new ITI_Project.Project_DBDataSetTableAdapters.Unite_TableTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UniteName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UniteDes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniteTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.RTSName);
            this.groupControl1.Controls.Add(this.UniteName);
            this.groupControl1.Controls.Add(this.UniteDes);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(14, 9);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(502, 205);
            this.groupControl1.TabIndex = 17;
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
            // UniteName
            // 
            this.UniteName.Location = new System.Drawing.Point(43, 46);
            this.UniteName.Name = "UniteName";
            this.UniteName.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F);
            this.UniteName.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.UniteName.Properties.Appearance.Options.UseFont = true;
            this.UniteName.Properties.Appearance.Options.UseForeColor = true;
            this.UniteName.Properties.AutoHeight = false;
            this.UniteName.Size = new System.Drawing.Size(335, 46);
            this.UniteName.TabIndex = 0;
            // 
            // UniteDes
            // 
            this.UniteDes.Location = new System.Drawing.Point(43, 102);
            this.UniteDes.Name = "UniteDes";
            this.UniteDes.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UniteDes.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.UniteDes.Properties.Appearance.Options.UseFont = true;
            this.UniteDes.Properties.Appearance.Options.UseForeColor = true;
            this.UniteDes.Properties.AutoHeight = false;
            this.UniteDes.Size = new System.Drawing.Size(335, 70);
            this.UniteDes.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(384, 113);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(98, 34);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "وصف الوحدة :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(402, 51);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اسم الوحدة :";
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
            this.simpleButton1.Location = new System.Drawing.Point(14, 436);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(502, 43);
            this.simpleButton1.TabIndex = 19;
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
            this.uniteNameDataGridViewTextBoxColumn,
            this.uniteDescriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uniteTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(14, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(502, 195);
            this.dataGridView1.TabIndex = 18;
            // 
            // uniteNameDataGridViewTextBoxColumn
            // 
            this.uniteNameDataGridViewTextBoxColumn.DataPropertyName = "Unite_Name";
            this.uniteNameDataGridViewTextBoxColumn.HeaderText = "اسم الوحدة";
            this.uniteNameDataGridViewTextBoxColumn.Name = "uniteNameDataGridViewTextBoxColumn";
            this.uniteNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.uniteNameDataGridViewTextBoxColumn.Width = 86;
            // 
            // uniteDescriptionDataGridViewTextBoxColumn
            // 
            this.uniteDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Unite_Description";
            this.uniteDescriptionDataGridViewTextBoxColumn.HeaderText = "وصف الوحدة";
            this.uniteDescriptionDataGridViewTextBoxColumn.Name = "uniteDescriptionDataGridViewTextBoxColumn";
            this.uniteDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            this.uniteDescriptionDataGridViewTextBoxColumn.Width = 88;
            // 
            // uniteTableBindingSource
            // 
            this.uniteTableBindingSource.DataMember = "Unite_Table";
            this.uniteTableBindingSource.DataSource = this.project_DBDataSet;
            // 
            // project_DBDataSet
            // 
            this.project_DBDataSet.DataSetName = "Project_DBDataSet";
            this.project_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // unite_TableTableAdapter
            // 
            this.unite_TableTableAdapter.ClearBeforeFill = true;
            // 
            // UniteAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 489);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "UniteAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة بيانات الوحدات";
            this.Load += new System.EventHandler(this.UniteAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UniteName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UniteDes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniteTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label RTSName;
        private DevExpress.XtraEditors.TextEdit UniteName;
        private DevExpress.XtraEditors.TextEdit UniteDes;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Project_DBDataSet project_DBDataSet;
        private System.Windows.Forms.BindingSource uniteTableBindingSource;
        private Project_DBDataSetTableAdapters.Unite_TableTableAdapter unite_TableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniteNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uniteDescriptionDataGridViewTextBoxColumn;
    }
}