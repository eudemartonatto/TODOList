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

    public DbSet<TODOItem> Items { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Login> Logins { get; set; }
    public DbSet<TODOItem> Acessar { get; set; }
  }
}