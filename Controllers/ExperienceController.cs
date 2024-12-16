using Microsoft.AspNetCore.Mvc;
using MyPortfolio.DAL.Context;
using MyPortfolio.DAL.Entities;

namespace MyPortfolio.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext Context = new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values =Context.Experiences.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateExperience()
        {
            return View();
        }
        public IActionResult CreateExperience(Experience experience)
        {
           Context.Experiences.Add(experience);
           Context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        public IActionResult DeleteExperience(int id )
        {
            var value = Context.Experiences.Find(id);
            Context.Experiences.Remove(value);  
            Context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
        [HttpGet]
        public IActionResult UpdateExperience(int id)
        {
            var value =Context.Experiences.Find(id);
            return View(value);
        }
        [HttpPost]
        public  IActionResult UpdateExperience(Experience experience)
        {
            Context.Experiences.Update(experience);
            Context.SaveChanges();
            return RedirectToAction("ExperienceList");

        }
    }
}
