using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoraX.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HoraX.BackEnd.Data.Mapping
{
    public class UserSkillMapping : IEntityTypeConfiguration<UserSkill>
    {
        public void Configure(EntityTypeBuilder<UserSkill> builder)
        {
            builder.ToTable("UserSkill");

            builder.HasKey(x => x.Id);

            builder.HasOne(u => u.User)
                .WithMany(t => t.UserSkills)
                .HasForeignKey(u => u.UserId);

            builder.HasOne(u => u.Skill)
                .WithMany(t => t.UserSkills)
                .HasForeignKey(u => u.SkillId);

            builder.Property(x => x.Proficiency)
                .IsRequired(true);
        }
    }
}