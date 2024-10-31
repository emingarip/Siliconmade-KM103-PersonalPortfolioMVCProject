using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations;

public class AboutUserConfiguration : IEntityTypeConfiguration<AboutUser>
{
    public void Configure(EntityTypeBuilder<AboutUser> builder)
    {
        builder.ToTable("AboutUser").HasKey(b => b.Id);
        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");


        builder.Property(b => b.AddressFirstLine).HasColumnName("AddressFirstLine").IsRequired();
        builder.Property(b => b.ZipCode).HasColumnName("ZipCode").IsRequired();
        builder.Property(b => b.Introduction).HasColumnName("Introduction").IsRequired();
        builder.Property(b => b.DateOfBirth).HasColumnName("DateOfBirth").IsRequired();
        builder.Property(b => b.ImageUrl1).HasColumnName("ImageUrl1").IsRequired();
        builder.Property(b => b.ImageUrl2).HasColumnName("ImageUrl2").IsRequired(false);

        builder.Property(b => b.UserId).HasColumnName("UserId").IsRequired();


       


        builder.HasOne(b => b.User);

        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);


    }
}
