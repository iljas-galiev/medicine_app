using MedicineApplication.Core;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedicineApplication.Pages
{
    public class Index : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
        }
    }
}
