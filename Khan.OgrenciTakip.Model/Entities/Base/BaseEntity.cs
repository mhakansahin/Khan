using Khan.OgrenciTakip.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khan.OgrenciTakip.Model.Entities.Base
{
    public class BaseEntity : IBaseEntity
    {
        //Biz bu id' yi elle vereceğiz.
        public long Id { get; set; }
        public string Code { get; set; }
    }
}
