using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioCore.ViewComponents.LayoutViewComponent
{
    public class _LayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
