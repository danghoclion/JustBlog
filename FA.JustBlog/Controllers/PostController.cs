using FA.JustBlog.Core.Data;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories.Repository;
using FA.JustBlog.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Web.Mvc;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using PartialViewResult = Microsoft.AspNetCore.Mvc.PartialViewResult;

namespace FA.JustBlog.Controllers
{
    public class PostController : Controller
    {
        PostRepository post = new PostRepository();
        CategoryRepository category = new CategoryRepository();
        TagResponsitory tag = new TagResponsitory();
        PostTagMapResponsitory postTag = new PostTagMapResponsitory();
        CommentResponsitory cmt = new CommentResponsitory();
        public IActionResult Index()
        {
            var s = from t in tag.GetAll()
                    join pt in postTag.GetAll() on t.TagId equals pt.TagId
                    select new
                    {
                        PostId = pt.PostId,
                        TagName = t.TagName,
                    };
            var si = s.Distinct();
            List<GetTagModels> tagmodel = new List<GetTagModels>();
            foreach (var model in si)
            {
                GetTagModels temp = new GetTagModels();
                temp.PostId = model.PostId;
                temp.TagName= model.TagName;
                tagmodel.Add(temp);
            }
            ViewBag.tag = tagmodel;
            List<Category> categoryResuilt = category.GetAll().ToList();
            var jsonresult = JsonConvert.SerializeObject(categoryResuilt);
            HttpContext.Session.SetString("category", jsonresult);
            return View(post.GetAll().ToList());
        }

        public IActionResult Detail(int id)
        {
            ViewBag.CMT = cmt.GetCommentsForPost(id);
            return View(post.Find(id));
        }

        public IActionResult LastestPost()
        {
            return View(post.GetLatestPost(5));
        }

        public IActionResult PostByCategory(int id)
        {
            var cateName = category.Find(id);
            return View(post.GetPostByCategory(cateName.CategoryName));
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
