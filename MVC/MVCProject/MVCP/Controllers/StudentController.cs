using AB205.Models;
using Microsoft.AspNetCore.Mvc;

namespace AB205.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
          Student student1 = new Student()
          {
              Id = 1,
              Name = "Nuran",
              Email = "pirnur76@gmail.com"
              
          };
            Student student2 = new Student()
            {
                Id = 2,
                Name = "Fizi",
                Email = "Fizarat@gmail.com"

            };
            List<Student> students = new List<Student>() { student1, student2 };

            return View(students);
        }
    }
}
