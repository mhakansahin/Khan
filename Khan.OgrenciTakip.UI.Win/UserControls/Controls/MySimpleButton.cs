using DevExpress.XtraEditors;
using Khan.OgrenciTakip.UI.Win.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khan.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MySimpleButton : SimpleButton, IStatusBarDescription
    {
        public MySimpleButton()
        {
            Appearance.ForeColor = Color.Maroon;
        }

        public string StatusBarDescription { get; set; }
    }
}
