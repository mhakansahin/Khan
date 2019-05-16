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

        public static DialogResult OnSelectYesNo(string message, string caption)
        {
            return XtraMessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
        }

        public static DialogResult OffSelectYesNo(string message, string caption)
        {
            return XtraMessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
        }

        public static DialogResult DeleteMessage(string cardName)
        {
            return OffSelectYesNo($"Seçtiğiniz {cardName} silinecektir. Onaylıyor musunuz?", "Silme Onayı");
        }
    }
}
