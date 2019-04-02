using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;
using Khan.OgrenciTakip.UI.Win.Interfaces;

namespace Khan.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyDateEdit : DateEdit, IStatusBarShortCut
    {
        public MyDateEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.DateTimeAdvancingCaret;
        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarDescription { get; set; }

        public string StatusBarShortCut { get; set; } = "F4 :";

        public string StatusBarShortCutDescription { get; set; } = "Tarih Seç";
    }
}
