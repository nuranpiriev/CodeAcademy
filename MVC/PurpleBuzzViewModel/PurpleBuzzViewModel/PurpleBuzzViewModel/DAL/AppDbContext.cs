using Microsoft.EntityFrameworkCore;
using PurpleBuzzViewModel.Models;

namespace PurpleBuzzViewModel.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {
            
        }
       public DbSet<OurTeam> OurTeams { get; set; }
       public DbSet<ContactUs> ContactUsMessages { get; set; }

    }
}
