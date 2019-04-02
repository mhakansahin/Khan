using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using Khan.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraEditors.Repository;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using DevExpress.XtraGrid.Views.Base;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Registrator;

namespace Khan.OgrenciTakip.UI.Win.UserControls.Grids
{
    [ToolboxItem(true)]
    public class MyBandedGridControl : GridControl
    {
        protected override BaseView CreateDefaultView()
        {
            var view = (MyBandedGridView)CreateView("MyBandedGridView");

            view.Appearance.ViewCaption.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.ForeColor = Color.Maroon;
            view.Appearance.HeaderPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.Appearance.FooterPanel.ForeColor = Color.Maroon;
            view.Appearance.FooterPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);
            view.Appearance.BandPanel.ForeColor = Color.DarkBlue;
            view.Appearance.BandPanel.Font = new Font(new FontFamily("Tahoma"), 8.25f, FontStyle.Bold);
            view.Appearance.BandPanel.TextOptions.HAlignment = HorzAlignment.Center;
            view.BandPanelRowHeight = 40;

            view.OptionsMenu.EnableColumnMenu = false;
            view.OptionsMenu.EnableFooterMenu = false;
            view.OptionsMenu.EnableGroupPanelMenu = false;

            view.OptionsNavigation.EnterMoveNextColumn = true;

            view.OptionsPrint.AutoWidth = false;
            view.OptionsPrint.PrintFooter = false;
            view.OptionsPrint.PrintGroupFooter = false;

            view.OptionsView.ShowAutoFilterRow = true;
            view.OptionsView.ShowViewCaption = true;
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsView.ColumnAutoWidth = false;
            view.OptionsView.RowAutoHeight = true;
            view.OptionsView.HeaderFilterButtonShowMode = FilterButtonShowMode.Button;

            var columns = new[]
            {
                new BandedGridColumn
                {
                    Caption = "Id",
                    FieldName = "Id",
                    OptionsColumn = { AllowEdit = false, ShowInCustomizationForm = false }
                },

                new BandedGridColumn
                {
                    Caption = "Kod",
                    FieldName = "Code",
                    Visible = true,
                    OptionsColumn = { AllowEdit = false },
                    AppearanceCell = { TextOptions = { HAlignment = HorzAlignment.Center }, Options = { UseTextOptions = true } }
                }
            };

            view.Columns.AddRange(columns);

            return view;
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);

            collection.Add(new MyBandedGridInfoRegistrator());
        }

        private class MyBandedGridInfoRegistrator : BandedGridInfoRegistrator
        {
            public override string ViewName => "MyBandedGridView";
            public override BaseView CreateView(GridControl grid) => new MyBandedGridView(grid);
        }
    }

    public class MyBandedGridView : BandedGridView, IStatusBarShortCut
    {
        #region IStatusBarShortCut Properties
        public string StatusBarDescription { get; set; }

        public string StatusBarShortCut { get; set; }

        public string StatusBarShortCutDescription { get; set; }
        #endregion

        public MyBandedGridView() { }

        public MyBandedGridView(GridControl ownerGrid) : base(ownerGrid) { }

        protected override void OnColumnChangedCore(GridColumn column)
        {
            base.OnColumnChangedCore(column);

            if (column.ColumnEdit == null) return;
            if (column.ColumnEdit.GetType() == typeof(RepositoryItemDateEdit))
            {
                column.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
                ((RepositoryItemDateEdit)column.ColumnEdit).Mask.MaskType = MaskType.DateTimeAdvancingCaret;
            }
        }

        protected override GridColumnCollection CreateColumnCollection()
        {
            return new MyGridColumnCollection(this);
        }

        private class MyGridColumnCollection : BandedGridColumnCollection
        {
            public MyGridColumnCollection(ColumnView view) : base(view) { }

            protected override GridColumn CreateColumn()
            {
                var column = new MyBandedGridColumn();
                column.OptionsColumn.AllowEdit = false;

                return column;
            }
        }
    }

    public class MyBandedGridColumn : BandedGridColumn, IStatusBarShortCut
    {
        #region IStatusBarShortCut Properties
        public string StatusBarDescription { get; set; }

        public string StatusBarShortCut { get; set; }

        public string StatusBarShortCutDescription { get; set; }
        #endregion
    }
}
