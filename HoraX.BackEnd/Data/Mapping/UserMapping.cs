using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HoraX.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HoraX.BackEnd.Data.Mapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Email)
                .IsRequired(true);

            builder.Property(x => x.Name)
                .IsRequired(true);
        }
    }
}