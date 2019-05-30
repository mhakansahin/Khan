namespace Khan.OgrenciTakip.UI.Win.Forms.SchoolForms
{
    partial class SchoolEditForm
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            this.myDataLayoutControl = new Khan.OgrenciTakip.UI.Win.UserControls.Controls.MyDataLayoutControl();
            this.meDescription = new Khan.OgrenciTakip.UI.Win.UserControls.Controls.MyMemoEdit();
            this.tsStatus = new Khan.OgrenciTakip.UI.Win.UserControls.Controls.MyToggleSwitch();
            this.beCounty = new Khan.OgrenciTakip.UI.Win.UserControls.Controls.MyButtonEdit();
            this.beCity = new Khan.OgrenciTakip.UI.Win.UserControls.Controls.MyButtonEdit();
            this.txtSchoolName = new Khan.OgrenciTakip.UI.Win.UserControls.Controls.MyTextEdit();
            this.txtCode = new Khan.OgrenciTakip.UI.Win.UserControls.Controls.MyCodeTextEdit();
            this.z = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSchoolName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCity = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCounty = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDescription = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).BeginInit();
            this.myDataLayoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beCounty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.beCity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSchoolName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSchoolName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCounty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(390, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // myDataLayoutControl
            // 
            this.myDataLayoutControl.Controls.Add(this.meDescription);
            this.myDataLayoutControl.Controls.Add(this.tsStatus);
            this.myDataLayoutControl.Controls.Add(this.beCounty);
            this.myDataLayoutControl.Controls.Add(this.beCity);
            this.myDataLayoutControl.Controls.Add(this.txtSchoolName);
            this.myDataLayoutControl.Controls.Add(this.txtCode);
            this.myDataLayoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myDataLayoutControl.Location = new System.Drawing.Point(0, 102);
            this.myDataLayoutControl.Name = "myDataLayoutControl";
            this.myDataLayoutControl.OptionsFocus.EnableAutoTabOrder = false;
            this.myDataLayoutControl.Root = this.z;
            this.myDataLayoutControl.Size = new System.Drawing.Size(390, 226);
            this.myDataLayoutControl.TabIndex = 2;
            this.myDataLayoutControl.Text = "myDataLayoutControl1";
            // 
            // meDescription
            // 
            this.meDescription.EnterMoveNextControl = true;
            this.meDescription.Location = new System.Drawing.Point(58, 108);
            this.meDescription.MenuManager = this.ribbonControl;
            this.meDescription.Name = "meDescription";
            this.meDescription.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.meDescription.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.meDescription.Properties.MaxLength = 500;
            this.meDescription.Size = new System.Drawing.Size(320, 106);
            this.meDescription.StatusBarDescription = "Açıklama Giriniz.";
            this.meDescription.StyleController = this.myDataLayoutControl;
            this.meDescription.TabIndex = 9;
            // 
            // tsStatus
            // 
            this.tsStatus.EnterMoveNextControl = true;
            this.tsStatus.Location = new System.Drawing.Point(283, 12);
            this.tsStatus.MenuManager = this.ribbonControl;
            this.tsStatus.Name = "tsStatus";
            this.tsStatus.Properties.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.tsStatus.Properties.Appearance.Options.UseForeColor = true;
            this.tsStatus.Properties.AutoHeight = false;
            this.tsStatus.Properties.AutoWidth = true;
            this.tsStatus.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.tsStatus.Properties.OffText = "Pasif";
            this.tsStatus.Properties.OnText = "Aktif";
            this.tsStatus.Size = new System.Drawing.Size(97, 20);
            this.tsStatus.StatusBarDescription = "Kartın Kullanım Durumunu Seçiniz.";
            this.tsStatus.StyleController = this.myDataLayoutControl;
            this.tsStatus.TabIndex = 8;
            // 
            // beCounty
            // 
            this.beCounty.EnterMoveNextControl = true;
            this.beCounty.Id = null;
            this.beCounty.Location = new System.Drawing.Point(58, 84);
            this.beCounty.MenuManager = this.ribbonControl;
            this.beCounty.Name = "beCounty";
            this.beCounty.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.beCounty.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.beCounty.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beCounty.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.beCounty.Size = new System.Drawing.Size(150, 20);
            this.beCounty.StatusBarDescription = null;
            this.beCounty.StatusBarShortCut = "F4 :";
            this.beCounty.StatusBarShortCutDescription = null;
            this.beCounty.StyleController = this.myDataLayoutControl;
            this.beCounty.TabIndex = 7;
            // 
            // beCity
            // 
            this.beCity.EnterMoveNextControl = true;
            this.beCity.Id = null;
            this.beCity.Location = new System.Drawing.Point(58, 60);
            this.beCity.MenuManager = this.ribbonControl;
            this.beCity.Name = "beCity";
            this.beCity.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.beCity.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.beCity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.beCity.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.beCity.Size = new System.Drawing.Size(150, 20);
            this.beCity.StatusBarDescription = null;
            this.beCity.StatusBarShortCut = "F4 :";
            this.beCity.StatusBarShortCutDescription = null;
            this.beCity.StyleController = this.myDataLayoutControl;
            this.beCity.TabIndex = 6;
            // 
            // txtSchoolName
            // 
            this.txtSchoolName.EnterMoveNextControl = true;
            this.txtSchoolName.Location = new System.Drawing.Point(58, 36);
            this.txtSchoolName.MenuManager = this.ribbonControl;
            this.txtSchoolName.Name = "txtSchoolName";
            this.txtSchoolName.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtSchoolName.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtSchoolName.Properties.MaxLength = 50;
            this.txtSchoolName.Size = new System.Drawing.Size(320, 20);
            this.txtSchoolName.StatusBarDescription = null;
            this.txtSchoolName.StyleController = this.myDataLayoutControl;
            this.txtSchoolName.TabIndex = 5;
            // 
            // txtCode
            // 
            this.txtCode.EnterMoveNextControl = true;
            this.txtCode.Location = new System.Drawing.Point(58, 12);
            this.txtCode.MenuManager = this.ribbonControl;
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.Appearance.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.txtCode.Properties.Appearance.Options.UseBackColor = true;
            this.txtCode.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCode.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtCode.Properties.AppearanceFocused.BackColor = System.Drawing.Color.LightCyan;
            this.txtCode.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.txtCode.Properties.MaxLength = 20;
            this.txtCode.Size = new System.Drawing.Size(150, 20);
            this.txtCode.StatusBarDescription = "Kod Giriniz";
            this.txtCode.StyleController = this.myDataLayoutControl;
            this.txtCode.TabIndex = 4;
            // 
            // z
            // 
            this.z.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.z.GroupBordersVisible = false;
            this.z.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciCode,
            this.lciSchoolName,
            this.lciCity,
            this.lciCounty,
            this.layoutControlItem5,
            this.lciDescription});
            this.z.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.z.Name = "z";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition1.Width = 200D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 100D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            columnDefinition3.Width = 99D;
            this.z.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 24D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 24D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 24D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 24D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 100D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            this.z.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5});
            this.z.Size = new System.Drawing.Size(390, 226);
            this.z.TextVisible = false;
            // 
            // lciCode
            // 
            this.lciCode.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.lciCode.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciCode.Control = this.txtCode;
            this.lciCode.Location = new System.Drawing.Point(0, 0);
            this.lciCode.Name = "lciCode";
            this.lciCode.Size = new System.Drawing.Size(200, 24);
            this.lciCode.Text = "Kod";
            this.lciCode.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciCode.TextSize = new System.Drawing.Size(41, 13);
            this.lciCode.TextToControlDistance = 5;
            // 
            // lciSchoolName
            // 
            this.lciSchoolName.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.lciSchoolName.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciSchoolName.Control = this.txtSchoolName;
            this.lciSchoolName.Location = new System.Drawing.Point(0, 24);
            this.lciSchoolName.Name = "lciSchoolName";
            this.lciSchoolName.OptionsTableLayoutItem.ColumnSpan = 3;
            this.lciSchoolName.OptionsTableLayoutItem.RowIndex = 1;
            this.lciSchoolName.Size = new System.Drawing.Size(370, 24);
            this.lciSchoolName.Text = "Okul Adı";
            this.lciSchoolName.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciSchoolName.TextSize = new System.Drawing.Size(41, 13);
            this.lciSchoolName.TextToControlDistance = 5;
            // 
            // lciCity
            // 
            this.lciCity.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.lciCity.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciCity.Control = this.beCity;
            this.lciCity.Location = new System.Drawing.Point(0, 48);
            this.lciCity.Name = "lciCity";
            this.lciCity.OptionsTableLayoutItem.RowIndex = 2;
            this.lciCity.Size = new System.Drawing.Size(200, 24);
            this.lciCity.Text = "İl";
            this.lciCity.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciCity.TextSize = new System.Drawing.Size(41, 13);
            this.lciCity.TextToControlDistance = 5;
            // 
            // lciCounty
            // 
            this.lciCounty.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.lciCounty.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciCounty.Control = this.beCounty;
            this.lciCounty.Location = new System.Drawing.Point(0, 72);
            this.lciCounty.Name = "lciCounty";
            this.lciCounty.OptionsTableLayoutItem.RowIndex = 3;
            this.lciCounty.Size = new System.Drawing.Size(200, 24);
            this.lciCounty.Text = "İlçe";
            this.lciCounty.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciCounty.TextSize = new System.Drawing.Size(41, 13);
            this.lciCounty.TextToControlDistance = 5;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.layoutControlItem5.AppearanceItemCaption.Options.UseForeColor = true;
            this.layoutControlItem5.Control = this.tsStatus;
            this.layoutControlItem5.Location = new System.Drawing.Point(271, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.OptionsTableLayoutItem.ColumnIndex = 2;
            this.layoutControlItem5.Size = new System.Drawing.Size(99, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // lciDescription
            // 
            this.lciDescription.AppearanceItemCaption.ForeColor = System.Drawing.Color.Maroon;
            this.lciDescription.AppearanceItemCaption.Options.UseForeColor = true;
            this.lciDescription.Control = this.meDescription;
            this.lciDescription.Location = new System.Drawing.Point(0, 96);
            this.lciDescription.Name = "lciDescription";
            this.lciDescription.OptionsTableLayoutItem.ColumnSpan = 3;
            this.lciDescription.OptionsTableLayoutItem.RowIndex = 4;
            this.lciDescription.Size = new System.Drawing.Size(370, 110);
            this.lciDescription.Text = "Açıklama";
            this.lciDescription.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciDescription.TextSize = new System.Drawing.Size(41, 13);
            this.lciDescription.TextToControlDistance = 5;
            // 
            // SchoolEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 359);
            this.Controls.Add(this.myDataLayoutControl);
            this.MinimumSize = new System.Drawing.Size(400, 360);
            this.Name = "SchoolEditForm";
            this.Text = "Okul Kartı";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.myDataLayoutControl, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDataLayoutControl)).EndInit();
            this.myDataLayoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tsStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beCounty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.beCity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSchoolName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSchoolName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCounty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Controls.MyDataLayoutControl myDataLayoutControl;
        private DevExpress.XtraLayout.LayoutControlGroup z;
        private UserControls.Controls.MyMemoEdit meDescription;
        private UserControls.Controls.MyToggleSwitch tsStatus;
        private UserControls.Controls.MyButtonEdit beCounty;
        private UserControls.Controls.MyButtonEdit beCity;
        private UserControls.Controls.MyTextEdit txtSchoolName;
        private UserControls.Controls.MyCodeTextEdit txtCode;
        private DevExpress.XtraLayout.LayoutControlItem lciCode;
        private DevExpress.XtraLayout.LayoutControlItem lciSchoolName;
        private DevExpress.XtraLayout.LayoutControlItem lciCity;
        private DevExpress.XtraLayout.LayoutControlItem lciCounty;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem lciDescription;
    }
}