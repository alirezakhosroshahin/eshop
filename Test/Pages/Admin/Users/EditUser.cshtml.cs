using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test.Core.DTOs;
using Test.Core.Services.Interface;

namespace Test.Pages.Admin.Users
{
    public class EditUserModel : PageModel
    {
        private IUserServices _userServices;
        private IPermissionService _permissionService;
        public EditUserModel(IUserServices userServices, IPermissionService permissionService)
        {
            _userServices = userServices;
            _permissionService = permissionService;
        }

        [BindProperty]
        public EditUserViewModel EditUserViewModel { get; set; }
        
        public void OnGet(int id)
        {
            EditUserViewModel = _userServices.GetUserForShowInEditMode(id);
            ViewData["Roles"] = _permissionService.GetRole();
        }

        public IActionResult OnPost(List<int> SelectedRoles)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _userServices.EditUserFromAdmin(EditUserViewModel);
            _permissionService.EditRolesUser(EditUserViewModel.UserId,SelectedRoles);
            return RedirectToPage("Index");
        }
    }
}