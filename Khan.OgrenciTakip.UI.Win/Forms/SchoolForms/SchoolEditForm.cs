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
using Khan.OgrenciTakip.UI.Win.Forms.BaseForms;
using Khan.DLL.General;
using Khan.OgrenciTakip.Common.Enums;
using Khan.OgrenciTakip.Model.Dto;
using Khan.OgrenciTakip.UI.Win.Functions;
using Khan.OgrenciTakip.Model.Entities;

namespace Khan.OgrenciTakip.UI.Win.Forms.SchoolForms
{
    public partial class SchoolEditForm : BaseEditForm
    {
        public SchoolEditForm()
        {
            InitializeComponent();

            myDataLayoutControl = MyDataLayoutControl;
            Bll = new SchoolBll(MyDataLayoutControl);
            CardType = CardType.School;
            EventLoad();
        }

        protected internal override void Fill()
        {
            OldEntity = OperationType == OperationType.EntityInsert ? new SchoolS() : ((SchoolBll)Bll).Single(FilterFunctions.Filter<School>(Id));
        }

        protected override void ObjectConnectControls()
        {
            var entity = (SchoolS)OldEntity;

            txtCode.Text = entity.Code;
            txtSchoolName.Text = entity.SchoolName;
            beCity.Id = entity.CityId;
            beCity.Text = entity.CityName;
            beCounty.Id = entity.CountyId;
            beCounty.Text = entity.CountyName;
            meDescription.Text = entity.Description;
            tsStatus.IsOn = entity.Status;
        }

        protected override void CreateActualObject()
        {
            CurrentEntity = new School
            {
                Id = Id,
                Code = txtCode.Text,
                SchoolName = txtSchoolName.Text,
                CityId = Convert.ToInt64(beCity.Id),
                CountyId = Convert.ToInt64(beCounty.Id),
                Description = meDescription.Text,
                Status = tsStatus.IsOn
            };

            ButtonEnabledStatus();
        }
    }
}