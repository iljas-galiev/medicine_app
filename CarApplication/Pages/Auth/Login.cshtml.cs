using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using CarApplication.Model.User;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApplication.Pages.Auth
{
    public class Login : PageModel
    {
        public UserEntity User = new UserEntity();

        public string Email = "";
        public string Password = "";

        public string Message = "";

        public void OnGet()
        {
            Core.User.AllowGuest(HttpContext);
        }

        public async void OnPost(string Email, string Password, string Remember = "off")
        {
            Core.User.AllowGuest(HttpContext);
            Core.User.LogOut(HttpContext);

            this.Email = Email;
            this.Password = Password;

            User.Email = Email;
            User.Password = Password;
            UserEntity user = (new UserRepository()).Login(User);
            if (user != null)

            {
                HttpContext.Session.SetString("user", user.Id.ToString());
                HttpContext.Session.SetString("user_email", user.Email.ToString());
                HttpContext.Session.SetString("user_salt", user.Salt.ToString());
                HttpContext.Session.SetString("user_name", user.Name.ToString());


                if (Remember == "on")
                {
                    HttpContext.Response.Cookies.Append("user",
                        user.Id.ToString(),
                        new CookieOptions() {Expires = DateTime.Now.AddMonths(1)}
                    );
                    HttpContext.Response.Cookies.Append("__code",
                        Core.User.ComputeHash(user.Id.ToString() + user.Salt)
                        , new CookieOptions() {Expires = DateTime.Now.AddMonths(1)}
                    );
                }

                HttpContext.Response.StatusCode = 301;
                HttpContext.Response.Headers.Add("Location", "/");
                return;
            }
            else
            {
                Message = "Неправильная почта или пароль";
            }
        }
    }
}
