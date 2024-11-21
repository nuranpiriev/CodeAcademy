using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzAdminPanelForWork.Controllers
{
    public class WorkController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
