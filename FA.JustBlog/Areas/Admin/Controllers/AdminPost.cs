using FA.JustBlog.Areas.Admin.Models;
using FA.JustBlog.Common;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FA.JustBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminPost : Controller
    {
        PostRepository postRepository = new PostRepository();
        PostTagMapResponsitory pTag = new PostTagMapResponsitory();
        [Route("AdminPost")]
        public IActionResult Index()
        {
            return View(postRepository.GetAll().ToList());
        }

        [Route("AdminPost/Create")]
        [Authorize(Roles = SD.Role_Contributor + "," + SD.Role_Blog_Owner)]
        public IActionResult Create()
        {
            PostViewModel model = new PostViewModel();
            return View(model);
        }

        [Route("AdminPost/Create")]
        [HttpPost]
        [Authorize(Roles = SD.Role_Contributor + "," + SD.Role_Blog_Owner)]
        public IActionResult Create(PostViewModel pv)
        {
            pv.post.PostedOn = DateTime.Now;
            pv.post.Published = "0";
            pv.post.Modified = DateTime.Now;
            pv.post.UrlSlug = "No";
            postRepository.Add(pv.post);
            foreach (var item in pv.TagName)
            {
                if(item.IsSelected)
                {
                    PostTagMap temp = new PostTagMap();
                    temp.PostId = pv.post.PostId;
                    temp.TagId = item.TagID;
                    pTag.Add(temp);
                }    
            }
            return RedirectToAction("Index", "AdminPost");
        }

        [Route("AdminPost/Details")]
        public IActionResult Details(int id)
        {
            return View(postRepository.Find(id));
        }

        [Route("AdminPost/Edit")]
        [Authorize(Roles = SD.Role_Contributor + "," + SD.Role_Blog_Owner)]
        public IActionResult Edit(int id)
        {
            ViewBag.Id = id;
            PostViewModel model = new PostViewModel();
            return View(model);
        }

        [Route("AdminPost/Edit")]
        [HttpPost]
        [Authorize(Roles = SD.Role_Contributor + "," + SD.Role_Blog_Owner)]
        public IActionResult Edit(Post post)
        {
            var temp = postRepository.Find(post.PostId);
            post.Modified = DateTime.Now;
            post.UrlSlug = "Url";
            post.Published = "0";
            post.RateCount = temp.RateCount;
            post.TotalRate = temp.TotalRate;
            postRepository.Update(post);
            return RedirectToAction("Index", "AdminPost");
        }

        [Route("AdminPost/Delete")]
        [Authorize(Roles =SD.Role_Blog_Owner)]
        public IActionResult Delete(int id)
        {
            postRepository.Delete(id);
            return RedirectToAction("Index", "AdminPost");
        }
    }
}
