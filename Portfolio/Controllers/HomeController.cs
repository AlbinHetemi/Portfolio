using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Repositories;
using System.Diagnostics;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProfile profile;

        public HomeController(ILogger<HomeController> logger, IProfile profile)
        {
            _logger = logger;
            this.profile = profile;
        }

        public IActionResult Index()
        {
            return View(profile.getProfile());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult About() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        public ActionResult LinkedinAction()
        {
            return RedirectToPage("https://www.linkedin.com/in/albin-hetemi-b01988191/");
        }
    }
}