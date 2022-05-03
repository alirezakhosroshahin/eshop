using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test.DataLayer.Context;
using Test.DataLayer.Entities.Course;

namespace Test.Pages.Admin.CourseGroup
{
    public class EditModel : PageModel
    {
        private readonly Test.DataLayer.Context.TestContext _context;

        public EditModel(Test.DataLayer.Context.TestContext context)
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
           ViewData["ParentId"] = new SelectList(_context.CourseGroups, "GroupId", "GroupTitle");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(CourseGroup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CourseGroupExists(CourseGroup.GroupId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CourseGroupExists(int id)
        {
            return _context.CourseGroups.Any(e => e.GroupId == id);
        }
    }
}
