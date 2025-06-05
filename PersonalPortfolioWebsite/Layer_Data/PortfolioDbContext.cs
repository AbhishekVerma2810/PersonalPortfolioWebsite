using Microsoft.EntityFrameworkCore;
using PersonalPortfolioWebsite.Models;

namespace PersonalPortfolioWebsite.Layer_Data
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options) { }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Experience> Experiences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>().HasOne(p => p.Experience).WithMany().HasForeignKey(p => p.ExperienceId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
