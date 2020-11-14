using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedicineApplication.Pages.Chat
{
    public class Index : PageModel
    {
        public void OnGet()
        {
            if (Core.User.Instance().IsGuest)
            {
                HttpContext.Response.StatusCode = 301;
                HttpContext.Response.Headers.Add("Location", "/auth/login");
            }
        }
    }
}
