using Microsoft.AspNetCore.Mvc;

namespace RegistrationForm.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Models.Register user)
        {
            if ( ModelState.IsValid)
            {
                return Content($"Registration successful\n Name {user.Name}\n Email:{user.Email}\n Age{user.Age} \n Password {user.Password}");
                
            }
            return View(user);
        }
    }
}
