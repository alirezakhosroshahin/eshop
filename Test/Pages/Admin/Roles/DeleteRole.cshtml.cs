using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test.Core.Security;
using Test.Core.Services.Interface;
using Test.DataLayer.Entities.User;

namespace Test.Pages.Admin.Roles
{
    [PermissionChecker(1007)]
    public class DeleteRoleModel : PageModel
    {
        private IPermissionService _permissionService;

        public DeleteRoleModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }
        
        [BindProperty]
        public Role Role { get; set; }
        
        public void OnGet(int id)
        {
            Role = _permissionService.GetRoleById(id);
        }
        
        public IActionResult OnPost()
        {
            _permissionService.DeleteRole(Role);

            return RedirectToPage("Index");
        }
    }
}