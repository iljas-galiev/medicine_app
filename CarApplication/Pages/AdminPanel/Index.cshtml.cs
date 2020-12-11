using System.Linq;
using CarApplication.Core;
using CarApplication.Model.Offer;
using LinqToDB;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarApplication.Pages.AdminPanel
{
    public class Index : PageModel
    {
        public IQueryable<OfferEntity> OfferEntities;

        public void OnGet()
        {
            Core.User.AllowAdmin(HttpContext);
            OfferEntities = Db.Dc.GetTable<OfferEntity>();
        }
    }
}
