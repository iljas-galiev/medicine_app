using MedicineApplication.Core;

namespace MedicineApplication.Model.User
{
    public class UserRepository : EntityRepository<UserEntity>
    {
        public override string TableName()
        {
            return "user";
        }

        public override Entity<UserEntity> BeforeSave(Entity<UserEntity> user)
        {
            return user;
        }
    }
}
