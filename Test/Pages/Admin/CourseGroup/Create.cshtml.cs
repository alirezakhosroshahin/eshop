using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Test.DataLayer.Context;
using Test.DataLayer.Entities.Course;

namespace Test.Pages.Admin.CourseGroup
{
    public class CreateModel : PageModel
    {
        private readonly Test.DataLayer.Context.TestContext _context;

        public CreateModel(Test.DataLayer.Context.TestContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            List<SelectListItem> list = new List<SelectListItem>()
        {
            new SelectListItem() {Text = "انتخاب کنید ...", Value = ""}
        };


            list.AddRange(_context.CourseGroups.Where(p => p.ParentId == null)
            .Select(r =>
                new SelectListItem()
                {
                    Text = r.GroupTitle,
                    Value = r.GroupId.ToString()
                }).ToList());
            ViewData["ParentId"] = list;
            return Page();
        }

        [BindProperty]
        public DataLayer.Entities.Course.CourseGroup CourseGroup { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.CourseGroups.Add(CourseGroup);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
