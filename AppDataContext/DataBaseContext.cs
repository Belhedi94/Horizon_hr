﻿using Horizon_HR.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Horizon_HR.AppDataContext
{
    public class DataBaseContext : DbContext
    {
        // DbSettings field to store the connection string
        private readonly DbSettings _dbSettings;

        // Constructor to inject the DbSettings model
        public DataBaseContext(IOptions<DbSettings> dbSettings)
        {
            _dbSettings = dbSettings.Value;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbSettings.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("users")
                .HasKey(x => x.Id);
        }

    }
}
