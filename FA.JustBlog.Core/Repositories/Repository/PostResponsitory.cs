using FA.JustBlog.Core.Data;
using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.Models;
using FA.JustBlog.Core.Repositories.IRepository;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Repositories.Repository
{
    public class PostRepository : GenericRepository<Post>, IPostResponsitory
    {
        public PostRepository() { }
        public PostRepository(JustBlogContext context) : base(context)
        {
        }

        public int CountPostsForCategory(string category)
        {
            var temp = context.Categories.FirstOrDefault(x => x.CategoryName == category);
            int count = context.Posts.Where(x => x.CategoryId == temp.CategoryId).Count();
            return count;
        }

        public int CountPostsForTag(string tag)
        {
            var temp = context.Tags.FirstOrDefault(x => x.TagName== tag);
            var data = context.Tags.Join(context.PostTagsMap,
                                            tag => tag.TagId,
                                            posttag => posttag.TagId,
                                            (tag, posttag) => new
                                            {
                                                TagId = tag.TagId,
                                                PostId = posttag.PostId,
                                            });
            return data.Where(x => x.TagId == temp.TagId).Count();
        }

        public Post FindPost(int year, int month, string urlSlug)
        {
            return context.Posts.FirstOrDefault(x => x.PostedOn.Year == year && x.PostedOn.Month == month && x.UrlSlug == urlSlug);
        }

        public IList<Post> GetHighestPosts(int size)
        {
            return context.Posts.OrderByDescending(m => m.Rate).Take(size).ToList();
        }

        public IList<Post> GetLatestPost(int size)
        {
            return context.Posts.OrderByDescending(m => m.PostedOn).Take(size).ToList();
        }

        public IList<Post> GetMostViewedPost(int size)
        {
            return context.Posts.OrderByDescending(m => m.ViewCount).Take(size).ToList();
        }

        public IList<Post> GetPostByCategory(string category)
        {
            var temp = context.Categories.FirstOrDefault(x => x.CategoryName == category);
            return context.Posts.Where(x => x.CategoryId == temp.CategoryId).ToList();
        }

        public IList<Post> GetPostByMonth(DateTime monthYear)
        {
            return (IList<Post>)context.Posts.Where(x => x.PostedOn.Month == monthYear.Month).ToList();
        }

        public IList<Post> GetPostByTag(string tag)
        {
            var temp = context.Tags.FirstOrDefault(x => x.TagName == tag);
            var a = from post in context.Posts
                        join pt in context.PostTagsMap on post.PostId equals pt.PostId
                        where pt.TagId == temp.TagId
                        select new
                        {
                            PostId = post.PostId,
                            Title = post.Title,
                            ShortDescription = post.ShortDescription,
                            PostContent = post.PostContent,
                            UrlSlug = post.UrlSlug,
                            Published = post.Published,
                            PostedOn = post.PostedOn,
                            Modified = post.Modified,
                            CategoryId = post.CategoryId,
                        };
            List<Post> listPost = new List<Post>();
            foreach (var item in a)
            {
                Post p = new Post();
                p.PostId = item.PostId;
                p.Title= item.Title;
                p.ShortDescription= item.ShortDescription;
                p.PostContent = item.PostContent;
                p.UrlSlug= item.UrlSlug;
                p.Published= item.Published;
                p.PostedOn= item.PostedOn;
                p.Modified= item.Modified;
                p.CategoryId= item.CategoryId;
                listPost.Add(p);
            }
            return listPost;
        }

        public IList<Post> GetPublisedPosts()
        {
            return (IList<Post>)context.Posts.Where(x => x.Published == "1").ToList();
        }

        public IList<Post> GetUnpublisedPosts()
        {
            return (IList<Post>)context.Posts.Where(x => x.Published == "0").ToList();
        }
    }
}
