using System;
using System.Collections.Generic;
using System.Linq;
using CarApplication.Core;
using CarApplication.Model.Offer;
using LinqToDB;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApplication.Pages.Profile
{
    public class Offers : PageModel
    {
        public IQueryable<OfferEntity> MyOffers;
        public int Filter = 1;

        public void OnGet(int filter = 1)
        {
            Filter = filter;
            Core.User.AllowAuth(HttpContext);

            var user = Convert.ToInt32(HttpContext.Session.GetString("user"));

            if (filter == 1)
                MyOffers = from offer in Db.Dc.GetTable<OfferEntity>()
                    where offer.UserId == user && offer.Status >= OfferEntity.New
                    select offer;
            else
                MyOffers = Db.Dc.GetTable<OfferEntity>()
                    .Where(o => o.UserId == user
                                && o.Status <= OfferEntity.Block);
        }
    }
}
