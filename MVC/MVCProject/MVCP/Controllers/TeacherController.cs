using AB205.Models;
using Microsoft.AspNetCore.Mvc;

namespace AB205.Controllers
{
    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            Teacher teacher1 = new Teacher() { 
                Id = 1,
            Name = "Narmin",
            Email="Narmin@gmail.com",
            Description= "B-ED"
            };
            Teacher teacher2 = new Teacher()
            {
                Id = 2,
                Name = "Vilayat",
                Email = "Vilayat@gmail.com",
                Description = "B-ED"
            };

            List<Teacher> teachers = new List<Teacher> { teacher1, teacher2 };
            
            return View(teachers);
        }
    }
}
