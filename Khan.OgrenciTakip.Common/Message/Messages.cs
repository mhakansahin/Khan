using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Khan.OgrenciTakip.Common.Message
{
    public class Messages
    {
        public static void ErrorMessage(string errorMessage)
        {
            XtraMessageBox.Show(errorMessage, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
