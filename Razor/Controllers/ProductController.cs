using Microsoft.AspNetCore.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            List<Product> products = new List<Product>
            {
                new Product {Id = 1, Name ="Laptop", Price =50000 , Quantity= 5},
                new Product {Id = 2, Name ="Phone", Price =5000 ,Quantity= 5},
                new Product {Id = 3, Name ="Watch", Price =5000 ,Quantity= 6}
            };
            return View(products);
        }
    }
}
