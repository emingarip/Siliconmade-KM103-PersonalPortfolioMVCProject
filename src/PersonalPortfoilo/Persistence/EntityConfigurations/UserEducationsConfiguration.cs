using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations;

internal class UserEducationsConfiguration : IEntityTypeConfiguration<UserEducations>
{
    public void Configure(EntityTypeBuilder<UserEducations> builder)
    {
        builder.ToTable("UserEducations").HasKey(b => b.Id);
        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

        builder.Property(b => b.School).HasColumnName("School").IsRequired();
        builder.Property(b => b.StartDate).HasColumnName("StartDate").IsRequired();
        builder.Property(b => b.EndDate).HasColumnName("EndDate").IsRequired();
        builder.Property(b => b.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(b => b.Educations).HasColumnName("Educations").IsRequired();
        builder.HasOne(b => b.User);



        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);

    }
}
