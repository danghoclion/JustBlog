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
    public class PostTagMapConfiguration : IEntityTypeConfiguration<PostTagMap>
    {
        public void Configure(EntityTypeBuilder<PostTagMap> builder)
        {
            builder.ToTable("PostTagMaps");
            builder.HasKey(x => new { x.PostId, x.TagId });
            builder.HasOne(x => x.Tag).WithMany(pc => pc.PostTagMaps).HasForeignKey(pc => pc.TagId);
            builder.HasOne(x => x.Post).WithMany(pc => pc.PostTagMaps).HasForeignKey(pc => pc.PostId);
        }
    }
}
