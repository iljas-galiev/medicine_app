using System.Linq;
using CarApplication.Core;
using CarApplication.Model.Offer;
using LinqToDB;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApplication.Pages
{
    public class Index : PageModel
    {
        public string Message { get; set; }
        public IQueryable<OfferEntity> OfferList;

        public void OnGet()
        {
            OfferList = Db.Dc.GetTable<OfferEntity>().Where(o => o.Status == OfferEntity.Active).Take(3);
        }
    }
}
