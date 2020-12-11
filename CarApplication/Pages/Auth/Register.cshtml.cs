using CarApplication.Model.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApplication.Pages.Auth
{
    public class Register : PageModel
    {
        public UserEntity user = new UserEntity();
        public string Message = "";

        public string Email;
        public string Name;
        public string Phone;

        public void OnGet()
        {
            Core.User.AllowGuest(HttpContext);
        }

        public void OnPost(string Email, string Password, string Passwordrepeat, string Name, string Phone)
        {
            Core.User.AllowGuest(HttpContext);

            this.Email = Email;
            this.Phone = Phone;
            this.Name = Name;

            user.Email = Email;
            user.Password = Password;
            user.PasswordRepeat = Passwordrepeat;
            user.Phone = Phone;
            user.Name = Name;

            if ((new UserRepository()).Register(user))
            {
                HttpContext.Response.StatusCode = 301;
                HttpContext.Response.Headers.Append("Location", "/auth/login");
            }
        }
    }
}
