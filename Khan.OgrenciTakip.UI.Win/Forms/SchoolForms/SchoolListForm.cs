using Khan.OgrenciTakip.UI.Win.Forms.BaseForms;
using Khan.DLL.General;
using Khan.OgrenciTakip.Common.Enums;
using Khan.OgrenciTakip.UI.Win.Show;
using Khan.OgrenciTakip.UI.Win.Functions;
using Khan.OgrenciTakip.Model.Entities;

namespace Khan.OgrenciTakip.UI.Win.Forms.SchoolForms
{
    public partial class SchoolListForm : BaseListForm
    {
        public SchoolListForm()
        {
            InitializeComponent();

            Bll = new SchoolBll();
        }

        protected override void FillValues()
        {
            Table = table;
            CardType = CardType.School;
            FormShow = new ShowEditForms<SchoolEditForm>();
            Navigator = longNavigator.Navigator;
        }

        protected override void ToList()
        {
            Table.GridControl.DataSource = ((SchoolBll)Bll).List(FilterFunctions.Filter<School>(ShowActiveCards));
        }
    }
}