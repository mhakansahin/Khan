using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using DevExpress.XtraEditors.Controls;
using Khan.OgrenciTakip.UI.Win.Interfaces;
using System;

namespace Khan.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyCheckedComboBoxEdit : CheckedComboBoxEdit, IStatusBarShortCut
    {
        public MyCheckedComboBoxEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarDescription { get; set; }

        public string StatusBarShortCut { get; set; } = "F4 :";

        public string StatusBarShortCutDescription { get; set; }
    }
}
