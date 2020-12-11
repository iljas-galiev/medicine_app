using System.Linq;
using CarApplication.Core;
using CarApplication.Model.Offer;
using CarApplication.Model.User;
using LinqToDB;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;

namespace CarApplication.Pages
{
    public class User : PageModel
    {
        public UserEntity UserEntity = new UserEntity();
        public IQueryable<OfferEntity> Offers;

        public void OnGet(int id)
        {
            UserEntity = Db.Dc.GetTable<UserEntity>().FirstOrDefault(u => u.Id == id);

            if (UserEntity == null)
            {
                HttpContext.Response.StatusCode = 302;
                HttpContext.Response.Headers.Append("Location", "/error/error404");
            }

            Offers = Db.Dc.GetTable<OfferEntity>()
                .Where(o => o.UserId == UserEntity.Id && o.Status == OfferEntity.Active);
        }
    }
}
