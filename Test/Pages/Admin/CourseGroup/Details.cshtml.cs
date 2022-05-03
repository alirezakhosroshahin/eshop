using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Test.DataLayer.Context;
using Test.DataLayer.Entities.Course;

namespace Test.Pages.Admin.CourseGroup
{
    public class DetailsModel : PageModel
    {
        private readonly Test.DataLayer.Context.TestContext _context;

        public DetailsModel(Test.DataLayer.Context.TestContext context)
        {
            _context = context;
        }

        public DataLayer.Entities.Course.CourseGroup CourseGroup { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CourseGroup = await _context.CourseGroups
                .Include(c => c.Parent).FirstOrDefaultAsync(m => m.GroupId == id);

            if (CourseGroup == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
