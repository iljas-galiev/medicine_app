using MedicineApplication.Core;

namespace MedicineApplication.Model.User
{
    public class UserRepository : EntityRepository<UserEntity>
    {
        public override string TableName()
        {
            return "user";
        }

        public override Entity BeforeSave(Entity user)
        {
            return user;
        }

    }
}
