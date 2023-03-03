﻿using FA.JustBlog.Core.Infrastructures;
using FA.JustBlog.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Repositories.IRepository
{
    public interface ICommentResponsitory : IGenericRepository<Comment>
    {
        void Add(int postId, string commentName, string commentEmail, string commentTitle, string commentBody);

        IList<Comment> GetCommentsForPost(int postId);
        IList<Comment> GetCommentsForPost(Post post);
    }
}