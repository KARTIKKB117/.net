using System.Diagnostics;
using InterServ.Models;
using Microsoft.AspNetCore.Mvc;
using InterServ.service;

namespace InterServ.Controllers
{
    public class HomeController : Controller
    {
        private readonly IService _serv;

        public HomeController(IService serv)
        {
            _serv = serv;
        }

        public IActionResult Index()
        {
            var message = _serv.DisplayMsg("abc");
            ViewBag.Message = message;
            return View ();
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
