using Microsoft.EntityFrameworkCore;
using TODOList.Models;

namespace TODOList.Data
{
  public class TODOListContext : DbContext
  {
    public TODOListContext(DbContextOptions<TODOListContext> options)
        : base(options)
    {
    }

    public DbSet<Cliente> Cliente { get; set; }

    public DbSet<TODOList.Models.Login> Login { get; set; }

    public DbSet<TODOList.Models.TODOItem> TODOItem { get; set; }
  }
}