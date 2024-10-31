using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations;

public class ContactFoprmMessagesConfiguration : IEntityTypeConfiguration<ContactFormMessages>
{
    public void Configure(EntityTypeBuilder<ContactFormMessages> builder)
    {
        builder.ToTable("ContactFoprmMessages").HasKey(b => b.Id);
        builder.Property(b => b.Id).HasColumnName("Id").IsRequired();
        builder.Property(b => b.CreatedDate).HasColumnName("CreatedDate").IsRequired();
        builder.Property(b => b.UpdatedDate).HasColumnName("UpdatedDate");
        builder.Property(b => b.DeletedDate).HasColumnName("DeletedDate");

        builder.Property(b => b.SenderName).HasColumnName("SenderName").IsRequired();
        builder.Property(b => b.SenderEmail).HasColumnName("SenderEmail").IsRequired();
        builder.Property(b => b.SenderPhone).HasColumnName("SenderPhone").IsRequired();
        builder.Property(b => b.Subject).HasColumnName("Subject").IsRequired();
        builder.Property(b => b.Message).HasColumnName("Message").IsRequired();
        builder.Property(b => b.isRead).HasColumnName("isRead").IsRequired();
        builder.Property(b => b.Replay).HasColumnName("Replay").IsRequired(false);
        builder.Property(b => b.ReplayDate).HasColumnName("ReplayDate").IsRequired(false);
        builder.Property(b => b.ReplyedUserId).HasColumnName("ReplyedUserId").IsRequired(false);

        builder.HasOne(b => b.ReplyedUser);
        builder.HasQueryFilter(b => !b.DeletedDate.HasValue);


    }
}
