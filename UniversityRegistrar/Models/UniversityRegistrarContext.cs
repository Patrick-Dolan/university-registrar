using Microsoft.EntityFrameworkCore;

namespace UniversityRegistrar.Models
{
  public class UniversityRegistrarContext : DbContext
  {
    public DbSet<DatabaseTablePlaceholder> DatabaseTablePlaceholder { get; set; }
    public UniversityRegistrarContext(DbContextOptions options) : base(options) { }
  }
}