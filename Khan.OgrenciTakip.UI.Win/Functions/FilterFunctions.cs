using Khan.OgrenciTakip.Model.Entities.Base;
using System;
using System.Linq.Expressions;

namespace Khan.OgrenciTakip.UI.Win.Functions
{
    public class FilterFunctions
    {
        public static Expression<Func<T, bool>> Filter<T>(bool showActiveCards) where T : BaseStatusEntity
        {
            return x => x.Status == showActiveCards;
        }

        public static Expression<Func<T, bool>> Filter<T>(long id) where T : BaseStatusEntity
        {
            return x => x.Id == id;
        }
    }
}
