using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio_.NetCore.DAL.Context;
using Portfolio_.NetCore.DAL.Entities;

namespace Portfolio_.NetCore.Controllers
{
    [Authorize]

    public class PortfolioController : Controller
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IActionResult PortfolioList()
        {
            var value = _context.Portfolios.ToList();
            return View(value);
        }

        [HttpGet]
        public IActionResult PortfolioCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult PortfolioCreate(Portfolio portfolio)
        {
            _context.Portfolios.Add(portfolio);
            _context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }

        public IActionResult PortfolioDelete(int id)
        {

            var value = _context.Portfolios.Find(id);
            _context.Portfolios.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("PortfolioList");

        }
        [HttpGet]
        public IActionResult PortfolioUpdate(int id)
        {
            var value = _context.Portfolios.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult PortfolioUpdate(Portfolio portfolio)
        {
            _context.Portfolios.Update(portfolio);
            _context.SaveChanges();
            return RedirectToAction("PortfolioList");
        }


    }
}
