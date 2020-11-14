using System;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using LinqToDB;
using MedicineApplication.Model.User;
using Microsoft.AspNetCore.Http;
using Ubiety.Dns.Core;
using MD5 = System.Security.Cryptography.MD5;

namespace MedicineApplication.Core
{
    public class User
    {
        public HttpContext Context;
        private static User _user;

        public static User Instance()
        {
            if (_user == null)
            {
                _user = new User();
            }

            return _user;
        }

        public bool IsGuest = true;
        public string Role = "Guest";

        public int Id;
        public UserEntity Entity;

        public static string ComputeHash(string str)
        {
            return string.Join("",
                MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(str)).Select(s => s.ToString("x2")));
        }


        public void Auth(UserEntity user)
        {
            Id = user.Id;
            Entity = user;
            IsGuest = false;
        }

        public void IsAuth()
        {
            if (Context.Request.Cookies.ContainsKey("user"))
            {
                Context.Request.Cookies.TryGetValue("user", out string user);
                Context.Request.Cookies.TryGetValue("__code", out string code);
                if (user == "guest") return;

                var userEntity = Db.Dc.GetTable<UserEntity>().FirstOrDefault(u => u.Id == Convert.ToInt32(user));
                if (userEntity.Id != 0 && code == ComputeHash(userEntity.Id.ToString() + userEntity.Salt))
                {
                    IsGuest = false;
                }
            }
            else
            {
                Context.Response.Cookies.Append("user", "guest");
            }
        }
    }
}
