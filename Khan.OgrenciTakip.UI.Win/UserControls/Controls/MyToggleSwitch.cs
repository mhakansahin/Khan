using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using System.Drawing;
using Khan.OgrenciTakip.UI.Win.Interfaces;

namespace Khan.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyToggleSwitch : ToggleSwitch, IStatusBarDescription
    {
        public MyToggleSwitch()
        {
            Name = "tglStatus";
            Properties.OffText = "Pasif";
            Properties.OnText = "Aktif";
            Properties.AutoHeight = false;
            Properties.AutoWidth = true;
            Properties.GlyphAlignment = HorzAlignment.Far; //Text solunda gözüksün.
            Properties.Appearance.ForeColor = Color.Maroon;
        }

        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarDescription { get; set; } = "Kartın Kullanım Durumunu Seçiniz.";
    }
}
