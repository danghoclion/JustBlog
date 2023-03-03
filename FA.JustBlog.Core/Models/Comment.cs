using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Models
{
    public class Comment
    {
        public int CmtID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string ConmmentHeader { get; set; }
        public string CommentText { get; set; }
        public DateTime CommentTime { get; set; }
        public int PostId { get; set; }
        public virtual Post? Post { get; set; }
    }
}
