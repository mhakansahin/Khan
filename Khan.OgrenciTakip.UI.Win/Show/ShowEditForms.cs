using Khan.OgrenciTakip.Common.Enums;
using Khan.OgrenciTakip.UI.Win.Forms.BaseForms;
using Khan.OgrenciTakip.UI.Win.Show.Interfaces;
using System;

namespace Khan.OgrenciTakip.UI.Win.Show
{
    public class ShowEditForms<TForm> : IBaseFormShow where TForm : BaseEditForm
    {
        public long ShowDialogEditForm(CardType cardType, long id)//, params object[] prm)
        {
            //Yetki kontrolü

            using (var frm = (TForm)Activator.CreateInstance(typeof(TForm)))
            {
                frm.operationType = id > 0 ? OperationType.EntityUpdate : OperationType.EntityInsert;
                frm.Id = id;
                frm.Fill();
                frm.ShowDialog();
                return frm.Refresh ? frm.Id : 0;
            }
        }
    }
}
