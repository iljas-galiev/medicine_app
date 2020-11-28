using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using LinqToDB;
using MedicineApplication.Core;
using MedicineApplication.Model.Message;
using MedicineApplication.Model.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedicineApplication.Pages.Chat
{
    public class Index : PageModel
    {
        public MessageContent[] Messages;
        public void OnGet()
        {
            /*
            var isGuest = Core.User.Instance().IsGuest;
            if (isGuest)
            {
                HttpContext.Response.StatusCode = 301;
                HttpContext.Response.Headers.Add("Location", "/auth/login");
                Redirect("/auth/login");
            }*/

            var res = from msg in Db.Dc.GetTable<MessageEntity>()
                    join user in Db.Dc.GetTable<UserEntity>() on msg.UserId equals user.Id
                    orderby msg.Datetime descending
                    select new MessageContent { userName = user.Email, dateTime = msg.Datetime, text = msg.Text };
            Messages = res.ToArray();
        }
    }
}
