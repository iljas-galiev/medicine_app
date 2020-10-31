using System.Collections.Generic;

namespace MedicineApplication.Core
{
    public class Entity
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
