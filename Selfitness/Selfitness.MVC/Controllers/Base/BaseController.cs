using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Selfitness.MVC.Services;

namespace Selfitness.MVC.Controllers
{
    public class BaseController : Controller
    {
        private readonly ILogger<BaseController> _logger;
        private readonly MvcAccountService _accountService;

        public BaseController(BaseControllerArgument argument)
        {
            _logger = argument.Logger;
            _accountService = argument.AccountService;
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var controllerName = ControllerContext.ActionDescriptor.ControllerName;
            var actionName = ControllerContext.ActionDescriptor.ActionName;
            if (!_accountService.IsLogedIn() &&
                (controllerName != "Account" || (actionName != "Login" && actionName != "Registe")))
            {
                context.Result = RedirectToAction("Login", "Account");
            }
            base.OnActionExecuting(context);
        }
    }

    public class BaseControllerArgument
    {
        public ILogger<BaseController> Logger { get; set; }
        public MvcAccountService AccountService { get; set; }

        public BaseControllerArgument(ILogger<BaseController> logger, MvcAccountService accountService)
        {
            Logger = logger;
            AccountService = accountService;
        }
    }
}
