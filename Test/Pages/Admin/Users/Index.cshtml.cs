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
    public class IndexModel : PageModel
    {
        private IUserServices _userServices;

        public IndexModel(IUserServices userServices)
        {
            _userServices = userServices;
        }
        public UserForAdminViewModel UserForAdminViewModel { get; set; }
        
        public void OnGet(int pageId = 1, string filterEmail = "", string filterUserName = "")
        {
            UserForAdminViewModel = _userServices.GetUser(pageId, filterEmail, filterUserName);
        }
    }
}