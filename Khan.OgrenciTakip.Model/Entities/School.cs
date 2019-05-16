using Khan.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khan.OgrenciTakip.Model.Entities
{
    public class School : BaseStatusEntity
    {
        public string SchoolName { get; set; }
        public long CityId { get; set; }
        public long CountyId { get; set; }
        public string Description { get; set; }

        public City City { get; set; }
        public County County { get; set; }
    }
}
