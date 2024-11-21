using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzAdminPanelForWork.Controllers
{
    public class SingleWorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
