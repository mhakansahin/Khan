﻿using DevExpress.XtraEditors;
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
    public class MyCheckEdit : CheckEdit, IStatusBarDescription
    {
        public MyCheckEdit()
        {
            Properties.AppearanceFocused.BackColor = Color.Transparent;
        }
        public override bool EnterMoveNextControl { get; set; } = true;

        public string StatusBarDescription { get; set; }
    }
}
