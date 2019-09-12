using System;
using Magelan.Domains;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Magelan.Repositories.DbContexts {
    public class MagelanDbContext : IdentityDbContext {
        public MagelanDbContext(DbContextOptions<MagelanDbContext> options) : base(options)
        {
        }

        
        public virtual DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public virtual DbSet<MagelanRole> MagelanRoles { get; set; }
        public virtual DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public virtual DbSet<MagelanUser> MagelanUsers { get; set; }
        
        
        public virtual DbSet<Posts> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=localhost;Database=magelan;User=magelan;Password=password;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var converter = new ValueConverter<Guid, string>(
                v => v.ToString(),
                v => Guid.Parse(v), 
                new ConverterMappingHints(valueGeneratorFactory: (p, t) => new GuidStringGenerator()));
            
            

            modelBuilder.Entity<Posts>(entity =>
            {
                entity.Property(e => e.Id).HasColumnType("char(36)");

                entity.Property(e => e.Archive).HasColumnType("bit(1)");

                entity.Property(e => e.Content).HasColumnType("longtext");

                entity.Property(e => e.Deleted).HasColumnType("bit(1)");

                entity.Property(e => e.Title).HasColumnType("longtext");
            });
            
            base.OnModelCreating(modelBuilder);
        }

    }
}