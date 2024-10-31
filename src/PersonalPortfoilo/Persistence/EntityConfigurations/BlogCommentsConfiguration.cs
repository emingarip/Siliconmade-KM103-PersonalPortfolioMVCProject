using Core.Persistence.Repositories;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations;

public class BlogCommentsConfiguration : IEntityTypeConfiguration<BlogComments>
{
    public void Configure(EntityTypeBuilder<BlogComments> builder)
    {
        builder.ToTable("BlogComments").HasKey(b => b.Id);
        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

        builder.Property(b => b.BlogPostId).HasColumnName("BlogPostId").IsRequired();
        builder.Property(b => b.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(b => b.Content).HasColumnName("Content").IsRequired();
        builder.Property(b => b.PublishDate).HasColumnName("PublishDate");

        builder.HasOne(b => b.BlogPost);
        builder.HasOne(b => b.User);


        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);


    }
}
