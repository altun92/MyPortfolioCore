using Microsoft.AspNetCore.Mvc;
using MyPortfolioCore.DAL.Context;
using MyPortfolioCore.DAL.Entities;

namespace MyPortfolioCore.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateExperience(Experience experience)
        {
            context.Experiences.Add(experience);
            context.SaveChanges();
            return RedirectToAction("ExperienceList", "Experience");
        }

        public IActionResult DeleteExperience(int id)
        {
            var values = context.Experiences.Find(id);
            context.Experiences.Remove(values);
            context.SaveChanges();
            return RedirectToAction("ExperienceList", "Experience");
        }

        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value = context.Experiences.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateExperience(Experience experience)
        {
            var value = context.Experiences.Find(experience.ExperienceId);
            value.Head = experience.Head;
            value.Title = experience.Title;
            value.Description = experience.Description;
            value.Date = experience.Date;
            context.SaveChanges();
            return RedirectToAction("ExperienceList", "Experience");
        }
    }
}
