using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Test.Core.Services.Interface;

namespace Test.Areas.UserPanel.Controllers
{
    [Area("UserPanel")]
    [Authorize]
    public class WalletController : Microsoft.AspNetCore.Mvc.Controller
    {
        private IUserServices _userServices;
        public WalletController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [Route("UserPanel/Wallet")]
        public IActionResult Index()
        {
            ViewBag.ListWallet = _userServices.GetWalletUser(User.Identity.Name);
            return View();
        }
    }
}