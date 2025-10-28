using Microsoft.AspNetCore.Mvc;
using Portfolio_.NetCore.DAL.Context;
using Portfolio_.NetCore.DAL.Entities;

namespace Portfolio_.NetCore.Controllers
{
    public class AboutController : Controller
    {

        MyPortfolioContext _context =new MyPortfolioContext();
        public IActionResult AboutList()
        {
            var value=_context.Abouts.ToList();
            return View(value);
        }

		[HttpGet]
		public IActionResult AboutCreate()
		{
		return View();
		}
		[HttpPost]
		public IActionResult AboutCreate(About about)
		{
			 _context.Abouts.Add(about);
			_context.SaveChanges();
			return RedirectToAction("AboutList");
		}


        public IActionResult AboutDelete(int id)
        {
            var value = _context.Abouts.Find(id);
            _context.Abouts.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("AboutList");
        }


        [HttpGet]
        public IActionResult AboutUpdate(int id)
        {
            var value = _context.Abouts.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult AboutUpdate(About about)
        {
            _context.Abouts.Update(about);
            _context.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}
