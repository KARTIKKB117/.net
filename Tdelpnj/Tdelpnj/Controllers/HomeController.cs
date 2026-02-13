using System.Diagnostics;
using Deplnj.Models;
using Microsoft.AspNetCore.Mvc;
using Deplnj.Services;

namespace Deplnj.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMyService _service;

       

        public HomeController( IMyService service )
        {
            _service  = service;
        }

        public IActionResult Index()
        {
            string message = _service.GetMessage();
            return Content(message);
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
