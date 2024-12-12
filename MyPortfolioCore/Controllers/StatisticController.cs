using Microsoft.AspNetCore.Mvc;
using MyPortfolioCore.DAL.Context;

namespace MyPortfolioCore.Controllers
{
    public class StatisticController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            ViewBag.experienceCount = context.Experiences.Count();
            ViewBag.skillCount = context.Skills.Count();
            ViewBag.messageCount = context.Messages.Count();
            ViewBag.testimonialCount = context.Testimonials.Count();
            return View();
        }
    }
}
