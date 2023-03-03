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
    public class PostTagMapResponsitory : GenericRepository<PostTagMap>, IPostTagMapResponsitory
    {
        public PostTagMapResponsitory()
        {
        }

        public PostTagMapResponsitory(JustBlogContext context) : base(context)
        {
        }
    }
}
