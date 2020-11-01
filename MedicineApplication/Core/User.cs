using System.Linq;
using System.Text;
using MedicineApplication.Model.User;
using Microsoft.AspNetCore.Http;
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

        public static string ComputeHash(string password)
        {
            return string.Join("",
                MD5.Create().ComputeHash(Encoding.ASCII.GetBytes(password)).Select(s => s.ToString("x2")));
        }


        public void IsAuth()
        {
            if (Context.Request.Cookies.ContainsKey("user"))
            {
                IsGuest = false;
                Role = Context.Request.Cookies["user"];
            }
            else
            {
                Context.Response.Cookies.Append("user", "guest");
            }
        }
    }
}
