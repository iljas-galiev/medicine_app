using System.Collections.Generic;

namespace CarApplication.Core
{
    public class Entity
    {
        public List<string> SafeAttributes;
        public bool IsNewRecord = false;
        public string PrimaryKey;

        public Dictionary<string, string> Errors = new Dictionary<string, string>();

        public void AddError(string key, string message)
        {
            if (!Errors.ContainsKey(key))
                Errors.Add(key, message);
        }

        public Entity()
        {
        }
    }
}
