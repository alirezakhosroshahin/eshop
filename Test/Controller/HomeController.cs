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
        public HomeController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IActionResult Index()
        {
            return View(_courseService.GetAllCourse());
        }

        [Authorize]
        public string Test()
        {
            return "hello";
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
    }
}