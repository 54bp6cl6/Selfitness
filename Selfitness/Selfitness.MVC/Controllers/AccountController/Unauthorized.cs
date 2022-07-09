using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Selfitness.MVC.Models.Account;

namespace Selfitness.MVC.Controllers
{
    public partial class AccountController
    {
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Login([FromBody] RegisteDTO model)
        {
            if (!ModelState.IsValid)
                return Json(new { success = false, message = "輸入錯誤" });

            try
            {
                if(!await _accountService.IsPasswordCurrect(model.Account, model.Password))
                {
                    return Json(new { success = false, message = "帳號或密碼錯誤" });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Registe Error");
                Json(new { success = false, message = "系統發生錯誤，請稍後再試" });
            }

            _accountService.Login(model.Account);
            return Json(new { success = true, message = "" });
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Registe()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> Registe([FromBody]RegisteDTO model)
        {
            if (!ModelState.IsValid)
                return Json(new { success = false, message = "輸入錯誤" });
            try
            {
                if (await _accountService.IsAccountExits(model.Account))
                    return Json(new { success = false, message = "此帳號已經存在" });
            
                await _accountService.CreateAccount(model.Account, model.Password);
            }
            catch(Exception ex)
            {
                _logger.LogError(ex, "Registe Error");
                Json(new { success = false, message = "系統發生錯誤，請稍後再試" });
            }

            return Json(new { success = true, message = "" });
        }
    }
}
