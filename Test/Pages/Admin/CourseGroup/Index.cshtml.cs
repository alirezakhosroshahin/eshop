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
    public class IndexModel : PageModel
    {
        private readonly Test.DataLayer.Context.TestContext _context;

        public IndexModel(Test.DataLayer.Context.TestContext context)
        {
            _context = context;
        }

        public IList<DataLayer.Entities.Course.CourseGroup> CourseGroup { get;set; }

        public async Task OnGetAsync()
        {
            CourseGroup = await _context.CourseGroups
                .Include(c => c.Parent).ToListAsync();
        }
    }
}
