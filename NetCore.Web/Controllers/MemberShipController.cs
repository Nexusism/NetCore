using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NetCore.Data.ViewModels;
using NetCore.Services.interfaces;
using NetCore.Services.Svcs;
using NetCore.Web.Models;

namespace NetCore.Web.Controllers
{
    public class MemberShipController : Controller
    {
        // 의존성 주입 - 생성자 주입(닷넷코어 기본제공)
        private IUser _user;

        public MemberShipController(IUser user)
        {
            _user = user;
        }
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
        // Services => Web
        // Services 
        public IActionResult Login(LoginInfo login)
        {
            string message = string.Empty;

            if (ModelState.IsValid)
            {
                // 뷰모델
                // 서비스 개념

                //if (login.UserId.Equals(userId) && login.Password.Equals(password))
                if (_user.MatchTheUserInfo(login))

                {
                    TempData["Message"] = "로그인이 성공적으로 이루어졌습니다.";

                    return RedirectToAction("Index", "MemberShip");
                }
                else
                {
                    message = "로그인되지 않았습니다.";
                }
            }
            else
            {
                message = "로그인 정보를 올바르게 입력하세요.";

            }

            ModelState.AddModelError(string.Empty, message);
            return View(login);
        }

    }
}
