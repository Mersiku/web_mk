using Microsoft.AspNetCore.Mvc;
using web_mk.DAL;

namespace web_mk.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {
        FilmsContext db;

        public MenuViewComponent(FilmsContext db)
        {
            this.db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View("_Menu", db.Categories.ToList()));
            
        }

    }
}
