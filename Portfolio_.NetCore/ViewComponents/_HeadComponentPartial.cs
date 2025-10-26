using Microsoft.AspNetCore.Mvc;

namespace Portfolio_.NetCore.ViewComponents
{
    public class _HeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
