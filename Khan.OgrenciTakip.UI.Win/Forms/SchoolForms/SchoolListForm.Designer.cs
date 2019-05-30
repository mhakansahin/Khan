namespace Khan.OgrenciTakip.UI.Win.Forms.SchoolForms
{
    partial class SchoolListForm
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
            this.table = new Khan.OgrenciTakip.UI.Win.UserControls.Grids.MyGridView();
            this.colId = new Khan.OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCode = new Khan.OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colSchoolName = new Khan.OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCity = new Khan.OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colCounty = new Khan.OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.colDescription = new Khan.OgrenciTakip.UI.Win.UserControls.Grids.MyGridColumn();
            this.longNavigator = new Khan.OgrenciTakip.UI.Win.UserControls.Navigators.LongNavigator();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Size = new System.Drawing.Size(999, 102);
            this.ribbonControl.Toolbar.ShowCustomizeItem = false;
            // 
            // grid
            // 
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 102);
            this.grid.MainView = this.table;
            this.grid.MenuManager = this.ribbonControl;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(999, 537);
            this.grid.TabIndex = 2;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.table});
            // 
            // table
            // 
            this.table.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.table.Appearance.FooterPanel.ForeColor = System.Drawing.Color.Maroon;
            this.table.Appearance.FooterPanel.Options.UseFont = true;
            this.table.Appearance.FooterPanel.Options.UseForeColor = true;
            this.table.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Maroon;
            this.table.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.table.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.table.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.table.Appearance.ViewCaption.ForeColor = System.Drawing.Color.Maroon;
            this.table.Appearance.ViewCaption.Options.UseForeColor = true;
            this.table.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCode,
            this.colSchoolName,
            this.colCity,
            this.colCounty,
            this.colDescription});
            this.table.GridControl = this.grid;
            this.table.Name = "table";
            this.table.OptionsMenu.EnableColumnMenu = false;
            this.table.OptionsMenu.EnableFooterMenu = false;
            this.table.OptionsMenu.EnableGroupPanelMenu = false;
            this.table.OptionsNavigation.EnterMoveNextColumn = true;
            this.table.OptionsPrint.AutoWidth = false;
            this.table.OptionsPrint.PrintFooter = false;
            this.table.OptionsPrint.PrintGroupFooter = false;
            this.table.OptionsView.ColumnAutoWidth = false;
            this.table.OptionsView.HeaderFilterButtonShowMode = DevExpress.XtraEditors.Controls.FilterButtonShowMode.Button;
            this.table.OptionsView.RowAutoHeight = true;
            this.table.OptionsView.ShowAutoFilterRow = true;
            this.table.OptionsView.ShowGroupPanel = false;
            this.table.OptionsView.ShowViewCaption = true;
            this.table.StatusBarDescription = null;
            this.table.StatusBarShortCut = null;
            this.table.StatusBarShortCutDescription = null;
            this.table.ViewCaption = "Okul Kartları";
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
            // longNavigator
            // 
            this.longNavigator.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.longNavigator.Location = new System.Drawing.Point(0, 639);
            this.longNavigator.Name = "longNavigator";
            this.longNavigator.Size = new System.Drawing.Size(999, 24);
            this.longNavigator.TabIndex = 3;
            // 
            // SchoolListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 694);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.longNavigator);
            this.Name = "SchoolListForm";
            this.Text = "Okul Kartları";
            this.Controls.SetChildIndex(this.ribbonControl, 0);
            this.Controls.SetChildIndex(this.longNavigator, 0);
            this.Controls.SetChildIndex(this.grid, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControls.Grids.MyGridControl grid;
        private UserControls.Grids.MyGridView table;
        private UserControls.Grids.MyGridColumn colId;
        private UserControls.Grids.MyGridColumn colCode;
        private UserControls.Navigators.LongNavigator longNavigator;
        private UserControls.Grids.MyGridColumn colSchoolName;
        private UserControls.Grids.MyGridColumn colCity;
        private UserControls.Grids.MyGridColumn colCounty;
        private UserControls.Grids.MyGridColumn colDescription;
    }
}