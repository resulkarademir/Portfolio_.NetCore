using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portfolio_.NetCore.DAL.Context;
using Portfolio_.NetCore.DAL.Entities;

namespace Portfolio_.NetCore.Controllers
{
    [Authorize]

    public class ContactController : Controller
    {
        MyPortfolioContext _context =new MyPortfolioContext();
        public IActionResult ContactList()
        {
            var value=_context.Contacts.ToList();   
            return View(value);
        }


        [HttpGet]
        public IActionResult ContactCreate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactCreate(Contact contact)
        {
            var value = _context.Contacts.Add(contact);
            _context.SaveChanges();
            return RedirectToAction("ContactList");
        }

        public IActionResult ContactDelete(int id)
        {
           var value=_context.Contacts.Find(id);
            _context.Contacts.Remove(value);
            _context.SaveChanges();
            return RedirectToAction("ContactList");
        }


        [HttpGet]
        public IActionResult ContactUpdate(int id)
        {
            var value = _context.Contacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult ContactUpdate(Contact contact)
        {
            var value = _context.Contacts.Update(contact);
            _context.SaveChanges();
            return RedirectToAction("ContactList");
        }
    }
}
