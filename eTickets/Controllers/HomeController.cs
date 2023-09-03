using eTickets.Functions;
using eTickets.Models;
using eTickets.Settings;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Diagnostics;

namespace eTickets.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppSettings _appSettings;
        private readonly IWebHostEnvironment _hostingEnvironment;

        public HomeController(IOptions<AppSettings> appSettings, IWebHostEnvironment hostingEnvironment)
        {
            _appSettings = appSettings.Value;
            _hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            ViewData["title"] = "My Home Page";
            int score = Validations.sum(2, 5);
            List<Actor> actors = new List<Actor>
            {
                new Actor
                {
                    Id = 1,
                    Name = "Test",
                    ProfilePictureURL = "shjsjs"
                }
            };

            //file processing function call
            string root_directory = _hostingEnvironment.ContentRootPath;
            string sub_directory = Path.Combine(root_directory, "Errors");
            string file_path = Path.Combine(root_directory, "Errors", "message.txt");
            bool check = FileProcessing.log_Error_Message("\nThe name of my school is Ofori Hills Academy");
            
                return View(actors);
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