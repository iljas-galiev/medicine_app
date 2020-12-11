using System;
using System.Linq;
using CarApplication.Core;
using CarApplication.Model.Offer;
using LinqToDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApplication.Pages.Offer
{
    public class Block : PageModel
    {
        public void OnGet(int id = 0, int status = 0)
        {
            Core.User.AllowAuth(HttpContext);

            var user = Convert.ToInt32(HttpContext.Session.GetString("user"));
            var offer = Db.Dc.GetTable<OfferEntity>()
                .FirstOrDefault(o => o.Id == id && o.UserId == user && o.Status != OfferEntity.BlockAdmin);
            if (offer != null)
            {
                if (status == 1)
                {
                    offer.Status = OfferEntity.Active;
                    (new OfferRepository()).Save(offer);
                }

                else
                {
                    offer.Status = OfferEntity.Block;
                    (new OfferRepository()).Save(offer);
                }
            }

            HttpContext.Response.StatusCode = 301;
            HttpContext.Response.Headers.Add("Location", "/profile/offers");
        }
    }
}
