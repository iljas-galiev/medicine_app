using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using LinqToDB;
using MedicineApplication.Model.User;

namespace MedicineApplication.Core
{
    public class EntityRepository<T> where T : Entity, new()
    {
        public virtual string TableName()
        {
            return "";
        }

        public bool Save(Entity entity)
        {
            entity = BeforeSave(entity);

            if (entity.IsNewRecord)
                Db.Dc.Insert(entity);
            else Db.Dc.Update(entity);

            return true;
        }

        public bool Delete(Entity entity)
        {
            return Db.Dc.Delete(entity) != 0;
        }


        public virtual Entity BeforeSave(Entity entity)
        {
            return entity;
        }
    }
}
