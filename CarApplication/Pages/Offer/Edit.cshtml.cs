using System;
using System.Collections.Generic;
using System.Linq;
using CarApplication.Core;
using CarApplication.Model.Offer;
using LinqToDB;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApplication.Pages.Offer
{
    public class Edit : PageModel
    {
        public OfferEntity Offer = new OfferEntity();

        private IWebHostEnvironment _environment;

        public Edit(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public void OnGet(int id = 0)
        {
            Core.User.AllowAuth(HttpContext);

            var user = Convert.ToInt32(HttpContext.Session.GetString("user"));
            var offer = Db.Dc.GetTable<OfferEntity>()
                .FirstOrDefault(o => o.Id == id && o.UserId == user);
            if (offer == null)
            {
                HttpContext.Response.StatusCode = 302;
                HttpContext.Response.Headers.Add("Location", "/error/error404");
            }

            Offer = offer;

            //    HttpContext.Response.StatusCode = 301;
            //    HttpContext.Response.Headers.Add("Location", "/profile/offers");
        }

        public void OnPost(int id, string title, string model, string brand, string phone, string price,
            string email, string description, IFormFileCollection uploads)
        {
            Core.User.AllowAuth(HttpContext);

            var user = Convert.ToInt32(HttpContext.Session.GetString("user"));
            var offer = Db.Dc.GetTable<OfferEntity>()
                .FirstOrDefault(o => o.Id == id && o.UserId == user && o.Status != OfferEntity.BlockAdmin);
            if (offer != null)
            {
                Core.User.AllowAuth(HttpContext);
                Offer = offer;

                Offer.Title = title;
                Offer.Brand = brand;
                Offer.Model = model;
                Offer.Phone = phone;
                Double.TryParse(price, out double priceD);
                Offer.Price = priceD;
                Offer.Email = email;
                Offer.Description = description;

                var photos = new List<string>();

                var rep = new OfferRepository();
                if (rep.Validate(Offer))
                {
                    if (uploads.Count > 0)
                    {
                        Offer.MainPicture = OfferImageEntity.Upload(uploads[0], _environment);
                        if (uploads.Count > 1)
                            for (int i = 1; i < uploads.Count; i++)
                            {
                                photos.Add(OfferImageEntity.Upload(uploads[i], _environment));
                            }
                    }

                    rep.Save(Offer);

                    foreach (var photo in photos)
                    {
                        var photoEntity = new OfferImageEntity();
                        photoEntity.OfferId = Offer.Id;
                        photoEntity.Image = photo;
                        photoEntity.Save();
                    }

                    HttpContext.Response.StatusCode = 301;
                    HttpContext.Response.Headers.Add("Location", "/profile/offers");
                }
            }
        }
    }
}
