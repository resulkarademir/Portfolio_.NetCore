using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio_.NetCore.DAL.Context;
using Portfolio_.NetCore.DAL.Entities;

namespace Portfolio_.NetCore.Controllers
{
    [Authorize]

    public class FeatureController : Controller
    {
        MyPortfolioContext _context=new MyPortfolioContext();
        public IActionResult FeatureList()
        {
            var value= _context.Features.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult FeatureCreate()
        {
            return View();
        }
        [HttpPost]
        public IActionResult FeatureCreate(Feature feature)
        {
            _context.Features.Add(feature);
            _context.SaveChanges();
            return RedirectToAction("FeatureList");
        }


        public IActionResult FeatureDelete(int id) 
        {
            var value = _context.Features.Find(id);
            _context.Features.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("FeatureList");
        
        }

        [HttpGet]
        public IActionResult FeatureUpdate(int id)
        {
            var value=_context.Features.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult FeatureUpdate(Feature feature)
        {
            _context.Features.Update(feature);
            _context.SaveChanges();
            return RedirectToAction("FeatureList");
        }

    }
}
