using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Khan.DataAccessLayer.Interfaces
{
    public interface IUnitOfWork<T> : IDisposable where T : class //Yapılacak birden çok işlemi tek seferde database' e gönderecek.
    {
        IRepository<T> Rep { get; } //Sadece veri alacağız, veri göndermeyeceğiz. Bu yüzden set yok.
        bool Save(); //İlem başarılı olduysa true, olmadıysa false dönecek.
    }
}
