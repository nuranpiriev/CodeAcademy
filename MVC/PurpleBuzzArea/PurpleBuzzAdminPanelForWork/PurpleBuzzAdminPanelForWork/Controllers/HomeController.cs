using Microsoft.AspNetCore.Mvc;
using PurpleBuzzAdminPanelForWork.DAL;
using PurpleBuzzAdminPanelForWork.Models;
using PurpleBuzzAdminPanelForWork.ViewModels.Home;

namespace PurpleBuzzAdminPanelForWork.Contrtollers
{
    public class HomeController : Controller
    { AppDbContext _context;
        public HomeController(AppDbContext appDbContext)
        {
            _context = appDbContext;   
        }
        public IActionResult Index()
        {

            IEnumerable<Service> services= _context.Services.ToList(); 
            IEnumerable<Work> works= _context.Works.ToList();  
            HomeVM homeVM = new HomeVM()
            {
                Services = services,
                Works = works
            };
           
           _context.SaveChanges();
          

            return View(homeVM);
        }
    }
}
