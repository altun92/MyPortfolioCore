using Microsoft.AspNetCore.Mvc;
using MyPortfolioCore.DAL.Context;
using MyPortfolioCore.DAL.Entities;

namespace MyPortfolioCore.Controllers
{
    public class DefaultController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SendMessage()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SendMessage(Message message)
        {
            context.Messages.Add(message);
            message.SendDate = DateTime.Now;
            context.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
    }
}
