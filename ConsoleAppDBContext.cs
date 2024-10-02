using Microsoft.EntityFrameworkCore;
 
public class ConsoleAppDBContext : DbContext
{
    public DbSet<User> Users { get; set; } = null!;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=ef_db;Username=postgres;Password=01062007;");
    }
}