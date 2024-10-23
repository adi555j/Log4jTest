using Log4jTest.Models;
using log4net;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Log4jTest.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private static readonly ILog log = LogManager.GetLogger(typeof(HomeController));

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            log.Info("Index page requested");
            log.Debug("Debugging Index page");
            log.Warn("Warning Index page");
            log.Error("Error Index page");
            return View();
        }

        public IActionResult Privacy()
        {
            log.Error("Error Index page");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
