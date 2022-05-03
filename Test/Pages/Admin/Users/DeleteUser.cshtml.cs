using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test.Core.DTOs;
using Test.Core.Security;
using Test.Core.Services.Interface;

namespace Test.Pages.Admin.Users
{
    [PermissionChecker(12)]
    public class DeleteUserModel : PageModel
    {
        private IUserServices _userServices;
        public DeleteUserModel(IUserServices userServices)
        {
            _userServices = userServices;
        }
        public InformationUserViewModel InformationUserViewModel { get; set; }
        
        public void OnGet(int id)
        {
            ViewData["UserId"] = id;
            InformationUserViewModel = _userServices.GetUserInformation(id);
        }
        
        public IActionResult OnPost(int UserId)
        {
            _userServices.DeleteUser(UserId);
            return RedirectToPage("Index");
        }
    }

    
}