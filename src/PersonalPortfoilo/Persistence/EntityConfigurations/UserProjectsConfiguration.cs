using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations;

internal class UserProjectsConfiguration : IEntityTypeConfiguration<UserProjects>
{
    public void Configure(EntityTypeBuilder<UserProjects> builder)
    {
        builder.ToTable("UserProjects").HasKey(b => b.Id);
        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

        builder.Property(b => b.Title).HasColumnName("Title").IsRequired();
        builder.Property(b => b.Description).HasColumnName("Description").IsRequired();
        builder.Property(b => b.ImageUrl).HasColumnName("ImageUrl").IsRequired();
        builder.Property(b => b.UserId).HasColumnName("UserId").IsRequired();

        builder.HasOne(b => b.User);

        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

    }
}
