using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using CarApplication.Core;
using LinqToDB;

namespace CarApplication.Model.User
{
    public class UserRepository : EntityRepository<UserEntity>
    {
        public override string TableName()
        {
            return "user";
        }

        public override Entity BeforeSave(Entity entity)
        {
            UserEntity userEntity = (UserEntity) entity;


            if (string.IsNullOrEmpty(userEntity.Name) || userEntity.Name.Length < 2)
            {
                userEntity.AddError("Имя", "Имя некорректно");
            }

            if (!IsValidEmail(userEntity.Email))
            {
                userEntity.AddError("E-mail", "E-mail неправильный");
            }

            if (!IsValidPhone(userEntity.Phone))
            {
                userEntity.AddError("Телефон", "Телефон неправильный");
            }

            if (!string.IsNullOrEmpty(userEntity.NewPassword))
            {
                if (string.IsNullOrEmpty(userEntity.OldPassword))
                    userEntity.AddError("Старый пароль", "Поле обязательно");
                if (userEntity.NewPassword.Length < 8)
                    userEntity.AddError("Новый пароль", "Пароль должен быть минимум 8 символов в длину");
                if (userEntity.NewPassword.Length > 16)
                    userEntity.AddError("Новый пароль", "Пароль должен быть максимум 16 символов в длину");

                if (userEntity.NewPassword != userEntity.NewPasswordRepeat)
                    userEntity.AddError("Новый пароль", "Пароли не совпадают");

                if (!Regex.IsMatch(userEntity.NewPassword, @"^([A-z0-9]){8,16}$", RegexOptions.IgnoreCase))
                    userEntity.AddError("Новый пароль", "Пароль некорректный");

                if (!string.IsNullOrEmpty(userEntity.OldPassword) &&
                    Core.User.ComputeHash(userEntity.OldPassword) != userEntity.Password)
                {
                    userEntity.AddError("Старый пароль", "Пароль некорректный");
                }

                if (userEntity.Errors.Count == 0)
                {
                    userEntity.Password = Core.User.ComputeHash(userEntity.NewPassword);
                }
            }

            return userEntity;
        }

        public bool Register(UserEntity userEntity)
        {
            //email, phome check
            if (string.IsNullOrEmpty(userEntity.Email))
            {
                userEntity.AddError("E-mail", "Необходимо заполнить поле");
            }

            if (string.IsNullOrEmpty(userEntity.Password))
            {
                userEntity.AddError("Пароль", "Необходимо заполнить поле");
            }

            if (string.IsNullOrEmpty(userEntity.PasswordRepeat))
            {
                userEntity.AddError("Повторите пароль", "Необходимо заполнить поле");
            }

            if (!IsValidEmail(userEntity.Email))
            {
                userEntity.AddError("E-mail", "E-mail неправильный");
            }

            if (userEntity.Password?.Length < 8)
            {
                userEntity.AddError("Пароль", "Пароль должен быть минимум 8 символов в длину");
            }

            if (userEntity.Password?.Length > 16)
            {
                userEntity.AddError("Пароль", "Пароль должен быть максимум 16 символов в длину");
            }

            if (userEntity.Password != userEntity.PasswordRepeat)
            {
                userEntity.AddError("Повторите пароль", "Пароли не совпадают");
            }

            if (userEntity.Errors.Count > 0) return false;

            userEntity.Status = 1;
            userEntity.Salt = Core.User.ComputeHash((new Random().Next().ToString()));

            userEntity.Password = Core.User.ComputeHash(userEntity.Password);
            userEntity.CreatedAt = DateTime.Now;
            userEntity.UpdatedAt = DateTime.Now;

            Db.Dc.Insert(userEntity);

            return true;
        }

        public UserEntity Login(UserEntity userEntity)
        {
            var user = Db.Dc.GetTable<UserEntity>().FirstOrDefault(u =>
                u.Email == userEntity.Email
                && u.Password == Core.User.ComputeHash(userEntity.Password)
            );

            return user;
        }

        public int Save(UserEntity entity)
        {
            int id = 0;
            if (!Validate(entity)) return 0;

            if (!entity.IsNewRecord)
            {
                id = Db.Dc.Update(entity);
            }
            else
            {
                id = Db.Dc.InsertWithInt32Identity(entity);
            }

            return id;
        }

        public static bool IsValidEmail(string email)
        {
            var res = Regex.IsMatch(email, @"\b[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b", RegexOptions.IgnoreCase);

            return res;
        }

        public static bool IsValidPhone(string phone)
        {
            return Regex.IsMatch(phone, @"^(\s*)?(\+)?([- _():=+]?\d[- _():=+]?){10,14}(\s*)?$",
                RegexOptions.IgnoreCase);
        }
    }
}
