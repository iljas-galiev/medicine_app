using System;
using System.Linq;
using CarApplication.Core;
using CarApplication.Model.User;
using LinqToDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApplication.Pages.Profile
{
    public class Data : PageModel
    {
        public UserEntity Profile;

        public int Saved = 0;

        public void OnGet(int save = 0)
        {
            Saved = save;
            Core.User.AllowAuth(HttpContext);
            var user = Convert.ToInt32(HttpContext.Session.GetString("user"));

            Profile = Db.Dc.GetTable<UserEntity>()
                .FirstOrDefault(u => u.Id == user);

            if (Profile == null)
            {
                Core.User.LogOut(HttpContext);
                HttpContext.Response.StatusCode = 302;
                HttpContext.Response.Headers.Append("Location", "/");
            }
        }

        public void OnPost(string phone = "", string name = "")
        {
            Core.User.AllowAuth(HttpContext);
            var user = Convert.ToInt32(HttpContext.Session.GetString("user"));

            Profile = Db.Dc.GetTable<UserEntity>()
                .FirstOrDefault(u => u.Id == user);

            if (Profile == null)
            {
                Core.User.LogOut(HttpContext);
                HttpContext.Response.StatusCode = 302;
                HttpContext.Response.Headers.Append("Location", "/");
                return;
            }

            if (!string.IsNullOrEmpty(phone))
            {
                Profile.Phone = phone;
                if ((new UserRepository()).Save(Profile) != 0)
                {
                    HttpContext.Response.StatusCode = 301;
                    HttpContext.Response.Headers.Append("Location", "/profile/data?save=1");
                }
            }

            if (!string.IsNullOrEmpty(name))
            {
                Profile.Name = name;
                if ((new UserRepository()).Save(Profile) != 0)
                {
                    HttpContext.Response.StatusCode = 301;
                    HttpContext.Response.Headers.Append("Location", "/profile/data?save=1");
                }
            }
        }
    }
}
