using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Test.Core.Services.Interface;

namespace Test.Controller
{
    public class HomeController : Microsoft.AspNetCore.Mvc.Controller
    {
        private ICourseService _courseService;
        private IUserServices _userServices;

        public HomeController(ICourseService courseService, IUserServices userServices)
        {
            _courseService = courseService;
            _userServices = userServices;
        }
        
        public IActionResult Index()
        {
            return View(_courseService.GetAllCourse());
        }

        public IActionResult GetSubGroups(int id)
        {
            List<SelectListItem> list=new List<SelectListItem>()
            {
                new SelectListItem(){Text = "انتخاب کنید",Value = ""}
            };
            list.AddRange(_courseService.GetSubGroupForManageCourse(id));
            return Json(new SelectList(list, "Value", "Text"));
        }
        
        [Route("OnlinePayment/{id}")]
        public IActionResult onlinePayment(int id) 
        {
            if (HttpContext.Request.Query["Status"] != "" &&
                HttpContext.Request.Query["Status"].ToString().ToLower() == "ok"
                && HttpContext.Request.Query["Authority"] != "")
            {
                string authority = HttpContext.Request.Query["Authority"];

                var wallet = _userServices.GetWalletByWalletId(id);

                var payment = new ZarinpalSandbox.Payment(wallet.Amount);
                var res = payment.Verification(authority).Result;
                if (res.Status == 100)
                {
                    ViewBag.code = res.RefId;
                    ViewBag.IsSuccess = true;
                    wallet.IsPay = true;
                    _userServices.UpdateWallet(wallet);
                }
            }
            return View();
        }
    }
}