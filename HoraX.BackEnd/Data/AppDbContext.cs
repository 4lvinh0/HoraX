using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using HoraX.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace HoraX.BackEnd.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Skill> Skills { get; set; } = null!;

        public DbSet<Transaction> Transactions { get; set; } = null!;

        public DbSet<User> Users { get; set; } = null!;

        public DbSet<UserSkill> UserSkills { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
            => modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }
}