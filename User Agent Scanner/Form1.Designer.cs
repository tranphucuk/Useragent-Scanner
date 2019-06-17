namespace User_Agent_Scanner
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.radExcel = new System.Windows.Forms.RadioButton();
            this.radText = new System.Windows.Forms.RadioButton();
            this.sbExport = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.grSettings = new DevExpress.XtraEditors.GroupControl();
            this.leOsVersion = new DevExpress.XtraEditors.LookUpEdit();
            this.ceUADevices = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.leDevices = new DevExpress.XtraEditors.LookUpEdit();
            this.leOS = new DevExpress.XtraEditors.LookUpEdit();
            this.leMobileDevices = new DevExpress.XtraEditors.LookUpEdit();
            this.sbGenerator = new DevExpress.XtraEditors.SimpleButton();
            this.mmAddItems = new DevExpress.XtraEditors.MemoEdit();
            this.sbClear = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grSettings)).BeginInit();
            this.grSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leOsVersion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceUADevices.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leDevices.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leOS.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leMobileDevices.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmAddItems.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Money Twins";
            // 
            // radExcel
            // 
            this.radExcel.AutoSize = true;
            this.radExcel.Checked = true;
            this.radExcel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radExcel.Location = new System.Drawing.Point(12, 78);
            this.radExcel.Name = "radExcel";
            this.radExcel.Size = new System.Drawing.Size(62, 22);
            this.radExcel.TabIndex = 5;
            this.radExcel.TabStop = true;
            this.radExcel.Text = "Excel";
            this.radExcel.UseVisualStyleBackColor = true;
            // 
            // radText
            // 
            this.radText.AutoSize = true;
            this.radText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radText.Location = new System.Drawing.Point(94, 78);
            this.radText.Name = "radText";
            this.radText.Size = new System.Drawing.Size(60, 22);
            this.radText.TabIndex = 5;
            this.radText.Text = "Text";
            this.radText.UseVisualStyleBackColor = true;
            // 
            // sbExport
            // 
            this.sbExport.AllowFocus = false;
            this.sbExport.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbExport.Appearance.Options.UseFont = true;
            this.sbExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("sbExport.ImageOptions.Image")));
            this.sbExport.Location = new System.Drawing.Point(177, 73);
            this.sbExport.Name = "sbExport";
            this.sbExport.Size = new System.Drawing.Size(94, 31);
            this.sbExport.TabIndex = 6;
            this.sbExport.Text = "Export";
            this.sbExport.Click += new System.EventHandler(this.sbExport_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImageOptions.Image")));
            this.groupControl1.Controls.Add(this.marqueeProgressBarControl1);
            this.groupControl1.Controls.Add(this.radText);
            this.groupControl1.Controls.Add(this.radExcel);
            this.groupControl1.Controls.Add(this.sbExport);
            this.groupControl1.Location = new System.Drawing.Point(406, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(284, 115);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Action";
            // 
            // marqueeProgressBarControl1
            // 
            this.marqueeProgressBarControl1.EditValue = 0;
            this.marqueeProgressBarControl1.Location = new System.Drawing.Point(12, 36);
            this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
            this.marqueeProgressBarControl1.Size = new System.Drawing.Size(259, 18);
            this.marqueeProgressBarControl1.TabIndex = 7;
            // 
            // lblStatus
            // 
            this.lblStatus.Appearance.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblStatus.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Appearance.Options.UseBackColor = true;
            this.lblStatus.Appearance.Options.UseFont = true;
            this.lblStatus.Appearance.Options.UseTextOptions = true;
            this.lblStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblStatus.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStatus.Location = new System.Drawing.Point(12, 145);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(333, 24);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Status...";
            // 
            // grSettings
            // 
            this.grSettings.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grSettings.Appearance.Options.UseFont = true;
            this.grSettings.Appearance.Options.UseTextOptions = true;
            this.grSettings.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.grSettings.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.grSettings.CaptionImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("grSettings.CaptionImageOptions.Image")));
            this.grSettings.Controls.Add(this.lblStatus);
            this.grSettings.Controls.Add(this.leOsVersion);
            this.grSettings.Controls.Add(this.ceUADevices);
            this.grSettings.Controls.Add(this.labelControl5);
            this.grSettings.Controls.Add(this.labelControl2);
            this.grSettings.Controls.Add(this.leDevices);
            this.grSettings.Controls.Add(this.leOS);
            this.grSettings.Controls.Add(this.leMobileDevices);
            this.grSettings.Location = new System.Drawing.Point(12, 12);
            this.grSettings.Name = "grSettings";
            this.grSettings.Size = new System.Drawing.Size(361, 184);
            this.grSettings.TabIndex = 9;
            this.grSettings.Text = "Settings";
            // 
            // leOsVersion
            // 
            this.leOsVersion.Enabled = false;
            this.leOsVersion.Location = new System.Drawing.Point(262, 106);
            this.leOsVersion.Name = "leOsVersion";
            this.leOsVersion.Properties.AllowFocused = false;
            this.leOsVersion.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leOsVersion.Properties.Appearance.Options.UseFont = true;
            this.leOsVersion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leOsVersion.Size = new System.Drawing.Size(83, 24);
            this.leOsVersion.TabIndex = 15;
            // 
            // ceUADevices
            // 
            this.ceUADevices.Location = new System.Drawing.Point(12, 108);
            this.ceUADevices.Name = "ceUADevices";
            this.ceUADevices.Properties.AllowFocused = false;
            this.ceUADevices.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceUADevices.Properties.Appearance.Options.UseFont = true;
            this.ceUADevices.Properties.Caption = "UA Devices";
            this.ceUADevices.Size = new System.Drawing.Size(97, 22);
            this.ceUADevices.TabIndex = 11;
            this.ceUADevices.CheckedChanged += new System.EventHandler(this.ceUADevices_CheckedChanged);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(12, 73);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 18);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Type";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 36);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(68, 18);
            this.labelControl2.TabIndex = 9;
            this.labelControl2.Text = "Explore by";
            // 
            // leDevices
            // 
            this.leDevices.Location = new System.Drawing.Point(122, 70);
            this.leDevices.Name = "leDevices";
            this.leDevices.Properties.AllowFocused = false;
            this.leDevices.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leDevices.Properties.Appearance.Options.UseFont = true;
            this.leDevices.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leDevices.Properties.DropDownRows = 10;
            this.leDevices.Size = new System.Drawing.Size(134, 24);
            this.leDevices.TabIndex = 6;
            // 
            // leOS
            // 
            this.leOS.Location = new System.Drawing.Point(122, 33);
            this.leOS.Name = "leOS";
            this.leOS.Properties.AllowFocused = false;
            this.leOS.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leOS.Properties.Appearance.Options.UseFont = true;
            this.leOS.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leOS.Size = new System.Drawing.Size(223, 24);
            this.leOS.TabIndex = 7;
            this.leOS.EditValueChanged += new System.EventHandler(this.leOS_EditValueChanged);
            // 
            // leMobileDevices
            // 
            this.leMobileDevices.Enabled = false;
            this.leMobileDevices.Location = new System.Drawing.Point(122, 106);
            this.leMobileDevices.Name = "leMobileDevices";
            this.leMobileDevices.Properties.AllowFocused = false;
            this.leMobileDevices.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leMobileDevices.Properties.Appearance.Options.UseFont = true;
            this.leMobileDevices.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leMobileDevices.Properties.DropDownRows = 10;
            this.leMobileDevices.Size = new System.Drawing.Size(134, 24);
            this.leMobileDevices.TabIndex = 5;
            this.leMobileDevices.EditValueChanged += new System.EventHandler(this.leMobileDevices_EditValueChanged);
            // 
            // sbGenerator
            // 
            this.sbGenerator.AllowFocus = false;
            this.sbGenerator.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbGenerator.Appearance.Options.UseFont = true;
            this.sbGenerator.ImageOptions.AllowGlyphSkinning = DevExpress.Utils.DefaultBoolean.False;
            this.sbGenerator.ImageOptions.Image = global::User_Agent_Scanner.Properties.Resources.Start_icon_x24;
            this.sbGenerator.Location = new System.Drawing.Point(406, 141);
            this.sbGenerator.Name = "sbGenerator";
            this.sbGenerator.Size = new System.Drawing.Size(182, 55);
            this.sbGenerator.TabIndex = 7;
            this.sbGenerator.Text = "Scan";
            this.sbGenerator.Click += new System.EventHandler(this.sbGenerator_Click);
            // 
            // mmAddItems
            // 
            this.mmAddItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mmAddItems.Location = new System.Drawing.Point(0, 211);
            this.mmAddItems.Name = "mmAddItems";
            this.mmAddItems.Size = new System.Drawing.Size(702, 264);
            this.mmAddItems.TabIndex = 10;
            // 
            // sbClear
            // 
            this.sbClear.AllowFocus = false;
            this.sbClear.Appearance.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbClear.Appearance.Options.UseFont = true;
            this.sbClear.ImageOptions.Image = global::User_Agent_Scanner.Properties.Resources.Clear_icon_x32;
            this.sbClear.ImageOptions.Location = DevExpress.XtraEditors.ImageLocation.MiddleCenter;
            this.sbClear.Location = new System.Drawing.Point(595, 141);
            this.sbClear.Name = "sbClear";
            this.sbClear.Size = new System.Drawing.Size(95, 55);
            this.sbClear.TabIndex = 11;
            this.sbClear.Click += new System.EventHandler(this.sbClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 475);
            this.Controls.Add(this.sbClear);
            this.Controls.Add(this.mmAddItems);
            this.Controls.Add(this.sbGenerator);
            this.Controls.Add(this.grSettings);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserAgent Generator(Blastsofts.com)";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grSettings)).EndInit();
            this.grSettings.ResumeLayout(false);
            this.grSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.leOsVersion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ceUADevices.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leDevices.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leOS.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leMobileDevices.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmAddItems.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private System.Windows.Forms.RadioButton radExcel;
        private System.Windows.Forms.RadioButton radText;
        private DevExpress.XtraEditors.SimpleButton sbExport;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl grSettings;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit leOS;
        private DevExpress.XtraEditors.LookUpEdit leMobileDevices;
        private DevExpress.XtraEditors.SimpleButton sbGenerator;
        private DevExpress.XtraEditors.MemoEdit mmAddItems;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LookUpEdit leDevices;
        private DevExpress.XtraEditors.CheckEdit ceUADevices;
        private DevExpress.XtraEditors.LookUpEdit leOsVersion;
        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl1;
        private DevExpress.XtraEditors.SimpleButton sbClear;
    }
}

