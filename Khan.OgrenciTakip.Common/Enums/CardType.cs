using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khan.OgrenciTakip.Common.Enums
{
    public enum CardType : byte //enum default olarak int gelir. Biz byte olarak değiştirdik.
    {
        [Description("Okul Kartı")]
        School = 1,
        [Description("İl Kartı")]
        City = 2,
        [Description("İlçe Kartı")]
        County = 3
    }
}
