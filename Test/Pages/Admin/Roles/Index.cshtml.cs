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
    [PermissionChecker(1004)]
    public class IndexModel : PageModel
    {
        private IPermissionService _permissionService;
        public IndexModel(IPermissionService permissionService)
        {
            _permissionService = permissionService;
        }

        public List<Role> RolesList { get; set; }
        public void OnGet()
        {
            RolesList = _permissionService.GetRole();
        }
    }
}