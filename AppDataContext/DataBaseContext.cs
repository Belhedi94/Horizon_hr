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
        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<LeaveRequest> LeaveRequests { get; set; }
        public DbSet<PublicHoliday> PublicHolidays { get; set; }
        public DbSet<LeaveBalance> LeaveBalances { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_dbSettings.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PublicHoliday>().HasData(
                new PublicHoliday { Id = Guid.NewGuid(), Date = new DateTime(2024, 1, 1), Description = "New year's Day" },
                new PublicHoliday { Id = Guid.NewGuid(), Date = new DateTime(2024, 3, 20), Description = "Independence Day" },
                new PublicHoliday { Id = Guid.NewGuid(), Date = new DateTime(2024, 4, 9), Description = "Martyrs' Day" },
                new PublicHoliday { Id = Guid.NewGuid(), Date = new DateTime(2024, 5, 1), Description = "Labour Day" },
                new PublicHoliday { Id = Guid.NewGuid(), Date = new DateTime(2024, 7, 25), Description = "Republic Day" },
                new PublicHoliday { Id = Guid.NewGuid(), Date = new DateTime(2024, 8, 13), Description = "Women's Day" },
                new PublicHoliday { Id = Guid.NewGuid(), Date = new DateTime(2024, 10, 15), Description = "Evacuation Day" },
                new PublicHoliday { Id = Guid.NewGuid(), Date = new DateTime(2024, 12, 18), Description = "Revolution Day" }
                );

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

            modelBuilder.Entity<BankAccount>()
               .ToTable("bank_accounts")
               .HasKey(b => b.Id);

            modelBuilder.Entity<LeaveRequest>()
                .ToTable("leave_requests")
                .HasKey(l => l.Id);

            modelBuilder.Entity<LeaveBalance>()
                .ToTable("leave_balances")
                .HasKey(l => l.Id);

            modelBuilder.Entity<User>()
                .HasOne(u => u.EmploymentDetails)
                .WithOne(e => e.User)
                .HasForeignKey<EmploymentDetails>(e => e.UserId);

            modelBuilder.Entity<Team>()
                .HasOne(t => t.Department)
                .WithMany(d => d.Teams)
                .HasForeignKey(t => t.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasOne(u => u.BankAccount)
                .WithOne(b => b.User)
                .HasForeignKey<User>(u => u.BankAccountId);

            modelBuilder.Entity<EmploymentDetails>()
                .HasOne(e => e.Team)
                .WithMany(t => t.EmploymentsDetails)
                .HasForeignKey(e => e.TeamId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<EmploymentDetails>()
                .HasOne(e => e.Position)
                .WithMany(p => p.EmploymentsDetails)
                .HasForeignKey(e => e.PositionId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasMany(u => u.LeaveRequests)
                .WithOne(l => l.User)
                .HasForeignKey(l => l.UserId);

        }

    }
}
