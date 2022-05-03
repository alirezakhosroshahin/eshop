using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Test.Core.DTOs;
using Test.Core.Services.Interface;

namespace Test.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private IUserServices _userServices;

        public HomeController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        public IActionResult Index()
        {
            return View(_userServices.GetUserInformation(User.Identity.Name));
        }

        [Route("UserPanel/EditProfile")]
        public IActionResult EditProfile()
        {
            return View(_userServices.GetDataForEditProfileUser(User.Identity.Name));
        }

        [HttpPost]
        [Route("UserPanel/EditProfile")]
        public IActionResult EditProfile(EditProfileViewModel edit)
        {
            _userServices.EditProfile(User.Identity.Name, edit);
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("/Login?EditProfile=true");
        }


        [Route("UserPanel/ChangePassword")]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        [Route("UserPanel/ChangePassword")]
        public IActionResult ChangePassword(ChangePasswordViewModel change)
        {
            var compare = _userServices.CompareOldPassword(change.OldPassword, User.Identity.Name);
            if (!ModelState.IsValid)
                return View(change);
            if (!compare)
            {
                ModelState.AddModelError("OldPassword", "کلمه عبور فعلی صحیح نمیباشد");
                return View(change);
            }

            _userServices.ChangeUserPassword(User.Identity.Name, change.Password);
            ViewBag.IsSuccess = true;
            return View();
        }
    }
}