using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Test.Core.Convertors;
using Test.Core.DTOs;
using Test.Core.Generator;
using Test.Core.Security;
using Test.Core.Senders;
using Test.Core.Services.Interface;
using Test.DataLayer.Entities.User;

namespace Test.Controller
{
    public class AccountController : Microsoft.AspNetCore.Mvc.Controller
    {
        private IUserServices _userServices;
        private IViewRenderService _viewRender;

        public AccountController(IUserServices userServices, IViewRenderService viewRender)
        {
            _userServices = userServices;
            _viewRender = viewRender;
        }

        [Route("Register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [Route("Register")]
        public IActionResult Register(RegisterViewModel register)
        {
            if (!ModelState.IsValid)
                return View(register);

            if (_userServices.IsExistEmail(register.Email))
            {
                return View(register);
            }

            if (_userServices.IsExistUserName(register.UserName))
            {
                return View(register);
            }

            User user = new User()
            {
                Email = register.Email.Trim().ToLower(),
                Password = PasswordHelper.EncodePasswordMd5(register.Password),
                ActiveCode = NameGenerator.GenerateUnicCode(),
                IsActive = false,
                RegisterDate = DateTime.Now,
                UserAvatar = "Default.jpg",
                UserName = register.UserName
            };
            _userServices.AddUser(user);

            #region send Email

            string body = _viewRender.RenderToStringAsync("_ActiveEmail", user);
            SendEmail.Send(user.Email, "فعالسازی", body);

            #endregion

            return View("SuccessRegister", user);
        }

        [Route("Login")]
        public IActionResult Login(bool EditProfile=false)
        {
            ViewBag.EditProfile = EditProfile;
            return View();
        }

        [HttpPost]
        [Route("Login")]
        public IActionResult Login(LoginViewModel login)
        {
            if (!ModelState.IsValid)
            {
                return View(login);
            }

            User user = _userServices.LoginUser(login);

            if (user != null)
            {
                if (user.IsActive)
                {
                    var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.NameIdentifier, user.UserId.ToString()),
                        new Claim(ClaimTypes.Name, user.UserName),
                    };
                    var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    var principal = new ClaimsPrincipal(identity);

                    var properties = new AuthenticationProperties
                    {
                        IsPersistent = login.RememberMe
                    };
                    HttpContext.SignInAsync(principal, properties);

                    ViewBag.IsSuccess = true;
                    return View();
                }
                else
                {
                    ModelState.AddModelError("Email", "حساب کاربری شما فعال نمی باشد");
                    View(login);
                }
            }

            ModelState.AddModelError("Email", "کاربری با مشخصات وارد شده یافت نشد");
            return View(login);
        }


        public IActionResult ActiveAccount(string id)
        {
            ViewBag.IsActive = _userServices.ActiveAcount(id);
            
            return View();
        }
        
        [Route("Logout")]
        public IActionResult Logout()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return Redirect("Login");
        }
    }
}