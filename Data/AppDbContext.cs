using Microsoft.EntityFrameworkCore;
using CSostenido.Models;

namespace CSostenido.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> User { get; set; }
    public DbSet<SportSection> SportSection { get; set; }
    public DbSet<Reserve> Reserve { get; set; }



    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseMySql(
            "server=localhost;port=3306;database=assessment;user=juan;password=Masterdead1!;",
            ServerVersion.AutoDetect("server=localhost;port=3306;database=assessment;user=juan;password=Masterdead1!;")
        );
    }
}