using eTickets.Functions;
using eTickets.Models;
using eTickets.Settings;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace eTickets.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppSettings _appSettings;

        public HomeController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public IActionResult Index()
        {
            ViewData["title"] = "My Home Page";
            int score = Validations.sum(2, 5);
            var model = new Actor { 
                Bio = _appSettings.email,
                Id = score,
            };
            return View(model);
        }

        public IActionResult Privacy()
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