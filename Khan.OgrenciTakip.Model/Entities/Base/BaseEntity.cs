﻿using Khan.OgrenciTakip.Model.Entities.Base.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khan.OgrenciTakip.Model.Entities.Base
{
    public class BaseEntity : IBaseEntity
    {
        //Biz bu id' yi elle vereceğiz.
        [Column(Order = 0), Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long Id { get; set; }
        [Column(Order = 1), Required, StringLength(20)]
        public virtual string Code { get; set; } //Override yapabilmek için virtual olarak tanımladık.
    }
}
