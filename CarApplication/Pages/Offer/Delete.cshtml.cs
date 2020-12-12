using System;
using System.Linq;
using CarApplication.Core;
using CarApplication.Model.Offer;
using LinqToDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApplication.Pages.Offer
{
    public class Delete : PageModel
    {
        public void OnGet(int id = 0)
        {
            Core.User.AllowAuth(HttpContext);

            var user = Convert.ToInt32(HttpContext.Session.GetString("user"));
            var offer = new OfferEntity();
            if (user != 2)
            {
                offer = Db.Dc.GetTable<OfferEntity>()
                    .FirstOrDefault(o => o.Id == id && o.UserId == user && o.Status != OfferEntity.BlockAdmin);
            }
            else
            {
                offer = Db.Dc.GetTable<OfferEntity>()
                    .FirstOrDefault(o => o.Id == id);
            }

            if (offer != null)
            {
                (new OfferRepository()).Delete(offer);
            }

            HttpContext.Response.StatusCode = 301;
            HttpContext.Response.Headers.Add("Location", "/profile/offers");
        }
    }
}
