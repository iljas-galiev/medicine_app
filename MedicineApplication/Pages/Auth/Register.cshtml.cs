using MedicineApplication.Model.User;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedicineApplication.Pages.Auth
{
    public class Register : PageModel
    {
        public UserEntity user = new UserEntity();
        public string Message = "";

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Password { get; set; }

        [BindProperty]
        public string Passwordrepeat { get; set; }


        public void OnGet()
        {

            /*if ()
            {
                HttpContext.Response.StatusCode = 301;
                HttpContext.Response.Headers.Add("Location", "/");
            }*/
        }

        public void OnPost()
        {
                user.Email = Email;
                user.Password = Password;
                user.PasswordRepeat = Passwordrepeat;

                if ((new UserRepository()).Register(user))
                {
                    Message = "Success";
                }
        }
    }
}
