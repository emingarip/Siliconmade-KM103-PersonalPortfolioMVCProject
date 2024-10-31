using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations;

public class BlogPostsConfiguration : IEntityTypeConfiguration<BlogPosts>
{
    public void Configure(EntityTypeBuilder<BlogPosts> builder)
    {
        builder.ToTable("BlogPosts").HasKey(b=>b.Id);
        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

        builder.Property(b => b.Title).HasColumnName("Title").IsRequired();
        builder.Property(b => b.Content).HasColumnName("Content").IsRequired();
        builder.Property(b => b.PublishDate).HasColumnName("PublishDate");
        builder.Property(b => b.UserId).HasColumnName("UserId").IsRequired();

        builder.HasOne(b => b.User);
        builder.HasMany(b => b.BlogComments);

        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);


    }
}
