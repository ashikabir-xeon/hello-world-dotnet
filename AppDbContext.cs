using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseMySql("server=localhost;database=helloworld;user=root;password=1234",
            new MySqlServerVersion(new Version(8, 0, 21))); // Change version as per your MySQL version
    }
}