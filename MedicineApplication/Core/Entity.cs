using System.Collections.Generic;

namespace MedicineApplication.Core
{
    public class Entity
    {
        public List<string> SafeAttributes;
        public bool IsNewRecord;
        public string PrimaryKey;

        public Dictionary<string, string> Errors = new Dictionary<string, string>();

        public void AddError(string key, string message)
        {
            if(!Errors.ContainsKey(key))
                Errors.Add(key, message);
        }

        public Entity()
        {
            IsNewRecord = true;
        }



    }
}
