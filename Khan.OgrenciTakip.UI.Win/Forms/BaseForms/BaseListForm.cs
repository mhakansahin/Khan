using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using Khan.OgrenciTakip.UI.Win.Show.Interfaces;
using Khan.OgrenciTakip.Common.Enums;
using DevExpress.XtraGrid.Views.Grid;
using Khan.OgrenciTakip.UI.Win.Functions;
using Khan.OgrenciTakip.Model.Entities.Base;
using Khan.DLL.Interfaces;

namespace Khan.OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseListForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        protected IBaseFormShow FormShow;
        protected CardType CardType;
        protected internal GridView Table;
        protected bool ShowActiveCards = true;
        protected internal bool MultiSelect;
        protected internal BaseEntity SelectedEntity;
        protected IBaseBll Bll;
        protected ControlNavigator Navigator;

        public BaseListForm()
        {
            InitializeComponent();
        }

        private void EventsLoad()
        {
            //Button Events
            foreach (BarItem button in ribbonControl.Items)
                button.ItemClick += Button_ItemClick;

            //Table Events
            Table.DoubleClick += Table_DoubleClick;
            Table.KeyDown += Table_KeyDown;

            //Form Events
        }

        protected internal void Fill()
        {
            FillValues();
            EventsLoad();

            Table.OptionsSelection.MultiSelect = MultiSelect;
            Navigator.NavigatableControl = Table.GridControl;

            Cursor.Current = Cursors.WaitCursor;
            ToList();
            Cursor.Current = DefaultCursor;

            //Güncellenecek.
        }

        protected virtual void FillValues() { }

        private void ShowEditForm(long id)
        {
            var result = FormShow.ShowDialogEditForm(CardType, id);
        }

        private void EntityDelete()
        {
            throw new NotImplementedException();
        }

        private void SelectEntity()
        {
            if (MultiSelect)
            {
                //Güncellenecek
            }
            else
                SelectedEntity = Table.GetRow<BaseEntity>();

            DialogResult = DialogResult.OK;
            Close();
        }

        protected virtual void ToList() { }

        private void SelectFilter()
        {
            throw new NotImplementedException();
        }

        private void Print()
        {
            throw new NotImplementedException();
        }

        private void FormCaptionSettings()
        {
            throw new NotImplementedException();
        }

        private void SelectOperationType()
        {
            if (!IsMdiChild) //Formun içinde form değilse.
            {
                //Güncellenecek
                SelectEntity();
            }
            else
            {
                btnFixIt.PerformClick(); //btnFixIt butonuna tıklayınca ne oluyorsa onu yap.
            }
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (e.Item == btnSend)
            {
                var link = (BarSubItemLink)e.Item.Links[0];
                link.Focus();
                link.OpenMenu();
                link.Item.ItemLinks[0].Focus();
            }
            else if (e.Item == btnStandardExcelFile)
            { }
            else if (e.Item == btnFormatExcelFile)
            { }
            else if (e.Item == btnUnformattedExcelFile)
            { }
            else if (e.Item == btnWordFile)
            { }
            else if (e.Item == btnPdfFile)
            { }
            else if (e.Item == btnTextFile)
            { }
            else if (e.Item == btnNew)
            {
                //Yetki Kontrolü
                ShowEditForm(-1);
            }
            else if (e.Item == btnFixIt)
            {
                ShowEditForm(Table.GetRowId());
            }
            else if (e.Item == btnDelete)
            {
                //Yetki Kontrolü

                EntityDelete();
            }
            else if (e.Item == btnSelect)
            {
                SelectEntity();
            }
            else if (e.Item == btnRefresh)
            {
                ToList();
            }
            else if (e.Item == btnFilter)
            {
                SelectFilter();
            }
            else if (e.Item == btnColumns)
            {
                if (Table.CustomizationForm == null)
                    Table.ShowCustomization();
                else
                    Table.HideCustomization();
            }
            else if (e.Item == btnPrint)
            {
                Print();
            }
            else if (e.Item == btnExit)
            {
                Close();
            }
            else if (e.Item == btnActivePasive)
            {
                ShowActiveCards = !ShowActiveCards;
                FormCaptionSettings();
            }

            Cursor.Current = DefaultCursor;
        }

        private void Table_DoubleClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            SelectOperationType();
            Cursor.Current = DefaultCursor;
        }

        private void Table_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    SelectOperationType();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }
    }
}