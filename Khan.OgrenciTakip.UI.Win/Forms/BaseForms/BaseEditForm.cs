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
using DevExpress.XtraBars.Ribbon;
using Khan.OgrenciTakip.Common.Enums;
using DevExpress.XtraBars;
using Khan.OgrenciTakip.UI.Win.UserControls.Controls;
using Khan.DLL.Interfaces;
using Khan.OgrenciTakip.Model.Entities.Base;
using Khan.OgrenciTakip.UI.Win.Functions;

namespace Khan.OgrenciTakip.UI.Win.Forms.BaseForms
{
    public partial class BaseEditForm : RibbonForm
    {
        protected internal OperationType OperationType;
        protected internal long Id;
        protected internal bool Refresh;
        protected MyDataLayoutControl MyDataLayoutControl;
        protected IBaseBll Bll;
        protected CardType CardType;
        protected BaseEntity OldEntity;
        protected BaseEntity CurrentEntity;
        protected bool IsLoaded;

        public BaseEditForm()
        {
            InitializeComponent();
        }

        protected void EventLoad()
        {
            //Button Events
            foreach (BarItem button in ribbonControl.Items)
                button.ItemClick += Button_ItemClick;

            //Form Events
            Load += BaseEditForm_Load;
        }

        private void BaseEditForm_Load(object sender, EventArgs e)
        {
            IsLoaded = true;
            ObjectConnectControls();
            //LoadTemplate();
            //ShowButtonUnvisible();
            //Id = 
        }

        private void Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(e.Item == btnNew)
            {
                //Yetki kontrolü
                OperationType = OperationType.EntityInsert;
            }
            else if (e.Item == btnSave)
            {
                Save(false);
            }
            else if (e.Item == btnRetrieve)
            {
                Retrieve();
            }
            else if (e.Item == btnDelete)
            {
                //Yetki kontrolü
                EntityDelete();
            }
            else if (e.Item == btnExit)
            {
                Close();
            }
        }

        private void EntityDelete()
        {
            throw new NotImplementedException();
        }

        private void Retrieve()
        {
            throw new NotImplementedException();
        }

        private void Save(bool v)
        {
            throw new NotImplementedException();
        }

        protected internal virtual void Fill() { }
        protected virtual void ObjectConnectControls() { }
        protected virtual void CreateActualObject() { }
        protected internal virtual void ButtonEnabledStatus()
        {
            if (!IsLoaded) return;
            GeneralFunctions.ButtonEnabledStatus(btnNew, btnSave, btnRetrieve, btnDelete, OldEntity, CurrentEntity);
        }
    }
}