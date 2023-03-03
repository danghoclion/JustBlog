using FA.JustBlog.Areas.Admin.Models;
using FA.JustBlog.Common;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminTag : Controller
    {
        TagResponsitory tagResponsitory = new TagResponsitory();
        [Route("AdminTag")]
        public IActionResult Index()
        {
            return View(tagResponsitory.GetAll().ToList());
        }

        [Route("AdminTag/Create")]
        [Authorize(Roles = SD.Role_Contributor+","+SD.Role_Blog_Owner)]
        public IActionResult Create()
        {
            return View();
        }

        [Route("AdminTag/Create")]
        [HttpPost]
        [Authorize(Roles = SD.Role_Contributor + "," + SD.Role_Blog_Owner)]
        public IActionResult Create(Tag tag)
        {
            tagResponsitory.Add(tag);
            return RedirectToAction("AdminTag", "Admin");
        }

        [Route("AdminTag/Details")]
        public IActionResult Details(int id)
        {
            return View(tagResponsitory.Find(id));
        }

        [Route("AdminTag/Edit")]
        [Authorize(Roles = SD.Role_Contributor + "," + SD.Role_Blog_Owner)]
        public IActionResult Edit(int id)
        {
            ViewBag.Id = id;
            return View();
        }

        [Route("AdminTag/Edit")]
        [HttpPost]
        [Authorize(Roles = SD.Role_Contributor + "," + SD.Role_Blog_Owner)]
        public IActionResult Edit(Tag tag)
        {
            tagResponsitory.Update(tag);
            return RedirectToAction("Index", "AdminTag");
        }

        [Route("AdminTag/Delete")]
        [Authorize(Roles =SD.Role_Blog_Owner)]
        public IActionResult Delete(int id)
        {
            tagResponsitory.Delete(id);
            return RedirectToAction("Index", "AdminTag");
        }
    }
}
