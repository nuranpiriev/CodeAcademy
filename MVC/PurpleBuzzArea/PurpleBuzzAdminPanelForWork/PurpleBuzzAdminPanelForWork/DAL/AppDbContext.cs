using Microsoft.EntityFrameworkCore;
using PurpleBuzzAdminPanelForWork.Models;

namespace PurpleBuzzAdminPanelForWork.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options):base(options) 
        {
            
        }
        public DbSet<Work> Works { get; set; }
        public DbSet<Service> Services { get; set; }  

     }
}
