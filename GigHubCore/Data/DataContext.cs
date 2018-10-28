using System;
using Microsoft.EntityFrameworkCore;
using GigHubCore.Models;

namespace GigHubCore.Data
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("DataSource = GigHub.db");
        }

        public DbSet<Gig> Gig { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ApplicationUser> Artist { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ApplicationUser>()
                        .HasKey(x => x.Id);
            modelBuilder.Entity<Genre>()
                        .HasKey(x => x.Id);
        }
    }
}
