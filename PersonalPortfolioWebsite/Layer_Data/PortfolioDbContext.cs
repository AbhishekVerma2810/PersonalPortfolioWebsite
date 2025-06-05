using Microsoft.EntityFrameworkCore;
using PersonalPortfolioWebsite.Models;

namespace PersonalPortfolioWebsite.Layer_Data
{
    public class PortfolioDbContext : DbContext
    {
        public PortfolioDbContext(DbContextOptions<PortfolioDbContext> options) : base(options) { }
        public DbSet<Project> Projects { get; set; }
    }
}
