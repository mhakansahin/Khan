using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;
using DevExpress.Utils;
using Khan.OgrenciTakip.UI.Win.Interfaces;
using System;

namespace Khan.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyCalcEdit : CalcEdit, IStatusBarShortCut
    {
        public MyCalcEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.AllowNullInput = DefaultBoolean.False;
            Properties.EditMask = "n2";
        }
        public override bool EnterMoveNextControl { get; set; } = true;
        public string StatusBarDescription { get; set; }
        public string StatusBarShortCut { get; set; } = "F4 :";
        public string StatusBarShortCutDescription { get; set; } = "Hesap Makinesi";
    }
}
