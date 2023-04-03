using Microsoft.AspNetCore.Mvc;
using NetCore.Web.Models;

namespace NetCore.Web.Controllers
{
    public class MemberShipController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginInfo login)
        {
            string message = string.Empty;

            if (ModelState.IsValid)
            {
                string userId = "ffpower";
                string password = "123456";
            }
            else
            {
                message = "로그인 정보를 올바르게 입력하세요.";

            }
            return View(login);
        }

    }
}
