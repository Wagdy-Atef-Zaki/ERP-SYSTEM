namespace ITI_Project.Forms.Settings
{
    partial class SystemUserAdd
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
            this.OpenFile = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.RTSName = new System.Windows.Forms.Label();
            this.Pass = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.UserN = new DevExpress.XtraEditors.TextEdit();
            this.Search = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Update = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.ControlName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Full_Control = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "xtraOpenFileDialog1";
            this.OpenFile.ShowDragDropConfirmation = true;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.simpleButton3.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.simpleButton3.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.simpleButton3.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton3.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton3.Location = new System.Drawing.Point(154, 100);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(102, 37);
            this.simpleButton3.TabIndex = 32;
            this.simpleButton3.Text = "حذف";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.simpleButton2.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.simpleButton2.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.simpleButton2.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton2.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton2.Location = new System.Drawing.Point(154, 57);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(102, 37);
            this.simpleButton2.TabIndex = 31;
            this.simpleButton2.Text = "اضافة";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = global::ITI_Project.Properties.Resources.user1;
            this.pictureEdit1.Location = new System.Drawing.Point(5, 41);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEdit1.Size = new System.Drawing.Size(143, 112);
            this.pictureEdit1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(264, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "*";
            this.label1.Visible = false;
            // 
            // RTSName
            // 
            this.RTSName.AutoSize = true;
            this.RTSName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTSName.ForeColor = System.Drawing.Color.Red;
            this.RTSName.Location = new System.Drawing.Point(264, 61);
            this.RTSName.Name = "RTSName";
            this.RTSName.Size = new System.Drawing.Size(23, 25);
            this.RTSName.TabIndex = 28;
            this.RTSName.Text = "*";
            this.RTSName.Visible = false;
            // 
            // Pass
            // 
            this.Pass.Location = new System.Drawing.Point(293, 100);
            this.Pass.Name = "Pass";
            this.Pass.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Pass.Properties.Appearance.Options.UseFont = true;
            this.Pass.Properties.Appearance.Options.UseForeColor = true;
            this.Pass.Properties.AutoHeight = false;
            this.Pass.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Pass.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.Pass.Properties.Mask.BeepOnError = true;
            this.Pass.Properties.Mask.IgnoreMaskBlank = false;
            this.Pass.Properties.Mask.ShowPlaceHolders = false;
            this.Pass.Properties.MaxLength = 11;
            this.Pass.Size = new System.Drawing.Size(293, 44);
            this.Pass.TabIndex = 6;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(599, 106);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(72, 34);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "كلمة السر :";
            // 
            // UserN
            // 
            this.UserN.Location = new System.Drawing.Point(293, 50);
            this.UserN.Name = "UserN";
            this.UserN.Properties.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserN.Properties.Appearance.ForeColor = System.Drawing.Color.Black;
            this.UserN.Properties.Appearance.Options.UseFont = true;
            this.UserN.Properties.Appearance.Options.UseForeColor = true;
            this.UserN.Properties.AutoHeight = false;
            this.UserN.Properties.NullValuePromptShowForEmptyValue = true;
            this.UserN.Size = new System.Drawing.Size(293, 44);
            this.UserN.TabIndex = 0;
            // 
            // Search
            // 
            this.Search.FalseValue = "0";
            this.Search.HeaderText = "بحث";
            this.Search.Name = "Search";
            this.Search.ReadOnly = true;
            this.Search.TrueValue = "1";
            // 
            // delete
            // 
            this.delete.FalseValue = "0";
            this.delete.HeaderText = "حذف البيانات";
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.TrueValue = "1";
            // 
            // Update
            // 
            this.Update.FalseValue = "0";
            this.Update.HeaderText = "تحديث بيانات";
            this.Update.Name = "Update";
            this.Update.ReadOnly = true;
            this.Update.TrueValue = "1";
            // 
            // Add
            // 
            this.Add.FalseValue = "0";
            this.Add.HeaderText = "اضافة البيانات";
            this.Add.Name = "Add";
            this.Add.ReadOnly = true;
            this.Add.TrueValue = "1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arabic Typesetting", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(592, 56);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(96, 34);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "اسم الستخدم :";
            // 
            // ControlName
            // 
            this.ControlName.HeaderText = "اسم الشاشة";
            this.ControlName.Name = "ControlName";
            this.ControlName.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ControlName,
            this.Full_Control,
            this.Add,
            this.Update,
            this.delete,
            this.Search});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(2, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(704, 163);
            this.dataGridView1.TabIndex = 0;
            // 
            // Full_Control
            // 
            this.Full_Control.FalseValue = "0";
            this.Full_Control.HeaderText = "تحكم كامل";
            this.Full_Control.Name = "Full_Control";
            this.Full_Control.ReadOnly = true;
            this.Full_Control.TrueValue = "1";
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
            this.simpleButton1.Location = new System.Drawing.Point(11, 382);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(708, 43);
            this.simpleButton1.TabIndex = 34;
            this.simpleButton1.Text = "اضافة البيانات";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.dataGridView1);
            this.groupControl2.Location = new System.Drawing.Point(11, 176);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(708, 197);
            this.groupControl2.TabIndex = 33;
            this.groupControl2.Text = "الصلاحيات";
            // 
            // groupControl1
            // 
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Arabic Typesetting", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.pictureEdit1);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.RTSName);
            this.groupControl1.Controls.Add(this.Pass);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.UserN);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(11, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(708, 158);
            this.groupControl1.TabIndex = 32;
            this.groupControl1.Text = "البيانات";
            // 
            // SystemUserAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 437);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "SystemUserAdd";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافة بيانات مستخدمى النظام ";
            this.Load += new System.EventHandler(this.SystemUserAdd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraOpenFileDialog OpenFile;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RTSName;
        private DevExpress.XtraEditors.TextEdit Pass;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit UserN;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Search;
        private System.Windows.Forms.DataGridViewCheckBoxColumn delete;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Update;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Add;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ControlName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Full_Control;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}