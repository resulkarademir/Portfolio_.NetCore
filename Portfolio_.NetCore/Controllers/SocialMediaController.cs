using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio_.NetCore.DAL.Context;
using Portfolio_.NetCore.DAL.Entities;

namespace Portfolio_.NetCore.Controllers
{
    [Authorize]

    public class SocialMediaController : Controller
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IActionResult SocialMediaList()
        {
            var value = _context.SocialMedias.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult SocialMediaCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SocialMediaCreate(SocialMedia socialMedia)
        {
            _context.SocialMedias.Add(socialMedia);
            _context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        public IActionResult SocialMediaDelete(int id)
        {

            var value = _context.SocialMedias.Find(id);
            _context.SocialMedias.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }

        [HttpGet]
        public IActionResult SocialMediaUpdate(int id)
        {
            var value = _context.SocialMedias.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult SocialMediaUpdate(SocialMedia socialMedia)
        {
            _context.SocialMedias.Update(socialMedia);
            _context.SaveChanges();
            return RedirectToAction("SocialMediaList");
        }


    }
}
