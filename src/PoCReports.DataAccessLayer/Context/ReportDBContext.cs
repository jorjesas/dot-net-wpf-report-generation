using Microsoft.EntityFrameworkCore;
using PoCReports.Models;

namespace PoCReports.DataAccessLayer
{
    public class ReportDBContext : DbContext
    {
        public ReportDBContext(DbContextOptions<ReportDBContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=TestReportDB;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IntensityCheckDao>()
            .HasKey(b => b.Id);

            modelBuilder.Entity<MonochromatorDao>()
            .HasKey(b => b.Id);
        }

        public virtual DbSet<IntensityCheckDao> IntensityChecks { get; set; }
        public virtual DbSet<MonochromatorDao> Monochromators { get; set; }
    }
}
