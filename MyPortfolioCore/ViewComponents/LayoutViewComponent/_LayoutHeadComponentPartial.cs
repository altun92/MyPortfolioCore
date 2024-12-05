using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioCore.ViewComponents.LayoutViewComponent
{
    public class _LayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
