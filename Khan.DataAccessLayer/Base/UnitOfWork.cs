using Khan.DataAccessLayer.Interfaces;
using Khan.OgrenciTakip.Common.Message;
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;

namespace Khan.DataAccessLayer.Base
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : class
    {
        private readonly DbContext _context;

        public UnitOfWork(DbContext context)
        {
            if (context == null) return;
            _context = context;
        }

        public IRepository<T> Rep => new Repository<T>(_context);

        public bool Save()
        {
            bool result = false;

            try
            {
                _context.SaveChanges();
                result = true;
            }
            catch (DbUpdateException ex)
            {
                var sqlEx = (SqlException)ex.InnerException?.InnerException; //Null değilse innerexception ı al, değilse alma.

                if(sqlEx == null)
                {
                    Messages.ErrorMessage(ex.Message);
                }

                switch (sqlEx.Number)
                {
                    case 208:
                        Messages.ErrorMessage("İşlem yapmak istediğiniz tablo veri tabanında bulunamadı.");
                        break;
                    case 547:
                        Messages.ErrorMessage("Seçilen kartın işlem görmüş hareketleri var, kart silinemez.");
                        break;
                    case 2601:
                    case 2627:
                        Messages.ErrorMessage("Girmiş olduğunuz Id daha önce kullanılmıştır.");
                        break;
                    case 4060:
                        Messages.ErrorMessage("İşlem yapmak istediğiniz veri tabanı sunucuda bulunamadı.");
                        break;
                    case 18456:
                        Messages.ErrorMessage("Sunucuya bağlanılmak istenilen kullanıcı adı veya şifre hatalıdır.");
                        break;
                    default:
                        Messages.ErrorMessage(sqlEx.Message);
                        break;
                }

                return result;
            }
            catch (Exception ex)
            {
                Messages.ErrorMessage(ex.Message);

                return result;
            }

            return result;
        }

        #region Dispose
        private bool _disposedValue = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposedValue)
            {
                if (disposing)
                    _context.Dispose();

                _disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion

    }
}
