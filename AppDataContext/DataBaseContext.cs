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
        public DbSet<LeaveBalance> LeaveBalances { get; set; }
        public DbSet<PublicHoliday> PublicHolidays { get; set; }

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

            modelBuilder.Entity<BankAccount>()
               .ToTable("bank_accounts")
               .HasKey(b => b.Id);

            modelBuilder.Entity<LeaveRequest>()
                           .ToTable("leave_requests")
                           .HasKey(l => l.Id);

            modelBuilder.Entity<LeaveBalance>()
                .ToTable("leave_balances")
                .HasKey(lb => lb.Id);

            modelBuilder.Entity<PublicHoliday>()
                .ToTable("public_holidays")
                .HasKey(p => p.Id);

            modelBuilder.Entity<User>()
                .HasOne(u => u.EmploymentDetails)
                .WithOne(e => e.User)
                .HasForeignKey<EmploymentDetails>(e => e.UserId);

            modelBuilder.Entity<Team>()
                .HasOne(t => t.Department)
                .WithMany(d => d.Teams)
                .HasForeignKey(t => t.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

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

            modelBuilder.Entity<LeaveRequest>()
                .HasOne(l => l.User)
                .WithMany(u => u.LeaveRequests)
                .HasForeignKey(l => l.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .HasOne(u => u.LeaveBalance)
                .WithOne(lb => lb.User)
                .HasForeignKey<LeaveBalance>(lb => lb.UserId);

        }

    }
}
