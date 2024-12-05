using Microsoft.AspNetCore.Mvc;
using MyPortfolioCore.DAL.Context;

namespace MyPortfolioCore.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfolioContext portfolioContext = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = portfolioContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.subDescription = portfolioContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.detail = portfolioContext.Abouts.Select(x => x.Detail).FirstOrDefault();
            return View();
        }
    }
}
