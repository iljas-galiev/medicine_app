using System;
using System.Linq;
using CarApplication.Core;
using CarApplication.Model.Offer;
using LinqToDB;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApplication.Pages.Offer
{
    public class List : PageModel
    {
        public string Brand;
        public string Model;
        public string Price;
        public string Search;


        public void OnGet(string brand = "", string model = "", string price = "", string search = "")
        {
            Brand = brand;
            Model = model;
            Price = price;
            Search = search;


        }

    }
}
