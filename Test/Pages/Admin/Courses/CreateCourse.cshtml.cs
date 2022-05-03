using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Test.Core.Services.Interface;
using Test.DataLayer.Entities.Course;

namespace Test.Pages.Courses
{
    public class CreateCourseModel : PageModel
    {
        private ICourseService _courseService;

        public CreateCourseModel(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [BindProperty] public DataLayer.Entities.Course.Course Course { get; set; }

        public void OnGet()
        {
            var group = _courseService.GetGroupForManageCourse();
            ViewData["Group"] = new SelectList(group, "Value", "Text");
            
            var SubGroup = _courseService.GetSubGroupForManageCourse(Int32.Parse(group.First().Value));
            ViewData["SubGroup"] = new SelectList(SubGroup, "Value", "Text");
            
            var teachers = _courseService.GetTeachers();
            ViewData["Teachers"]=new SelectList(teachers,"Value","Text");

            var levels = _courseService.GetLevels();
            ViewData["Levels"] = new SelectList(levels, "Value", "Text");

            var statues = _courseService.GetStatues();
            ViewData["Statues"] = new SelectList(statues, "Value", "Text");
        }
        
        public IActionResult OnPost(IFormFile imgCourseUp, IFormFile demoUp)
        {
            if(!ModelState.IsValid)
                return Page();

            _courseService.AddCourse(Course,imgCourseUp,demoUp);

            return RedirectToPage("Index");
        }
    }
}