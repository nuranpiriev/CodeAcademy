using Microsoft.EntityFrameworkCore;
using PurpleBuzzAdminPanelForWork.DAL;

namespace PurpleBuzzAdminPanelForWork
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddMvc();   
            builder.Services.AddDbContext<AppDbContext>(options=>
            options.UseSqlServer(builder.Configuration.GetConnectionString("default")));
            var app = builder.Build();
            app.UseStaticFiles();
           app.MapControllerRoute(
                  name: "areas",
                  pattern: "{area:exists}/{controller=Dashboard}/{action=Index}"
                );
           
            app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            


            app.Run();
        }
    }
}
