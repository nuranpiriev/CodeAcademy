using AB205.Models;
using Microsoft.AspNetCore.Mvc;

namespace AB205.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }

    }

}
