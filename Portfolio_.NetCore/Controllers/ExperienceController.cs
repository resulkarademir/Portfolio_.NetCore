using Microsoft.AspNetCore.Mvc;
using Portfolio_.NetCore.DAL.Context;
using Portfolio_.NetCore.DAL.Entities;

namespace Portfolio_.NetCore.Controllers
{
    public class ExperienceController : Controller
    {
        MyPortfolioContext _context =new MyPortfolioContext();
        public IActionResult ExperienceList()
        {
            var values=_context.Experiences.ToList();
            return View(values);
        }


        [HttpGet]
		public IActionResult ExperienceCreate()
		{
			return View();
		}


		[HttpPost]
		public IActionResult ExperienceCreate(Experience experience)
		{
			_context.Experiences.Add(experience);
			_context.SaveChanges();
			return RedirectToAction("ExperienceList");
 		}

		public IActionResult ExperienceDelete(int id) 
		{
            var value = _context.Experiences.Find(id);
            _context.Experiences.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }



        [HttpGet]
        public IActionResult ExperienceUpdate(int id)
        {
            var value = _context.Experiences.Find(id);
            return View(value);
        }


        [HttpPost]
        public IActionResult ExperienceUpdate(Experience experience)
        {
            _context.Experiences.Update(experience);
            _context.SaveChanges();
            return RedirectToAction("ExperienceList");
        }
    }
}
