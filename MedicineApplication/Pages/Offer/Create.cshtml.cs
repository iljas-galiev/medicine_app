using System;
using MedicineApplication.Model.Offer;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedicineApplication.Pages.Offer
{
    public class Create : PageModel
    {
        public OfferEntity Offer = new OfferEntity();
        public string Title { get; set; }
        public string Model { get; set; }
        public string Brand { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Price { get; set; }

        public string Description { get; set; }
        // photos


        public void OnGet()
        {
        }

        public void OnPost()
        {
            Offer.Title = Title;
            Offer.Brand = Brand;
            Offer.Model = Model;
            Offer.Phone = Phone;
            Offer.Price = Convert.ToDouble(Price);
            Offer.Email = Email;
            Offer.Description = Description;

            //photos

            if ((new OfferRepository()).Save(Offer))
            {

                HttpContext.Response.StatusCode = 301;
                HttpContext.Response.Headers.Add("Location", "/"); //todo redirect to offers
            }
        }
    }
}
