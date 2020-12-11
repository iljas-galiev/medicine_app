using System;
using System.Linq;
using CarApplication.Core;
using CarApplication.Model.Offer;
using LinqToDB;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApplication.Pages.Offer
{
    public class Ajax : PageModel
    {
        public string Brand;
        public string Model;
        public string Price;
        public string Search;

        public IQueryable<OfferEntity> Offers;

        public void OnGet(string brand = "", string model = "", string price = "", string search = "")
        {
            Brand = brand;
            Model = model;
            Price = price;
            Search = search;

            Double.TryParse(Price, out double priceD);

            Offers = Db.Dc.GetTable<OfferEntity>().Where(o=>o.Status==OfferEntity.Active);
            if (!string.IsNullOrWhiteSpace(Brand))
            {
                Offers = Offers.Where(o => o.Brand.Contains(Brand));
            }

            if (!string.IsNullOrWhiteSpace(Model))
            {
                Offers = Offers.Where(o => o.Model.Contains(Model));
            }

            if (!string.IsNullOrWhiteSpace(Search))
            {
                Offers = Offers.Where(o => o.Title.Contains(Search) || o.Description.Contains(Search));
            }

            if (priceD > 0)
            {
                Offers = Offers.Where(o => o.Price <= priceD);
            }
        }
    }
}
