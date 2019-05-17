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
using Khan.OgrenciTakip.UI.Win.Forms.SchoolForms;

namespace Khan.OgrenciTakip.UI.Win.GeneralForms
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainForm()
        {
            InitializeComponent();

            btnSchoolCards.ItemClick += BtnSchoolCards_ItemClick;
        }

        private void BtnSchoolCards_ItemClick(object sender, ItemClickEventArgs e)
        {
            SchoolCards frm = new SchoolCards();
            frm.MdiParent = ActiveForm;
            frm.Show();
        }
    }
}