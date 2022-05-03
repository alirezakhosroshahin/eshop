using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Test.Core.DTOs;
using Test.Core.Security;
using Test.Core.Services.Interface;

namespace Test.Pages.Admin.Users
{
    [PermissionChecker(9)]
    public class ListDeleteUsersModel : PageModel
    {private IUserServices _userServices;

        public ListDeleteUsersModel(IUserServices userService)
        {
            _userServices = userService;
        }

        public UserForAdminViewModel UserForAdminViewModel { get; set; }
        
        public void OnGet(int pageId = 1, string filterUserName = "", string filterEmail = "")
        {
            UserForAdminViewModel = _userServices.GetDeleteUsers(pageId, filterEmail, filterUserName);
        }
    }
}