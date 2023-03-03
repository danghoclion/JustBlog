using FA.JustBlog.Areas.Admin.Models;
using FA.JustBlog.Common;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCategory : Controller
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        [Route("AdminCategory")]
        public IActionResult Index()
        {
            return View(categoryRepository.GetAll().ToList());
        }
        [Route("AdminCategory/Create")]
        [Authorize(Roles = SD.Role_Contributor + "," + SD.Role_Blog_Owner)]
        public IActionResult Create()
        {
            return View();
        }

        [Route("AdminCategory/Create")]
        [HttpPost]
        [Authorize(Roles = SD.Role_Contributor + "," + SD.Role_Blog_Owner)]
        public IActionResult Create(Category category)
        {
            categoryRepository.Add(category);
            return RedirectToAction("AdminCategory", "Admin");
        }

        [Route("AdminCategory/Details")]
        public IActionResult Details(int id)
        {
            return View(categoryRepository.Find(id));
        }

        [Route("AdminCategory/Edit")]
        [Authorize(Roles = SD.Role_Contributor + "," + SD.Role_Blog_Owner)]
        public IActionResult Edit(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        [Route("AdminCategory/Edit")]
        [Authorize(Roles = SD.Role_Contributor + "," + SD.Role_Blog_Owner)]
        [HttpPost]
        public IActionResult Edit(Category category)
        {
            categoryRepository.Update(category);
            return RedirectToAction("Index", "AdminCategory");
        }

        [Route("AdminCategory/Delete")]
        [Authorize(Roles =SD.Role_Blog_Owner)]
        public IActionResult Delete(int id)
        {
            categoryRepository.Delete(id);
            return RedirectToAction("Index", "AdminCategory");
        }
    }
}
