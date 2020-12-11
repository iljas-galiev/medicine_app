using System;
using System.IO;
using System.Linq;
using CarApplication.Core;
using CarApplication.Model.User;
using LinqToDB;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApplication.Pages.Profile
{
    public class Index : PageModel
    {
        public UserEntity Profile;

        private IWebHostEnvironment _environment;

        public Index(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

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

        public void OnPost(string email = "", IFormFile avatar = null)
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

            if (!string.IsNullOrEmpty(email))
            {
                Profile.Email = email;
                if ((new UserRepository()).Save(Profile) != 0)
                {
                    HttpContext.Response.StatusCode = 301;
                    HttpContext.Response.Headers.Append("Location", "/profile/index?save=1");
                }
            }

            if (avatar != null)
            {
                if (avatar.ContentType == "image/jpeg"
                    || avatar.ContentType == "image/png"
                    || avatar.ContentType == "image/gif"
                )
                {
                    var random = new Random();
                    var path = "/Files/" + random.Next().ToString() + "_" + avatar.FileName;
                    Save(avatar, path);

                    Profile.Image = path;
                    if ((new UserRepository()).Save(Profile) != 0)
                    {
                        HttpContext.Response.StatusCode = 301;
                        HttpContext.Response.Headers.Append("Location", "/profile/index?save=1");
                    }
                }
            }
        }

        private async void Save(IFormFile avatar, string path)
        {
            await using var fileStream = new FileStream(_environment.WebRootPath + path, FileMode.Create);
            await avatar.CopyToAsync(fileStream);
        }
    }
}
