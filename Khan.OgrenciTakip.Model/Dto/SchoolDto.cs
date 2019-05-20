using Khan.OgrenciTakip.Model.Entities;
using Khan.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khan.OgrenciTakip.Model.Dto
{
    [NotMapped]
    public class SchoolS : School //S -> Single
    {
        public string CityName { get; set; }
        public string CountyName { get; set; }
    }

    public class SchoolL : BaseEntity //L -> List
    {
        public string SchoolName { get; set; }
        public string CityName { get; set; }
        public string CountyName { get; set; }
        public string Description { get; set; }
    }
}
