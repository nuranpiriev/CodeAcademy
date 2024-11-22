using Microsoft.EntityFrameworkCore;
using PurpleBuzzViewModel.DAL;
namespace PurpleBuzzViewModel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddMvc();
            builder.Services.AddDbContext<AppDbContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("default")));
            var app = builder.Build();
            app.UseStaticFiles();

            app.MapControllerRoute(
                name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapControllerRoute(
    name: "about",
    pattern: "About",
    defaults: new { controller = "Home", action = "About" });
            app.MapControllerRoute(
    name: "work",
    pattern: "work",
    defaults: new { controller = "Home", action = "Work" });
            app.MapControllerRoute(
   name: "contact",
   pattern: "contact",
   defaults: new { controller = "Home", action = "Contact" });
            app.MapControllerRoute(
   name: "pricing",
   pattern: "pricing",
   defaults: new { controller = "Home", action = "Pricing" });


            app.Run();
        }
    }
}
