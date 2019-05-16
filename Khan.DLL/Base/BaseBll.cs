using Khan.DataAccessLayer.Interfaces;
using Khan.DLL.Functions;
using Khan.DLL.Interfaces;
using Khan.OgrenciTakip.Common.Enums;
using Khan.OgrenciTakip.Common.Functions;
using Khan.OgrenciTakip.Common.Message;
using Khan.OgrenciTakip.Model.Entities.Base;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Khan.DLL.Base
{
    public class BaseBll<T, TContext> : IBaseBll where T : BaseEntity where TContext : DbContext
    {
        private readonly Control _ctrl;
        private IUnitOfWork<T> _uow;

        protected BaseBll() { }

        protected BaseBll(Control ctrl)
        {
            _ctrl = ctrl;
        }

        //Tek kayıt
        protected TResult BaseSingle<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.Find(filter, selector);
        }

        protected IQueryable<TResult> BaseList<TResult>(Expression<Func<T, bool>> filter, Expression<Func<T, TResult>> selector)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            return _uow.Rep.Select(filter, selector);
        }

        protected bool BaseInsert(BaseEntity entity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            //Validation
            _uow.Rep.Insert(entity.EntityConvert<T>());
            return _uow.Save();
        }

        protected bool BaseUpdate(BaseEntity oldEntity, BaseEntity currentEntity, Expression<Func<T, bool>> filter)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);
            //Validation
            var changingAreas = oldEntity.GetChangingAreas(currentEntity);

            if (changingAreas.Count == 0) return true; //Update yapıldı.(False olursa sanki hata döndürmüş gibi olur.)

            _uow.Rep.Update(currentEntity.EntityConvert<T>(), changingAreas);
            return _uow.Save();
        }

        protected bool BaseDelete(BaseEntity entity, CardType cardType, bool showMessage = true)
        {
            GeneralFunctions.CreateUnitOfWork<T, TContext>(ref _uow);

            if (showMessage)
                if (Messages.DeleteMessage(cardType.ToName()) != DialogResult.Yes) return false;

            _uow.Rep.Delete(entity.EntityConvert<T>());
            return _uow.Save();
        }

        #region Dispose
        public void Dispose()
        {
            _ctrl?.Dispose();
            _uow?.Dispose();
        }
        #endregion
    }
}
