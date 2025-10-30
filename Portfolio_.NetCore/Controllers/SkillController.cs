using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio_.NetCore.DAL.Context;
using Portfolio_.NetCore.DAL.Entities;

namespace Portfolio_.NetCore.Controllers
{
    [Authorize]

    public class SkillController : Controller
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IActionResult SkillList()
        {
            var values = _context.Skills.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult SkillCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SkillCreate(Skill skill)
        {
            _context.Skills.Add(skill);
            _context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        public IActionResult SkillDelete(int id)
        {

            var value = _context.Skills.Find(id);
            _context.Skills.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("SkillList");
        }

        [HttpGet]
        public IActionResult SkillUpdate(int id)
        {
            var values = _context.Skills.Find(id);
            return View(values);

        }

        [HttpPost]
        public IActionResult SkillUpdate(Skill skill)
        {
            _context.Skills.Update(skill);
            _context.SaveChanges();
            return RedirectToAction("SkillList");


        }

    }
}
