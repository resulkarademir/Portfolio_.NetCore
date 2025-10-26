using Microsoft.AspNetCore.Mvc;

namespace Portfolio_.NetCore.ViewComponents
{
    public class _NavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}
