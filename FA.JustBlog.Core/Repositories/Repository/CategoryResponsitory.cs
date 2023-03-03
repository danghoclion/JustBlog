using FA.JustBlog.Core.Data;
using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Repositories.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryResponsitory
    {
        public CategoryRepository() { }
        public CategoryRepository(JustBlogContext context) : base(context)
        {
        }
    }
}
