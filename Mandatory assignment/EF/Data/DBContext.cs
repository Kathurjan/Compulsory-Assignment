using EF_Compulsory_Assignment.Model;

namespace EF_Compulsory_Assignment.Data;

using Microsoft.EntityFrameworkCore;

public class DBContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=myapp.db");
    }
}