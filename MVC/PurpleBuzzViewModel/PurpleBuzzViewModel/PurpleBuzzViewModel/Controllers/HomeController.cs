using Microsoft.AspNetCore.Mvc;
using PurpleBuzzViewModel.DAL;
using PurpleBuzzViewModel.Models;
using System.Reflection;
namespace PurpleBuzzViewModel.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        } 
        public IActionResult About()
        {
            //OurTeam ourteam1 = new OurTeam() { Title= "John Doe",Description = "Business Development", MainImageUrl = "team-01.jpg" };
            //OurTeam ourteam2 = new OurTeam() { Title = "Jane Doe", Description = "Media Development", MainImageUrl = "team-02.jpg" }; 
            //OurTeam ourteam3 = new OurTeam() {  Title = "Sam", Description = "Developer", MainImageUrl = "team-03.jpg" };
            //IEnumerable<OurTeam> ourteams = new List<OurTeam>() { ourteam1, ourteam2,ourteam3};
            IEnumerable<OurTeam> ourTeams = _context.OurTeams.ToList();

            //foreach (OurTeam team in ourteams)
            //{
            //    _context.Add(team);
            //}
           _context.SaveChanges();
            return View(ourTeams);
        }     
        public IActionResult Contact()
        {
           ContactUs contactUs1 = new ContactUs { Name = "Name" };
            ContactUs contactUs2 = new ContactUs { Name = "Email" };
            ContactUs contactUs3 = new ContactUs { Name = "Phone" };
            IEnumerable<ContactUs> contactUs = new List<ContactUs> { contactUs1, contactUs2,contactUs3 };
            //foreach (ContactUs contact in contactUs)
            //{
            //    _context.Add(contact);
            //}

            return View(contactUs);
        }
        public IActionResult Work()
        {
            return View();
        }
        public IActionResult Pricing()
        {
            return View();
        }
    }
}
