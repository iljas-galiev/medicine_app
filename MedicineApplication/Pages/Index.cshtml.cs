using MedicineApplication.Core;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedicineApplication.Pages
{
    public class Index : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Db.Execute("SELECT 1;");
            if (Core.User.Instance().IsGuest) Message = "Guest";
            else Message = Core.User.Instance().Role;
        }
    }
}
