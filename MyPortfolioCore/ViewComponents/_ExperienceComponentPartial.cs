using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioCore.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
