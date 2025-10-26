using Microsoft.AspNetCore.Mvc;

namespace Portfolio_.NetCore.ViewComponents
{
    public class _FooterComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
