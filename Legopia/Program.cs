using Legopia.Extensions;
using Legopia.Data.Seeding;
using Legopia.Models.Identity;
using Microsoft.AspNetCore.Identity;

namespace Legopia
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddSqlServer(builder.Configuration);
            builder.Services.AddApplicationServices();
            builder.Services.AddIdentity();

            builder.Services.AddDataProtection();

            var app = builder.Build();

            // Seed admin user and role
            using (var scope = app.Services.CreateScope())
            {
                var services = scope.ServiceProvider;
                var userManager = services.GetRequiredService<UserManager<UserDetails>>();
                var roleManager = services.GetRequiredService<RoleManager<UserRole>>();
                await DatabaseSeeder.SeedAdminAsync(userManager, roleManager);
            }

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "areas",
                pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
