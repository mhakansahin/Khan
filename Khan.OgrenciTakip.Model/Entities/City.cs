using Khan.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khan.OgrenciTakip.Model.Entities
{
    public class City : BaseStatusEntity
    {
        public string CityName { get; set; }
        public string Description { get; set; }
    }
}
