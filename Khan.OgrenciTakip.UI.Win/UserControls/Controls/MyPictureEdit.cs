using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.XtraEditors.Controls;
using Khan.OgrenciTakip.UI.Win.Interfaces;

namespace Khan.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyPictureEdit : PictureEdit, IStatusBarShortCut
    {
        public MyPictureEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
            Properties.Appearance.ForeColor = Color.Maroon;
            Properties.NullText = "Resim Yok";
            Properties.SizeMode = PictureSizeMode.Stretch; //Resmi yay.
            Properties.ShowMenu = false;
        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarDescription { get; set; }

        public string StatusBarShortCut { get; set; } = "F4 :";

        public string StatusBarShortCutDescription { get; set; }
    }
}
