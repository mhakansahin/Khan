using Khan.OgrenciTakip.UI.Win.Forms.BaseForms;
using Khan.DLL.General;

namespace Khan.OgrenciTakip.UI.Win.Forms.SchoolForms
{
    public partial class SchoolCards : BaseCardsForm
    {
        public SchoolCards()
        {
            InitializeComponent();

            SchoolBll bll = new SchoolBll();
            grid.DataSource = bll.List(null);
        }
    }
}