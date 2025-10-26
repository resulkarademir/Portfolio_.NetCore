using Microsoft.AspNetCore.Mvc;

namespace Portfolio_.NetCore.ViewComponents
{
    public class _TestimonialComponentPartial :ViewComponent

    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
