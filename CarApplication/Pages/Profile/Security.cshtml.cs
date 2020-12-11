using System;
using System.Linq;
using CarApplication.Core;
using CarApplication.Model.User;
using LinqToDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApplication.Pages.Profile
{
    public class Security : PageModel
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

        public void OnPost(string oldPassword, string newPassword, string newPasswordRepeat)
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

            Profile.OldPassword = oldPassword;
            Profile.NewPassword = newPassword;
            Profile.NewPasswordRepeat = newPasswordRepeat;

            if ((new UserRepository()).Save(Profile) != 0)
            {
                HttpContext.Response.StatusCode = 301;
                HttpContext.Response.Headers.Append("Location", "/profile/security?save=1");
            }
        }
    }
}
