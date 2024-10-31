using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations;

internal class UserExperiencesConfiguration : IEntityTypeConfiguration<UserExperiences>
{
    public void Configure(EntityTypeBuilder<UserExperiences> builder)
    {
        builder.ToTable("UserExperiences").HasKey(b => b.Id);
        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

        builder.Property(b => b.Title).HasColumnName("Title").IsRequired();
        builder.Property(b => b.Org).HasColumnName("Org").IsRequired();
        builder.Property(b => b.StartDate).HasColumnName("StartDate").IsRequired();
        builder.Property(b => b.EndDate).HasColumnName("EndDate").IsRequired(false);
        builder.Property(b => b.Description).HasColumnName("Description").IsRequired();
        builder.Property(b => b.UserId).HasColumnName("UserId").IsRequired();

        builder.HasOne(b => b.User);

        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

    }
}
