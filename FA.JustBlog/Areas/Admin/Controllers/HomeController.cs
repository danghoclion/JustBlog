using FA.JustBlog.Core.Repositories.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FA.JustBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        [Route("Admin/Home")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Admin/GetALl")]
        public IActionResult GetAll()
        {
            PostRepository categoryRepository = new PostRepository();
            return View(categoryRepository.GetAll().ToList());
        }
    }
}
