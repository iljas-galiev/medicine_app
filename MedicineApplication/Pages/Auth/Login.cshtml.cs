using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using MedicineApplication.Model.User;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedicineApplication.Pages.Auth
{
    [AllowAnonymous]
    public class Login : PageModel
    {
        public UserEntity user = new UserEntity();
        public string Message = "";

        public void OnGet()
        {
            if (HttpContext.Session.Keys.Contains("user"))
            {
                HttpContext.Response.StatusCode = 301;
                HttpContext.Response.Headers.Add("Location", "/");
            }
        }

        public async void OnPost(string Email, string Password)
        {
            if (HttpContext.Session.Keys.Contains("user"))
            {
                HttpContext.Response.StatusCode = 301;
                HttpContext.Response.Headers.Add("Location", "/");
            }

            user.Email = Email;
            user.Password = Password;
            if ((user = (new UserRepository()).Login(user)) != null)

            {
                //  HttpContext.Response.Cookies.Append("user", user.Id.ToString());
                //  HttpContext.Response.Cookies.Append("__code", Core.User.ComputeHash(user.Id.ToString() + user.Salt));
                HttpContext.Session.SetString("user", user.Id.ToString());
                HttpContext.Session.SetString("user_email", user.Email.ToString());
                HttpContext.Session.SetString("user_salt", user.Salt.ToString());
                await Auth(user);

                HttpContext.Response.StatusCode = 301;
                HttpContext.Response.Headers.Add("Location", "/");
            }
            else
            {
                Message = "Wrong Email or Password";
            }
        }

        private async Task Auth(UserEntity user)
        {
            var claims = new List<Claim>()
            {
                //  new Claim(ClaimTypes.Name, user.Name),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Hash, user.Salt),
            };

            ClaimsIdentity ci = new ClaimsIdentity(claims);


            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(ci));
        }
    }
}
