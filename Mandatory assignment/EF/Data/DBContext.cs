using EF_Compulsory_Assignment.Model;

namespace EF_Compulsory_Assignment.Data;

using EF_Compulsory_Assignment.Models;
using Microsoft.EntityFrameworkCore;

public class DBContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<User> Users { get; set; }

    public DbSet<Category> Categories { get; set; }
    public DbSet<ProductRating> ProductRatings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=myapp.db");


    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .HasForeignKey(p => p.CategoryId_FK);

        modelBuilder.Entity<ProductRating>()
            .HasOne(pr => pr.Product)
            .WithMany(p => p.Ratings)
            .HasForeignKey(pr => pr.ProductId_FK);
    }

}