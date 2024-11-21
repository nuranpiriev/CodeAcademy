using Microsoft.AspNetCore.Builder;

namespace AB205
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
             
            
            builder.Services.AddMvc();
            var app = builder.Build();
           
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}"
               );

         

            app.MapControllerRoute(name: "default1",
                pattern: "{controller=Student}/{action=Index1}");

            app.MapControllerRoute(name: "default2",
                pattern: "{controller=Teacher}/{action=Index2}");

            app.MapControllerRoute(name: "default3",
                pattern: "{controller=Group}/{action=Index3}");

            app.Run();
        }
    }
}
