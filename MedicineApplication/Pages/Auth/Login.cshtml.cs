using MedicineApplication.Model.User;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedicineApplication.Pages.Auth
{
    public class Login : PageModel
    {
        public UserEntity user = new UserEntity();
        public string Message = "";

        public void OnGet()
        {
            if (!Core.User.Instance().IsGuest)
            {
                HttpContext.Response.StatusCode = 301;
                HttpContext.Response.Headers.Add("Location", "/");
            }
        }

        public void OnPost(string Email, string Password)
        {
            user.Email = Email;
            user.Password = Password;
            if ((user = (new UserRepository()).Login(user)) != null)
            {
                HttpContext.Response.Cookies.Append("user", user.Id.ToString());
                HttpContext.Response.Cookies.Append("__code", Core.User.ComputeHash(user.Id.ToString() + user.Salt));

                Core.User.Instance().Auth(user);

                HttpContext.Response.StatusCode = 301;
                HttpContext.Response.Headers.Add("Location", "/");
            }
            else
            {
                Message = "Wrong Email or Password";
            }
        }
    }
}
