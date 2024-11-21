using Microsoft.AspNetCore.Mvc;

namespace PurpleBuzzAdminPanelForWork.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
