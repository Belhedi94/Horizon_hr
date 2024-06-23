using Horizon_HR.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Horizon_HR.AppDataContext
{
    public class DataBaseContext : DbContext
    {
        private readonly DbSettings _dbSettings;

        public DataBaseContext(IOptions<DbSettings> dbSettings)
        {
            _dbSettings = dbSettings.Value;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<EmploymentDetails> EmploymentDetails { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Position> Positions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbSettings.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("users")
                .HasKey(u => u.Id);

            modelBuilder.Entity<EmploymentDetails>()
                .ToTable("employment_details")
                .HasKey(e => e.Id);

            modelBuilder.Entity<Team>()
                .ToTable("teams")
                .HasKey(t => t.Id);

            modelBuilder.Entity<Department>()
               .ToTable("departments")
               .HasKey(d => d.Id);

            modelBuilder.Entity<Position>()
               .ToTable("positions")
               .HasKey(p => p.Id);

            modelBuilder.Entity<User>()
                .HasOne(u => u.EmploymentDetails)
                .WithOne(e => e.User)
                .HasForeignKey<EmploymentDetails>(e => e.UserId);
        }

    }
}
