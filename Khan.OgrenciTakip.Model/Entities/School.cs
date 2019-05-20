using Khan.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khan.OgrenciTakip.Model.Entities
{
    public class School : BaseStatusEntity
    {
        [Index("IX_Code", IsUnique = true)]
        public override string Code { get; set; }

        [Required, StringLength(50)]
        public string SchoolName { get; set; }
        public long CityId { get; set; }
        public long CountyId { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public City City { get; set; }
        public County County { get; set; }
    }
}
