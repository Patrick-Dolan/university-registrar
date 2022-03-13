using Microsoft.EntityFrameworkCore;

namespace ProjectName.Models
{
  public class ProjectNameContext : DbContext
  {
    public DbSet<DatabaseTablePlaceholder> DatabaseTablePlaceholder { get; set; }
    public ProjectNameContext(DbContextOptions options) : base(options) { }
  }
}