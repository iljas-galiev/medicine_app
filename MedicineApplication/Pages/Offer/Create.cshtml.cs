using System;
using MedicineApplication.Model.Offer;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MedicineApplication.Pages.Offer
{
    public class Create : PageModel
    {
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
            var offer = new OfferEntity();

            offer.Title = Title;
            offer.Brand = Brand;
            offer.Model = Model;
            offer.Phone = Phone;
            offer.Price = Convert.ToDouble(Price);
            offer.Email = Email;
            offer.Description = Description;

            //photos

            if ((new OfferRepository()).Save(offer))
            {

                HttpContext.Response.StatusCode = 301;
                HttpContext.Response.Headers.Add("Location", "/"); //todo redirect to offers
            }
        }
    }
}
