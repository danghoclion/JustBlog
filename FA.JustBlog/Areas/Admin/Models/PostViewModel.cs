using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories.Repository;
using System.Web.Mvc;

namespace FA.JustBlog.Areas.Admin.Models
{
    public class ViewTag
    {
        public ViewTag() { }
        public int TagID { get; set; }
        public string TagName { get; set; }

        public bool IsSelected { get; set; } 
    }
    public class PostViewModel
    {
        CategoryRepository categoryRepository = new CategoryRepository();
        TagResponsitory tag = new TagResponsitory();    
        public Post post { get; set; }
        public IEnumerable<Category> CategoryName { get; set; }
        public List<ViewTag> TagName { get; set; }
        public PostViewModel()
        {
            this.CategoryName = categoryRepository.GetAll();
            TagName= new List<ViewTag>();
            foreach (var item in tag.GetAll())
            {
                ViewTag temp = new ViewTag();
                temp.TagID = item.TagId;
                temp.TagName = item.TagName;
                temp.IsSelected = false;
                this.TagName.Add(temp);
            }
        }
    }
}
