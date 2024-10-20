using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoraX.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HoraX.BackEnd.Data.Mapping
{
    public class TransactionMapping : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.ToTable("Transaction");

            builder.HasKey(x => x.Id);

            builder.HasOne(t => t.FromUser)
                .WithMany(u => u.TransactionsFrom)
                .HasForeignKey(t => t.FromUserId)
                .IsRequired(true);

            builder.HasOne(t => t.SkillFrom)
                .WithMany(u => u.TransactionsFrom)
                .HasForeignKey(t => t.SkillFromId)
                .IsRequired(true);

            builder.Property(x => x.HoursFrom)
                .IsRequired(true);
            

            builder.HasOne(t => t.ForUser)
                .WithMany(u => u.TransactionsFor)
                .HasForeignKey(t => t.ForUserId)
                .IsRequired(true);
                
            builder.HasOne(t => t.SkillFor)
                .WithMany(u => u.TransactionsFor)
                .HasForeignKey(t => t.SkillForId)
                .IsRequired(true);

            builder.Property(x => x.HoursFor)
                .IsRequired(true);

            builder.Property(x => x.Text)
                .HasMaxLength(512);

        }
    }
}