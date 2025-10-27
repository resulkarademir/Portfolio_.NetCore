using Microsoft.AspNetCore.Mvc;
using Portfolio_.NetCore.DAL.Context;

namespace Portfolio_.NetCore.ViewComponents
{
    public class _SocialMediaComponentPartial:ViewComponent
    {
        MyPortfolioContext _context = new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value=_context.SocialMedias.ToList();
            return View(value);
        }

    }
}
