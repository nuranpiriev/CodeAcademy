using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PurpleBuzzAdminPanelForWork.DAL;
using PurpleBuzzAdminPanelForWork.Models;
using PurpleBuzzAdminPanelForWork.ViewModels;

namespace PurpleBuzzAdminPanelForWork.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WorkController : Controller
    {
        readonly AppDbContext _context;
        public WorkController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
           IEnumerable<Work> works=await _context.Works.ToListAsync();
            return View(works);
        }
        [HttpPost]
        public IActionResult Delete(int Id)
        {
           Work? deletedWork = _context.Works.Find(Id);
            if (deletedWork == null)
            {
                return NotFound();
            }
            else
            {
                _context.Works.Remove(deletedWork);
                _context.SaveChanges(); 
            }
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create()
        {


            return View();
        }
        [HttpPost]
        public IActionResult Create(Work work)
        {if (!ModelState.IsValid) {
                return BadRequest("error");
                    }
            else
            {
_context.Works.Add(work);
            _context.SaveChanges();
            }
            
            return RedirectToAction(nameof(Index));
        }
    }
}
