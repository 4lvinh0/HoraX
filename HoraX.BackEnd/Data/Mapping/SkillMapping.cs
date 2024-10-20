using HoraX.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HoraX.BackEnd.Data.Mapping
{
    public class SkillMapping : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.ToTable("Skill");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Title)
                .IsRequired(true)
                .HasMaxLength(80);

            builder.Property(x => x.Description)
                .IsRequired(true)
                .HasMaxLength(512);
        }
    }
}