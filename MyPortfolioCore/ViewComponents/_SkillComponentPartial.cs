using Microsoft.AspNetCore.Mvc;

namespace MyPortfolioCore.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
