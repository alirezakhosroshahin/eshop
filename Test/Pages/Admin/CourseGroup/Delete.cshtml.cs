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
    public class DeleteModel : PageModel
    {
        private readonly Test.DataLayer.Context.TestContext _context;

        public DeleteModel(Test.DataLayer.Context.TestContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            CourseGroup = await _context.CourseGroups.FindAsync(id);

            if (CourseGroup != null)
            {
                _context.CourseGroups.Remove(CourseGroup);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
