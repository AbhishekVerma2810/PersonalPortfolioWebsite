using Microsoft.EntityFrameworkCore;
using PersonalPortfolioWebsite.Layer_Business;
using PersonalPortfolioWebsite.Layer_Business.Interfaces;
using PersonalPortfolioWebsite.Layer_Data;
using PersonalPortfolioWebsite.Layer_Data.Repositories;
using PersonalPortfolioWebsite.Layer_Data.Repositories.Interfaces;

namespace PersonalPortfolioWebsite
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            builder.Services.AddDbContext<PortfolioDbContext>(option => option.UseSqlite("Data Source=portfolio.db"));
            builder.Services.AddScoped<IProjectRepository, ProjectRepository>();
            builder.Services.AddScoped<IProjectService, ProjectService>();

            builder.Services.AddScoped<IExperienceRepository, ExperienceRepository>();
            builder.Services.AddScoped<IExperienceService, ExperienceService>();

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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
