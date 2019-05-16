using Khan.OgrenciTakip.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khan.DLL.Functions
{
    public static class Converts
    {
        public static TTarget EntityConvert<TTarget>(this IBaseEntity source)
        {
            if (source == null) return default(TTarget);

            var target = Activator.CreateInstance<TTarget>();
            var sourceProp = source.GetType().GetProperties();
            var targetProp = typeof(TTarget).GetProperties();

            foreach (var sp in sourceProp)
            {
                var value = sp.GetValue(source);
                var tp = targetProp.FirstOrDefault(x => x.Name == sp.Name);
                if (tp != null)
                    tp.SetValue(target, ReferenceEquals(value, "") ? null : value); //Database ' e null olarak kaydet.
            }

            return target;
        }
    }
}
