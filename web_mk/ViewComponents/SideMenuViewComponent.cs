using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using web_mk.DAL;

namespace web_mk.ViewComponents
{
    public class SideMenuViewComponent : ViewComponent
    {
        FilmsContext db;

        public SideMenuViewComponent(FilmsContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(string categoryName)
        {
            var category = db.Categories.Include("Films").Where(c => c.Name.ToUpper() == categoryName.ToUpper()).FirstOrDefault();

            var films = category.Films.OrderBy(c=>c.Title).ToList();

            return await Task.FromResult(View("_SideMenu", films));
        }
    }
}
