using Microsoft.AspNetCore.Mvc;
using Portfolio_.NetCore.DAL.Context;

namespace Portfolio_.NetCore.ViewComponents
{
    public class _ContactComponentPartial:ViewComponent
    {
        MyPortfolioContext _context =new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value= _context.Contacts.ToList();
            return View(value);
        }
    }
}
