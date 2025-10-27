using Microsoft.AspNetCore.Mvc;

namespace Portfolio_.NetCore.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
