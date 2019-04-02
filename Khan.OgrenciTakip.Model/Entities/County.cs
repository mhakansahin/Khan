using Khan.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khan.OgrenciTakip.Model.Entities
{
    public class County : BaseStatusEntity
    {
        public string CountyName { get; set; }
        public long CityId { get; set; }
        public string Description { get; set; }

        public City City { get; set; }
    }
}
