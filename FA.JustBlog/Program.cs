using FA.JustBlog.Core.Repositories.IRepository;
using FA.JustBlog.Core.Repositories.Repository;
using NuGet.Protocol.Core.Types;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using FA.JustBlog.Core.Data;
using Microsoft.AspNetCore.Authorization;
using FA.JustBlog.Core.DbInitializer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace FA.JustBlog
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("JustBlogContextConnection") ?? throw new InvalidOperationException("Connection string 'JustBlogContextConnection' not found.");

            builder.Services.AddDbContext<JustBlogContext>(options =>
options.UseSqlServer(connectionString));

            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<JustBlogContext>();
            //builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddDefaultTokenProviders()
            //.AddDefaultUI()
            //        .AddEntityFrameworkStores<JustBlogContext>();
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSession();

            //builder.Services.AddScoped<IDbInitializer, DbInitializer>();
            builder.Services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = $"/Identity/Account/Login";
                options.LogoutPath = $"/Identity/Account/Logout";
                options.AccessDeniedPath = $"/Identity/Account/AccessDenied";
                //options.ExpireTimeSpan=
            });

            builder.Services.AddMvc();
            builder.Services.AddScoped<IPostResponsitory, PostRepository>();
            //builder.Services.AddAuthorization(options =>
            //{
            //    options.FallbackPolicy = new AuthorizationPolicyBuilder()
            //        .RequireAuthenticatedUser()
            //        .Build();
            //});

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
            app.UseSession();
            app.MapRazorPages();
            app.UseRouting();
                        app.UseAuthentication();;

            app.UseAuthorization();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Post}/{action=Index}/{id?}");

            app.MapAreaControllerRoute(
            name: "Admin",
            areaName: "Admin",
            pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

           

            app.Run();
        }
    }
}