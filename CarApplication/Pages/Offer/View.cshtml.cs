using System;
using System.Linq;
using CarApplication.Core;
using CarApplication.Model.Offer;
using CarApplication.Model.User;
using LinqToDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApplication.Pages.Offer
{
    public class View : PageModel
    {
        public OfferEntity Offer = new OfferEntity();
        public IQueryable<OfferImageEntity> OfferImages;
        public UserEntity User = new UserEntity();

        public void OnGet(int id = 0)
        {
            var user = Convert.ToInt32(HttpContext.Session.GetString("user"));
            var offer = Db.Dc.GetTable<OfferEntity>()
                .FirstOrDefault(o => (o.Id == id && o.Status == OfferEntity.Active) ||
                                     (o.Id == id && o.UserId == user));
            if (offer == null)
            {
                HttpContext.Response.StatusCode = 302;
                HttpContext.Response.Headers.Add("Location", "/error/error404");
                return;
            }

            Offer = offer;
            OfferImages = Db.Dc.GetTable<OfferImageEntity>()
                .Where(o => o.OfferId == Offer.Id);

            User = Db.Dc.GetTable<UserEntity>()
                .FirstOrDefault(o => o.Id == offer.UserId);
        }
    }
}
