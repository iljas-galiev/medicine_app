using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApplication.Pages
{
    public class Logout : PageModel
    {
        public void OnGet()
        {
            Core.User.LogOut(HttpContext);
            HttpContext.Response.StatusCode = 301;
            HttpContext.Response.Headers.Add("Location", "/");
        }
    }
}
