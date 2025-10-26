using Microsoft.AspNetCore.Mvc;
using Portfolio_.NetCore.DAL.Context;

namespace Portfolio_.NetCore.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfolioContext _context= new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=_context.Features.ToList();
            return View(values);
        }
    }
}
