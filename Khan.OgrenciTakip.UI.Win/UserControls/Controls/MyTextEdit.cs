using DevExpress.XtraEditors;
using Khan.OgrenciTakip.UI.Win.Interfaces;
using System.Drawing;
using System;
using System.ComponentModel;

namespace Khan.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyTextEdit : TextEdit, IStatusBarDescription
    {
        public MyTextEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.MaxLength = 50;
        }

        //Enter a basıldığında bir sonrakine geçsin
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarDescription { get; set; }
    }
}
