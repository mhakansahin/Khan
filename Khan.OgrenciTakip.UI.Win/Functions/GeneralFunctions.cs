using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid;
using Khan.OgrenciTakip.Common.Enums;
using Khan.OgrenciTakip.Common.Message;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khan.OgrenciTakip.UI.Win.Functions
{
    public static class GeneralFunctions
    {
        public static long GetRowId(this GridView table)
        {
            if (table.FocusedRowHandle > -1) return (long)table.GetFocusedRowCellValue("Id");
            Messages.UnSelectInformationMessage();
            return -1;
        }

        public static T GetRow<T>(this GridView table, bool showMessage = true)
        {
            if (table.FocusedRowHandle > -1) return (T)table.GetRow(table.FocusedRowHandle);

            if (showMessage)
                Messages.UnSelectInformationMessage();

            return default(T);
        }

        private static DataChangeLocation GetDataChangeLocation<T>(T oldEntity, T currentEntity)
        {
            foreach (var prop in currentEntity.GetType().GetProperties())
            {
                if (prop.PropertyType.Namespace == "System.Collections.Generic") continue;

                var oldValue = prop.GetValue(oldEntity) ?? string.Empty; //Gelen değer null ise string.Empty olarak al değeri.(null değerler karşılaştırılamaz!)
                var currentValue = prop.GetValue(currentEntity) ?? string.Empty; //Yukardakiyle aynı mantık.

                if (prop.PropertyType == typeof(byte[])) //Resim alanı mı ?
                {
                    if (string.IsNullOrEmpty(oldValue.ToString()))
                        oldValue = new byte[] { 0 };
                    if (string.IsNullOrEmpty(currentEntity.ToString()))
                        currentValue = new byte[] { 0 };

                    if (((byte[])oldValue).Length != ((byte[])currentValue).Length)
                        return DataChangeLocation.Area;
                }
                else if (!currentValue.Equals(oldValue))
                    return DataChangeLocation.Area;
            }

            return DataChangeLocation.NoChange;
        }

        public static void ButtonEnabledStatus<T>(BarButtonItem btnNew, BarButtonItem btnSave, BarButtonItem btnRetrieve, BarButtonItem btnDelete, T oldEntity, T currentEntity)
        {
            var dataExchangeLocation = GetDataChangeLocation(oldEntity, currentEntity);
            var buttonEnabledStatus = dataExchangeLocation == DataChangeLocation.Area;

            btnSave.Enabled = buttonEnabledStatus;
            btnRetrieve.Enabled = buttonEnabledStatus;
            btnNew.Enabled = !buttonEnabledStatus;
            btnDelete.Enabled = !buttonEnabledStatus;
        }
    }
}
