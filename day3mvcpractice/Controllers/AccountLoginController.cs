using Microsoft.AspNetCore.Mvc;
using day3mvcpractice.Models;

namespace day3mvcpractice.Controllers
{
    public class AccountLoginController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string userid, string password)
        {
            if(userid == "bright" && password== "1234567")
            {
                return RedirectToAction("Welcomepage");
            }
            else
            {
                return RedirectToAction("Login");
            }
            return View();
        }

        public IActionResult Welcomepage()
        {
            return View();
        }
    }
}
