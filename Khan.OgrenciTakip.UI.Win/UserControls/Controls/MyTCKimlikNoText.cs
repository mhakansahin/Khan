﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Utils;
using DevExpress.XtraEditors.Mask;

namespace Khan.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)]
    public class MyTCKimlikNoText : MyTextEdit
    {
        public MyTCKimlikNoText()
        {
            Properties.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
            Properties.Mask.MaskType = MaskType.Regular;
            Properties.Mask.EditMask = @"\d?\d?\d?\d?\d?\d?\d?\d?\d?\d?\d?";
            Properties.Mask.AutoComplete = AutoCompleteType.None;
            StatusBarDescription = "TC Kimlik No Giriniz.";
        }
    }
}
