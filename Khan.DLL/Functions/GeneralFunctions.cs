using Khan.DataAccessLayer.Base;
using Khan.DataAccessLayer.Interfaces;
using Khan.OgrenciTakip.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khan.DLL.Functions
{
    public static class GeneralFunctions
    {
        public static List<string> GetChangingAreas<T>(this T oldEntity, T currentEntity)
        {
            List<string> areas = new List<string>();

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
                        areas.Add(prop.Name);
                }
                else if (!currentValue.Equals(oldValue))
                    areas.Add(prop.Name);
            }

            return areas;
        }

        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["StudentTrackingContext"].ConnectionString;
        }

        private static TContext CreateContext<TContext>() where TContext : DbContext
        {
            return (TContext)Activator.CreateInstance(typeof(TContext), GetConnectionString());
        }

        public static void CreateUnitOfWork<T, TContext>(ref IUnitOfWork<T> uow) where T : class, IBaseEntity where TContext : DbContext
        {
            uow?.Dispose(); //uow null değilse dispose yap.
            uow = new UnitOfWork<T>(CreateContext<TContext>());
        }
    }
}
