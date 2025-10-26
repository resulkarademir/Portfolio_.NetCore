using Microsoft.AspNetCore.Mvc;
using Portfolio_.NetCore.DAL.Context;

namespace Portfolio_.NetCore.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfolioContext _context =new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=_context.Experiences.ToList();
            return View(values);
        }
    }
}
