using Microsoft.AspNetCore.Mvc;
using Selfitness.MVC.Models;
using System.Diagnostics;

namespace Selfitness.MVC.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(BaseControllerArgument baseArgument,
            ILogger<HomeController> logger) : base(baseArgument)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}