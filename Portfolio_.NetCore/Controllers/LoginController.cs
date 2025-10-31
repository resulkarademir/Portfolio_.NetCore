using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Portfolio_.NetCore.DAL.Context;
using Portfolio_.NetCore.DAL.Entities;
using System.Security.Claims;

namespace Portfolio_.NetCore.Controllers
{
    public class LoginController : Controller
    {
        MyPortfolioContext _context = new MyPortfolioContext();


        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(Login login)
        {
            var value = _context.Logins.FirstOrDefault(x => x.UserName == login.UserName && x.UserPassword == login.UserPassword);
            if (value != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, login.UserName)
                };
                var useridentity= new ClaimsIdentity(claims,"Login");
                ClaimsPrincipal principal= new ClaimsPrincipal(useridentity);
                await HttpContext.SignInAsync(principal);
                return RedirectToAction("Index","Dashboard");

            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("SignIn","Login");
      
        }
    }
}
