using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using LinqToDB;
using MedicineApplication.Core;
using MedicineApplication.Model.Message;
using MedicineApplication.Model.User;
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

            var Messages = from msg in Db.Dc.GetTable<MessageEntity>()
                    join user in Db.Dc.GetTable<UserEntity>() on msg.UserId equals user.Id
                    select new { userName = user.Name, dateTime = msg.Datetime, text = msg.Text };
        }
    }
}
