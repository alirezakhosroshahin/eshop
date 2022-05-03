using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test.Core.DTOs;
using Test.Core.Services.Interface;

namespace Test.Pages.Admin.Users
{
    public class CreateUserModel : PageModel
    {
        private IUserServices _userServices;
        private IPermissionService _permissionService;

        public CreateUserModel(IUserServices userServices, IPermissionService permissionService)
        {
            _userServices = userServices;
            _permissionService = permissionService;
        }


        [BindProperty] 
        public CreateUserViewModel CreateUserViewModel { get; set; }

        public void OnGet()
        {
            ViewData["Roles"] = _permissionService.GetRole();
        }

        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
                return Page();
            
            int userID = _userServices.AddUserFromAdmin(CreateUserViewModel);
            
            // Add Roles
            _permissionService.AddRolesToUser(SelectedRoles,userID);
            
            return  Redirect("/Admin/Users");
        }
    }
}