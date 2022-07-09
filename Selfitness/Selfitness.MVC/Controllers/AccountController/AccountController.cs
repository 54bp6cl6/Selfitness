using Microsoft.AspNetCore.Mvc;
using Selfitness.MVC.Services;

namespace Selfitness.MVC.Controllers
{
    public partial class AccountController : BaseController
    {
        protected readonly MvcAccountService _accountService;
        private ILogger<AccountController> _logger;

        public AccountController(BaseControllerArgument baseArgument,
            MvcAccountService accountService,
            ILogger<AccountController> logger) : base(baseArgument)
        {
            _accountService = accountService;
            _logger = logger;
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login", "Account");
        }
    }
}
