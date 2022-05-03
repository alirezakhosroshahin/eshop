using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Test.Core.DTOs;
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
        
        [HttpPost]
        [Route("UserPanel/Wallet")]
        public ActionResult Index(ChargeWalletViewModel charge)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.ListWallet = _userServices.GetWalletUser(User.Identity.Name);
                return View(charge);
            }  

            int walletId = _userServices.ChargeWallet(User.Identity.Name, charge.Amount, "شارژ حساب");

            #region Online Payment

            var payment = new ZarinpalSandbox.Payment(charge.Amount);

            var res = payment.PaymentRequest("شارژ کیف پول", "https://localhost:5001/OnlinePayment/" + walletId,
                "ali@gmail.Com", "091900000");

            if (res.Result.Status == 100)
            {
                return Redirect("https://sandbox.zarinpal.com/pg/StartPay/" + res.Result.Authority);
            }

            #endregion


            return null;
        }
    }
}