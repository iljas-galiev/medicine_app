using System.Collections.Generic;

namespace MedicineApplication.Core
{
    public class Entity<T> where T : Entity<T>, new()
    {
        public List<string> SafeAttributes;
        public bool IsNewRecord;
        public string PrimaryKey;

        public Entity()
        {
            IsNewRecord = true;
        }

    }
}
