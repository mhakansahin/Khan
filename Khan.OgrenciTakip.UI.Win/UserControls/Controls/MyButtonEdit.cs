using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using Khan.OgrenciTakip.UI.Win.Interfaces;
using System;
using System.ComponentModel;
using System.Drawing;

namespace Khan.OgrenciTakip.UI.Win.UserControls.Controls
{
    [ToolboxItem(true)] //Toolbox' a eklemek için.
    public class MyButtonEdit : ButtonEdit, IStatusBarShortCut
    {
        public MyButtonEdit()
        {
            Properties.TextEditStyle = TextEditStyles.DisableTextEditor;
            Properties.AppearanceFocused.BackColor = Color.LightCyan;
        }

        public override bool EnterMoveNextControl { get; set; } = true; 
        public string StatusBarDescription { get; set; }
        public string StatusBarShortCut { get; set; } = "F4 :";
        public string StatusBarShortCutDescription { get; set; }

        #region Events
        private long? _id;

        [Browsable(false)] //Property listesinde gözükmemesi için.
        public long? Id
        {
            get { return _id; }
            set
            {
                var oldValue = _id;
                var newValue = value;

                if (newValue == oldValue) return;

                _id = value;
                IdChanged?.Invoke(this, new IdChangedEventArgs(oldValue, newValue)); //null kontrolü
            }
        }

        public event EventHandler<IdChangedEventArgs> IdChanged;  
        #endregion
    }

    public class IdChangedEventArgs : EventArgs
    {
        public IdChangedEventArgs(long? oldValue, long? newValue)
        {
            OldValue = oldValue;
            NewValue = newValue;
        }

        public long? OldValue { get; }
        public long? NewValue { get; set; }
    }
}
