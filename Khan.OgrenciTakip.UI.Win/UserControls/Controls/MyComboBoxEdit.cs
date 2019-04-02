using DevExpress.XtraEditors;
using System.Drawing;
using Khan.OgrenciTakip.UI.Win.Interfaces;
using System.ComponentModel;

namespace Khan.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyComboBoxEdit : ComboBoxEdit, IStatusBarShortCut
    {
        public MyComboBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarDescription { get; set; }

        public string StatusBarShortCut { get; set; } = "F4 :";

        public string StatusBarShortCutDescription { get; set; }
    }
}
