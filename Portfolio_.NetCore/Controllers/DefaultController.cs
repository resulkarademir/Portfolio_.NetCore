using Microsoft.AspNetCore.Mvc;

namespace Portfolio_.NetCore.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
