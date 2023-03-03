
using FA.JustBlog.Common;
using FA.JustBlog.Core.Data;
using FA.JustBlog.Core.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace FA.JustBlog.Core.DbInitializer
{
    public class DbInitializer
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly JustBlogContext _db;

        public DbInitializer(
            UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            JustBlogContext db)
        {
            _roleManager = roleManager;
            _userManager = userManager;
            _db = db;
        }


        public void Initialize()
        {
            //migrations if they are not applied
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception ex)
            {

            }

            //create roles if they are not created
            if (!_roleManager.RoleExistsAsync(SD.Role_Blog_Owner).GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Blog_Owner)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Role_User)).GetAwaiter().GetResult();
                _roleManager.CreateAsync(new IdentityRole(SD.Role_Contributor)).GetAwaiter().GetResult();

                //if roles are not created, then we will create admin user as well

                _userManager.CreateAsync(new BlogUsers
                {
                    UserName = "admin@gmail.com",
                    Email = "admin@gmail.com",
                    Name = "Admin_Blog_Owner",
                    PhoneNumber = "1112223333",
                    StreetAddress = "test 123 Ave",
                    City = "Chicago"
                }, "Admin123*").GetAwaiter().GetResult();

                BlogUsers admin = _db.BlogUsers.FirstOrDefault(u => u.Email == "admin@gmail.com");

                _userManager.AddToRoleAsync(admin, SD.Role_Blog_Owner).GetAwaiter().GetResult();

                _userManager.CreateAsync(new BlogUsers
                {
                    UserName = "user@gmail.com",
                    Email = "user@gmail.com",
                    Name = "User",
                    PhoneNumber = "1112223333",
                    StreetAddress = "test 123 Ave",
                    City = "Chicago"
                }, "Admin123*").GetAwaiter().GetResult();

                BlogUsers user = _db.BlogUsers.FirstOrDefault(u => u.Email == "user@gmail.com");

                _userManager.AddToRoleAsync(user, SD.Role_User).GetAwaiter().GetResult();

                _userManager.CreateAsync(new BlogUsers
                {
                    UserName = "contribu@gmail.com",
                    Email = "contribu@gmail.com",
                    Name = "contributor",
                    PhoneNumber = "1112223333",
                    StreetAddress = "test 123 Ave",
                    City = "Chicago"
                }, "Admin123*").GetAwaiter().GetResult();

                BlogUsers contribu = _db.BlogUsers.FirstOrDefault(u => u.Email == "contribu@gmail.com");

                _userManager.AddToRoleAsync(contribu, SD.Role_Contributor).GetAwaiter().GetResult();


            }
            return;
        }
    }
}
