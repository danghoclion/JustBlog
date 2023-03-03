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
    public class CommentResponsitory : GenericRepository<Comment>, ICommentResponsitory
    {
        public CommentResponsitory()
        {
        }

        public CommentResponsitory(JustBlogContext context) : base(context)
        {
        }

        public void Add(int postId, string commentName, string commentEmail, string commentTitle, string commentBody)
        {
            Comment temp = new Comment();
            temp.PostId = postId;
            temp.Name= commentName;
            temp.Email= commentEmail;
            temp.ConmmentHeader= commentTitle;
            temp.CommentText= commentBody;
            context.Comments.Add(temp);
        }

        public IList<Comment> GetCommentsForPost(int postId)
        {
            return context.Comments.Where(x=> x.PostId == postId).ToList();
        }

        public IList<Comment> GetCommentsForPost(Post post)
        {
            return context.Comments.Where(x => x.PostId == post.PostId).ToList();
        }
    }
}
