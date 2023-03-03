using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace FA.JustBlog.Core.Models
{
    [Index(nameof(Title), IsUnique = true)]
    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string PostContent { get; set; }
        public string UrlSlug { get; set; }
        public string Published { get; set; }   
        public DateTime PostedOn { get; set; }
        public DateTime Modified { get; set; }
        public int? CategoryId { get; set; }
        public int ViewCount { get; set; }
        public int RateCount { get; set; }
        public int TotalRate { get; set; }
        private decimal rate ; // field

        public decimal Rate   // property
        {
            get { return rate; }   // get method
            set { rate = value; }  // set method
        }
        public virtual Category? Category { get; set; }
        
        public virtual ICollection<PostTagMap>? PostTagMaps { get; set; }
        public virtual ICollection<Comment>? Comments { get; set; }
    }
}
