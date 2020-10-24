using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using MedicineApplication.Model.User;

namespace MedicineApplication.Core
{
    public class EntityRepository<T> where T : Entity<T>, new()
    {
        public virtual string TableName()
        {
            return "";
        }

        public List<T> FindAll(string cond = "1")
        {
            var sql = $"SELECT * FROM {TableName()} WHERE {cond}";
            var data = Db.All(sql);

            var dataSet = new List<T>();
            foreach (var item in data)
            {
                var model = new T();
                model.IsNewRecord = false;

                var t = model.GetType();
                var props = t.GetProperties();

                foreach (var prop in props)
                    if (item.ContainsKey(prop.Name.ToLower()) && prop.CanWrite)
                        prop.SetValue(model, Convert.ChangeType(item[prop.Name.ToLower()], prop.PropertyType), null);

                dataSet.Add(model);
            }

            return dataSet;
        }

        public T FindOne(string cond = "1")
        {
            var sql = $"SELECT * FROM {TableName()} WHERE {cond}";
            var data = Db.Row(sql);
            if (data.Count == 0) throw new HttpRequestException("Not found");
            var model = new T();
            model.IsNewRecord = false;

            var t = model.GetType();
            var props = t.GetProperties();

            foreach (var prop in props)
                if (data.ContainsKey(prop.Name.ToLower()) && prop.CanWrite)
                    prop.SetValue(model, Convert.ChangeType(data[prop.Name.ToLower()], prop.PropertyType), null);

            return model;
        }

        public bool Save(Entity<T> entity)
        {
            var props = entity.GetType().GetProperties();
            var set = new List<string>();
            foreach (var safeAttribute in entity.SafeAttributes)
            {
                var prop = props.Single(x => x.Name == safeAttribute);
                if (prop != null)
                    set.Add($"`{safeAttribute.ToLower()}` = '{prop.GetValue(entity)}'");
            }

            entity = BeforeSave(entity);

            if (entity.IsNewRecord)
            {
                return Db.Execute($"INSERT INTO {TableName()} SET {String.Join(", ", set)}");
            }

            var pk = props.Single(x => x.Name == entity.PrimaryKey).GetValue(entity);
            return Db.Execute($"UPDATE {TableName()} SET {String.Join(", ", set)} WHERE `{entity.PrimaryKey.ToLower()}` = '{pk}'");
        }

        public bool Delete(Entity<T> entity)
        {
            var props = entity.GetType().GetProperties();
            var pk = props.Single(x => x.Name == entity.PrimaryKey).GetValue(entity);
            return Db.Execute($"DELETE FROM {TableName()} WHERE `{entity.PrimaryKey.ToLower()}` = '{pk}'");
        }


        public virtual Entity<T> BeforeSave(Entity<T> entity)
        {
            return entity;
        }
    }
}
