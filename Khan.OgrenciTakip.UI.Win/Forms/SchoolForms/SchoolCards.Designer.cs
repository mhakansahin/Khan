namespace Khan.OgrenciTakip.UI.Win.Forms.SchoolForms
{
    partial class SchoolCards
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
            this.grid = new Khan.OgrenciTakip.UI.Win.UserControls.Grids.MyGridControl();
            this.tablo = new Khan.OgrenciTakip.UI.Win.UserControls.Grids.MyGridView();
            this.colId = new Khan.OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCode = new Khan.OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.longNavigator1 = new Khan.OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            this.colSchoolName = new Khan.OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCity = new Khan.OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCounty = new Khan.OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colDescription = new Khan.OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).BeginInit();
            this.SuspendLayout();
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.tablo;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(999, 537);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.tablo});
            // 
            // tablo
            // 
            this.tablo.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tablo.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.FooterPanel.Options.UseFont = true;
            this.tablo.Appearance.FooterPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.tablo.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.tablo.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.tablo.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.tablo.Appearance.ViewCaption.Options.UseForeColor = true;
            this.tablo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCode,
            this.colSchoolName,
            this.colCity,
            this.colCounty,
            this.colDescription});
            this.tablo.GridControl = this.grid;
            this.tablo.Name = "tablo";
            this.tablo.OptionsMenu.EnableColumnMenu = false;
            this.tablo.OptionsMenu.EnableFooterMenu = false;
            this.tablo.OptionsMenu.EnableGroupPanelMenu = false;
            this.tablo.OptionsNavigation.EnterMoveNextColumn = true;
            this.tablo.OptionsPrint.AutoWidth = false;
            this.tablo.OptionsPrint.PrintFooter = false;
            this.tablo.OptionsPrint.PrintGroupFooter = false;
            this.tablo.OptionsView.ColumnAutoWidth = false;
            this.tablo.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.tablo.OptionsView.RowAutoHeight = true;
            this.tablo.OptionsView.ShowAutoFilterRow = true;
            this.tablo.OptionsView.ShowGroupPanel = false;
            this.tablo.OptionsView.ShowViewCaption = true;
            this.tablo.StatusBarDescription = null;
            this.tablo.StatusBarShortCut = null;
            this.tablo.StatusBarShortCutDescription = null;
            this.tablo.ViewCaption = "Okul Kartları";
            // 
            // colId
            // 
            this.colId.Caption = "Id";
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.OptionsColumn.ShowInCustomizationForm = false;
            this.colId.StatusBarDescription = null;
            this.colId.StatusBarShortCut = null;
            this.colId.StatusBarShortCutDescription = null;
            // 
            // colCode
            // 
            this.colCode.AppearanceCell.Options.UseTextOptions = true;
            this.colCode.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCode.Caption = "Kod";
            this.colCode.FieldName = "Code";
            this.colCode.Name = "colCode";
            this.colCode.OptionsColumn.AllowEdit = false;
            this.colCode.StatusBarDescription = null;
            this.colCode.StatusBarShortCut = null;
            this.colCode.StatusBarShortCutDescription = null;
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 116;
            // 
            // longNavigator1
            // 
            this.longNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator1.Location = new System.Drawing.Point(0, 639);
            this.longNavigator1.Name = "longNavigator1";
            this.longNavigator1.Size = new System.Drawing.Size(999, 24);
            this.longNavigator1.TabIndex = 3;
            // 
            // colSchoolName
            // 
            this.colSchoolName.Caption = "Okul Adı";
            this.colSchoolName.FieldName = "SchoolName";
            this.colSchoolName.Name = "colSchoolName";
            this.colSchoolName.OptionsColumn.AllowEdit = false;
            this.colSchoolName.StatusBarDescription = null;
            this.colSchoolName.StatusBarShortCut = null;
            this.colSchoolName.StatusBarShortCutDescription = null;
            this.colSchoolName.Visible = true;
            this.colSchoolName.VisibleIndex = 1;
            this.colSchoolName.Width = 177;
            // 
            // colCity
            // 
            this.colCity.Caption = "İl";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.OptionsColumn.AllowEdit = false;
            this.colCity.StatusBarDescription = null;
            this.colCity.StatusBarShortCut = null;
            this.colCity.StatusBarShortCutDescription = null;
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 2;
            this.colCity.Width = 104;
            // 
            // colCounty
            // 
            this.colCounty.Caption = "İlçe";
            this.colCounty.FieldName = "County";
            this.colCounty.Name = "colCounty";
            this.colCounty.OptionsColumn.AllowEdit = false;
            this.colCounty.StatusBarDescription = null;
            this.colCounty.StatusBarShortCut = null;
            this.colCounty.StatusBarShortCutDescription = null;
            this.colCounty.Visible = true;
            this.colCounty.VisibleIndex = 3;
            this.colCounty.Width = 109;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Açıklama";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowEdit = false;
            this.colDescription.StatusBarDescription = null;
            this.colDescription.StatusBarShortCut = null;
            this.colDescription.StatusBarShortCutDescription = null;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 4;
            this.colDescription.Width = 327;
            // 
            // SchoolCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 694);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator1);
            this.Name = "SchoolCards";
            this.Text = "Okul Kartları";
            this.Controls.SetChildIndex(this.longNavigator1, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grids.MyGridControl grid;
        private UserControls.Grids.MyGridView tablo;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colCode;
        private UserControls.Navigators.LongNavigator longNavigator1;
        private UserControls.Grids.MyGridColumn colSchoolName;
        private UserControls.Grids.MyGridColumn colCity;
        private UserControls.Grids.MyGridColumn colCounty;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}