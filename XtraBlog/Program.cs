using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using XtraBlog.DAL;
using XtraBlog.Model;
using XtraBlog.Services;

namespace XtraBlog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("MyConnection"));
            }).AddIdentity<AppUser,IdentityRole>

            (options=>{
                options.User.RequireUniqueEmail = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequiredLength = 6;
                options.Password.RequireUppercase = false;
                options.Lockout.MaxFailedAccessAttempts= 5;
                options.Lockout.DefaultLockoutTimeSpan=TimeSpan.FromMinutes(1);
            }
                
                
            ).AddDefaultTokenProviders().AddEntityFrameworkStores<ApplicationContext>();
            builder.Services.AddScoped<LayoutService>();
            builder.Services.AddTransient<IEmailService,EmailService>();
            var app = builder.Build();

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

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute("about-us", "haqqimizda", new { controller = "Home",action="About"});
            app.MapControllerRoute("contact-us", "elage", new { controller = "Home", action = "Contact" });
            app.MapControllerRoute("post-single", "xeberler/{*slug}", new { controller = "Blog", action = "Detail" });

            app.MapControllerRoute(
           name: "manage",
           pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
         );
        


            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}