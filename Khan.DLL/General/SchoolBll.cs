using Khan.DLL.Base;
using Khan.OgrenciTakip.Data.Contexts;
using Khan.OgrenciTakip.Model.Dto;
using Khan.OgrenciTakip.Model.Entities;
using Khan.OgrenciTakip.Model.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Windows.Forms;
using Khan.OgrenciTakip.Common.Enums;
using System.Linq;

namespace Khan.DLL.General
{
    public class SchoolBll : BaseBll<School, StudentTrackingContext>
    {
        public SchoolBll() { }

        public SchoolBll(Control ctrl) : base(ctrl) { }

        public BaseEntity Single(Expression<Func<School, bool>> filter)
        {
            return BaseSingle(filter, x => new SchoolS
            {
                Id = x.Id,
                Code = x.Code,
                SchoolName = x.SchoolName,
                CityId = x.CityId,
                CityName = x.City.CityName,
                CountyId = x.CountyId,
                CountyName = x.County.CountyName,
                Description = x.Description,
                Status = x.Status
            });
        }

        public IEnumerable<BaseEntity> List(Expression<Func<School, bool>> filter)
        {
            return BaseList(filter, x => new SchoolL
            {
                Id = x.Id,
                Code = x.Code,
                SchoolName = x.SchoolName,
                CityName = x.City.CityName,
                CountyName = x.County.CountyName,
                Description = x.Description
            }).OrderBy(x => x.Code).ToList();
        }

        public bool Insert(BaseEntity entity)
        {
            return BaseInsert(entity, x => x.Code == entity.Code);
        }

        public bool Update(BaseEntity oldEntity, BaseEntity currentEntity)
        {
            return BaseUpdate(oldEntity, currentEntity, x => x.Code == currentEntity.Code);
        }

        public bool Delete(BaseEntity entity)
        {
            return BaseDelete(entity, CardType.School);
        }
    }
}
