using FA.JustBlog.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FA.JustBlog.Core.Configurations
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tags");
            builder.HasKey(x => x.TagId);
            builder.Property(x => x.TagName).IsRequired();
            builder.Property(x => x.TagId).ValueGeneratedOnAdd();
            builder.Property(x => x.UrlSlug).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Count).IsRequired();
        }
    }
}
