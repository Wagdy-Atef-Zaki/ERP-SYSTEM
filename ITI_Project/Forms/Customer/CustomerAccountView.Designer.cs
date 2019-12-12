namespace ITI_Project.Forms.Customer
{
    partial class CustomerAccountView
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.cusSupTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.project_DBDataSet = new ITI_Project.Project_DBDataSet();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cus_Sup_TableTableAdapter = new ITI_Project.Project_DBDataSetTableAdapters.Cus_Sup_TableTableAdapter();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.CusComp = new DevExpress.XtraEditors.TextEdit();
            this.CusEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.CusMobile = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.CusName = new DevExpress.XtraEditors.TextEdit();
            this.CusNotes = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit3 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.textEdit4 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit5 = new DevExpress.XtraEditors.TextEdit();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusSupTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CusComp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusMobile.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusNotes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.dataGridView1);
            this.groupControl1.Location = new System.Drawing.Point(12, 201);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(896, 195);
            this.groupControl1.TabIndex = 87;
            this.groupControl1.Text = "فواتير المبيعات";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(892, 161);
            this.dataGridView1.TabIndex = 18;
            // 
            // comboBox4
            // 
            this.comboBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox4.DataSource = this.cusSupTableBindingSource;
            this.comboBox4.DisplayMember = "Cus_Sup_Name";
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(342, 5);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(335, 39);
            this.comboBox4.TabIndex = 86;
            this.comboBox4.ValueMember = "Cus_Sup_ID";
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
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
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(262, 8);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(78, 34);
            this.labelControl5.TabIndex = 85;
            this.labelControl5.Text = "اسم العميل :";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.dataGridView2);
            this.groupControl2.Location = new System.Drawing.Point(12, 504);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(896, 195);
            this.groupControl2.TabIndex = 88;
            this.groupControl2.Text = "فواتير مرتجع المبيعات";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(2, 32);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(892, 161);
            this.dataGridView2.TabIndex = 18;
            // 
            // cus_Sup_TableTableAdapter
            // 
            this.cus_Sup_TableTableAdapter.ClearBeforeFill = true;
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.Controls.Add(this.CusComp);
            this.groupControl3.Controls.Add(this.CusEmail);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.CusMobile);
            this.groupControl3.Controls.Add(this.labelControl3);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.CusName);
            this.groupControl3.Controls.Add(this.CusNotes);
            this.groupControl3.Controls.Add(this.labelControl2);
            this.groupControl3.Controls.Add(this.labelControl1);
            this.groupControl3.Enabled = false;
            this.groupControl3.Location = new System.Drawing.Point(14, 52);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(894, 141);
            this.groupControl3.TabIndex = 89;
            this.groupControl3.Text = "بيانات العميل";
            // 
            // CusComp
            // 
            this.CusComp.Location = new System.Drawing.Point(584, 92);
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
            this.CusComp.Size = new System.Drawing.Size(215, 44);
            this.CusComp.TabIndex = 57;
            // 
            // CusEmail
            // 
            this.CusEmail.Location = new System.Drawing.Point(269, 92);
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
            this.CusEmail.Size = new System.Drawing.Size(214, 44);
            this.CusEmail.TabIndex = 55;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(489, 96);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(92, 34);
            this.labelControl4.TabIndex = 54;
            this.labelControl4.Text = "بريد الكترونى :";
            // 
            // CusMobile
            // 
            this.CusMobile.Location = new System.Drawing.Point(269, 43);
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
            this.CusMobile.Size = new System.Drawing.Size(214, 44);
            this.CusMobile.TabIndex = 53;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(489, 46);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(74, 34);
            this.labelControl3.TabIndex = 52;
            this.labelControl3.Text = "رقم تليفون :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(805, 94);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(80, 34);
            this.labelControl6.TabIndex = 50;
            this.labelControl6.Text = "اسم الشركة :";
            // 
            // CusName
            // 
            this.CusName.Location = new System.Drawing.Point(584, 41);
            this.CusName.Name = "CusName";
            this.CusName.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F);
            this.CusName.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.CusName.Properties.Appearance.Options.UseFont = true;
            this.CusName.Properties.Appearance.Options.UseForeColor = true;
            this.CusName.Properties.AutoHeight = false;
            this.CusName.Size = new System.Drawing.Size(215, 46);
            this.CusName.TabIndex = 0;
            // 
            // CusNotes
            // 
            this.CusNotes.Location = new System.Drawing.Point(14, 81);
            this.CusNotes.Name = "CusNotes";
            this.CusNotes.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CusNotes.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.CusNotes.Properties.Appearance.Options.UseFont = true;
            this.CusNotes.Properties.Appearance.Options.UseForeColor = true;
            this.CusNotes.Properties.AutoHeight = false;
            this.CusNotes.Size = new System.Drawing.Size(249, 54);
            this.CusNotes.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(188, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(75, 34);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "ملاحظات :";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(805, 46);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اسم العميل :";
            // 
            // groupControl4
            // 
            this.groupControl4.AppearanceCaption.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl4.AppearanceCaption.Options.UseFont = true;
            this.groupControl4.Controls.Add(this.textEdit1);
            this.groupControl4.Controls.Add(this.textEdit2);
            this.groupControl4.Controls.Add(this.textEdit3);
            this.groupControl4.Controls.Add(this.labelControl7);
            this.groupControl4.Controls.Add(this.labelControl8);
            this.groupControl4.Controls.Add(this.labelControl9);
            this.groupControl4.Enabled = false;
            this.groupControl4.Location = new System.Drawing.Point(14, 402);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(894, 96);
            this.groupControl4.TabIndex = 91;
            this.groupControl4.Text = "اجمالى ";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(585, 43);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit1.Properties.AutoHeight = false;
            this.textEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit1.Properties.Mask.BeepOnError = true;
            this.textEdit1.Properties.Mask.EditMask = "c";
            this.textEdit1.Properties.Mask.IgnoreMaskBlank = false;
            this.textEdit1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit1.Properties.Mask.ShowPlaceHolders = false;
            this.textEdit1.Properties.MaxLength = 11;
            this.textEdit1.Size = new System.Drawing.Size(214, 44);
            this.textEdit1.TabIndex = 56;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(8, 43);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit2.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textEdit2.Properties.Appearance.Options.UseFont = true;
            this.textEdit2.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit2.Properties.AutoHeight = false;
            this.textEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit2.Properties.Mask.BeepOnError = true;
            this.textEdit2.Properties.Mask.EditMask = "c";
            this.textEdit2.Properties.Mask.IgnoreMaskBlank = false;
            this.textEdit2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit2.Properties.Mask.ShowPlaceHolders = false;
            this.textEdit2.Properties.MaxLength = 11;
            this.textEdit2.Size = new System.Drawing.Size(214, 44);
            this.textEdit2.TabIndex = 55;
            // 
            // textEdit3
            // 
            this.textEdit3.Location = new System.Drawing.Point(295, 43);
            this.textEdit3.Name = "textEdit3";
            this.textEdit3.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit3.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textEdit3.Properties.Appearance.Options.UseFont = true;
            this.textEdit3.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit3.Properties.AutoHeight = false;
            this.textEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit3.Properties.Mask.BeepOnError = true;
            this.textEdit3.Properties.Mask.EditMask = "c";
            this.textEdit3.Properties.Mask.IgnoreMaskBlank = false;
            this.textEdit3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit3.Properties.Mask.ShowPlaceHolders = false;
            this.textEdit3.Properties.MaxLength = 11;
            this.textEdit3.Size = new System.Drawing.Size(214, 44);
            this.textEdit3.TabIndex = 53;
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(515, 46);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(52, 34);
            this.labelControl7.TabIndex = 52;
            this.labelControl7.Text = "المدفوع :";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(228, 46);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(48, 34);
            this.labelControl8.TabIndex = 1;
            this.labelControl8.Text = "المتبقى :";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(805, 46);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(79, 34);
            this.labelControl9.TabIndex = 0;
            this.labelControl9.Text = "قيمة الفواتير :";
            // 
            // groupControl5
            // 
            this.groupControl5.AppearanceCaption.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl5.AppearanceCaption.Options.UseFont = true;
            this.groupControl5.Controls.Add(this.textEdit4);
            this.groupControl5.Controls.Add(this.textEdit5);
            this.groupControl5.Controls.Add(this.textEdit6);
            this.groupControl5.Controls.Add(this.labelControl10);
            this.groupControl5.Controls.Add(this.labelControl11);
            this.groupControl5.Controls.Add(this.labelControl12);
            this.groupControl5.Enabled = false;
            this.groupControl5.Location = new System.Drawing.Point(14, 705);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(894, 96);
            this.groupControl5.TabIndex = 92;
            this.groupControl5.Text = "اجمالى ";
            // 
            // textEdit4
            // 
            this.textEdit4.Location = new System.Drawing.Point(585, 43);
            this.textEdit4.Name = "textEdit4";
            this.textEdit4.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit4.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textEdit4.Properties.Appearance.Options.UseFont = true;
            this.textEdit4.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit4.Properties.AutoHeight = false;
            this.textEdit4.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit4.Properties.Mask.BeepOnError = true;
            this.textEdit4.Properties.Mask.EditMask = "c";
            this.textEdit4.Properties.Mask.IgnoreMaskBlank = false;
            this.textEdit4.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit4.Properties.Mask.ShowPlaceHolders = false;
            this.textEdit4.Properties.MaxLength = 11;
            this.textEdit4.Size = new System.Drawing.Size(214, 44);
            this.textEdit4.TabIndex = 56;
            // 
            // textEdit5
            // 
            this.textEdit5.Location = new System.Drawing.Point(8, 43);
            this.textEdit5.Name = "textEdit5";
            this.textEdit5.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit5.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textEdit5.Properties.Appearance.Options.UseFont = true;
            this.textEdit5.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit5.Properties.AutoHeight = false;
            this.textEdit5.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit5.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit5.Properties.Mask.BeepOnError = true;
            this.textEdit5.Properties.Mask.EditMask = "c";
            this.textEdit5.Properties.Mask.IgnoreMaskBlank = false;
            this.textEdit5.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit5.Properties.Mask.ShowPlaceHolders = false;
            this.textEdit5.Properties.MaxLength = 11;
            this.textEdit5.Size = new System.Drawing.Size(214, 44);
            this.textEdit5.TabIndex = 55;
            // 
            // textEdit6
            // 
            this.textEdit6.Location = new System.Drawing.Point(295, 43);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit6.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.textEdit6.Properties.Appearance.Options.UseFont = true;
            this.textEdit6.Properties.Appearance.Options.UseForeColor = true;
            this.textEdit6.Properties.AutoHeight = false;
            this.textEdit6.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit6.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.textEdit6.Properties.Mask.BeepOnError = true;
            this.textEdit6.Properties.Mask.EditMask = "c";
            this.textEdit6.Properties.Mask.IgnoreMaskBlank = false;
            this.textEdit6.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.textEdit6.Properties.Mask.ShowPlaceHolders = false;
            this.textEdit6.Properties.MaxLength = 11;
            this.textEdit6.Size = new System.Drawing.Size(214, 44);
            this.textEdit6.TabIndex = 53;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(515, 46);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(52, 34);
            this.labelControl10.TabIndex = 52;
            this.labelControl10.Text = "المدفوع :";
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(228, 46);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(48, 34);
            this.labelControl11.TabIndex = 1;
            this.labelControl11.Text = "المتبقى :";
            // 
            // labelControl12
            // 
            this.labelControl12.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl12.Appearance.Options.UseFont = true;
            this.labelControl12.Location = new System.Drawing.Point(805, 46);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(79, 34);
            this.labelControl12.TabIndex = 0;
            this.labelControl12.Text = "قيمة الفواتير :";
            // 
            // CustomerAccountView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 807);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.groupControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CustomerAccountView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كشف حساب عميل";
            this.Load += new System.EventHandler(this.CustomerAccountView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusSupTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.project_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CusComp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusMobile.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CusNotes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit5.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private Project_DBDataSet project_DBDataSet;
        private System.Windows.Forms.BindingSource cusSupTableBindingSource;
        private Project_DBDataSetTableAdapters.Cus_Sup_TableTableAdapter cus_Sup_TableTableAdapter;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit CusComp;
        private DevExpress.XtraEditors.TextEdit CusEmail;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit CusMobile;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit CusName;
        private DevExpress.XtraEditors.TextEdit CusNotes;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
    }
}