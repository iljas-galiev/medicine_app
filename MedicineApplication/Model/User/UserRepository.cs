using System.Security.Cryptography;
using LinqToDB;
using MedicineApplication.Core;

namespace MedicineApplication.Model.User
{
    public class UserRepository : EntityRepository<UserEntity>
    {
        public override string TableName()
        {
            return "user";
        }

        public override Entity BeforeSave(Entity entity)
        {
            UserEntity user = (UserEntity) entity;
            if (user.Password?.Length > 0)
            {
                user.Password = Core.User.ComputeHash(user.Password);
            }
            return user;
        }

        public bool Register(UserEntity userEntity)
        {
            if (userEntity.Email == null)
            {
                userEntity.AddError("E-mail","E-mail is required");
            }
            if (userEntity.Password == null)
            {
                userEntity.AddError("Password","Password is required");
            }
            if (userEntity.PasswordRepeat == null)
            {
                userEntity.AddError("Password repeat","Password repeat is required");
            }

            if (!IsValidEmail(userEntity.Email))
            {
                userEntity.AddError("E-mail","E-mail is incorrect");
            }

            if (userEntity.Password?.Length < 6)
            {
                userEntity.AddError("Password", "Password must be at least 6 characters long");
            }

            if (userEntity.Password != userEntity.PasswordRepeat)
            {
                userEntity.AddError("Password", "Passwords don't match");
            }

            if (userEntity.Errors.Count > 0) return false;

            Db.Dc.Insert(userEntity);

            return true;
        }

        static bool IsValidEmail(string email)
        {
            try {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch {
                return false;
            }
        }
    }
}
