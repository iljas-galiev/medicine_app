using System;
using System.Collections.Generic;
using System.Linq;
using CarApplication.Core;
using CarApplication.Model.Offer;
using CarApplication.Model.User;
using LinqToDB;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApplication.Pages.Offer
{
    public class Create : PageModel
    {
        public OfferEntity Offer = new OfferEntity();
        public string Title = "";
        public string Model = "";
        public string Brand = "";
        public string Email = "";
        public string Phone = "";
        public string Price = "";
        public IFormFileCollection Uploads;

        public string Description = "";

        private IWebHostEnvironment _environment;

        public Create(IWebHostEnvironment environment)
        {
            _environment = environment;
        }


        public void OnGet()
        {
            Core.User.AllowAuth(HttpContext);
            var user = Convert.ToInt32(HttpContext.Session.GetString("user"));

            var Profile = Db.Dc.GetTable<UserEntity>()
                .FirstOrDefault(u => u.Id == user);
            Email = Profile.Email;
            Phone = Profile.Phone;
        }

        public void OnPost(string title, string model, string brand, string phone, string price, string email,
            string description, IFormFileCollection uploads)
        {
            Core.User.AllowAuth(HttpContext);


            Title = title;
            Model = model;
            Brand = brand;
            Phone = phone;
            Price = price;
            Email = email;
            Description = description;
            Uploads = uploads;


            Offer.IsNewRecord = true;

            Offer.Title = Title;
            Offer.Brand = Brand;
            Offer.Model = Model;
            Offer.Phone = Phone;
            Double.TryParse(Price, out double priceD);
            Offer.Price = priceD;
            Offer.Email = Email;
            Offer.Description = Description;
            Offer.Status = OfferEntity.Active;

            Offer.UserId = Convert.ToInt32(HttpContext.Session.GetString("user"));

            var photos = new List<string>();

            var rep = new OfferRepository();
            if (rep.Validate(Offer))
            {
                if (Uploads.Count > 0)
                {
                    Offer.MainPicture = OfferImageEntity.Upload(Uploads[0], _environment);
                    if (Uploads.Count > 1)
                        for (int i = 1; i < Uploads.Count; i++)
                        {
                            photos.Add(OfferImageEntity.Upload(Uploads[i], _environment));
                        }
                }

                Offer.Id = rep.Save(Offer);

                foreach (var photo in photos)
                {
                    var photoEntity = new OfferImageEntity();
                    photoEntity.OfferId = Offer.Id;
                    photoEntity.Image = photo;
                    photoEntity.Save();
                }

                HttpContext.Response.StatusCode = 301;
                HttpContext.Response.Headers.Add("Location", "/profile/offers"); //todo redirect to offers
            }
        }
    }
}
