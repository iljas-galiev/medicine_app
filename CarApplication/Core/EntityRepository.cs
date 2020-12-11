using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using LinqToDB;
using CarApplication.Model.User;

namespace CarApplication.Core
{
    public class EntityRepository<T> where T : Entity, new()
    {
        public virtual string TableName()
        {
            return "";
        }

        public bool Validate(Entity entity)
        {
            entity = BeforeSave(entity);

            if (entity.Errors.Count != 0) return false;
            return true;
        }

        public int Save(Entity entity)
        {
            int id = 0;
            if (!Validate(entity)) return 0;

            if (entity.IsNewRecord)
            {
                id = Db.Dc.Insert(entity);
            }
            else
            {
                id = Db.Dc.Update(entity);
            }

            return id;
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
