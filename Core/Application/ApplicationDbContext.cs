
using FloatAB.Core.Models;
using Microsoft.EntityFrameworkCore;

namespace FloatAB.Core.Application
{
  public class ApplicationDbContext : DbContext
  {
    public DbSet<TicketEntity> Tickets { get; set; }
    public DbSet<ColumnEntity> Columns { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
  }
}