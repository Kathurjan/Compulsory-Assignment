using System;
using System.Linq;
using EF_Compulsory_Assignment.Data;
using EF_Compulsory_Assignment.Model;

class Program
{
    static void Main(string[] args)
    {   
        EnsureDatabaseCreated();

        using var db = new DBContext();
       
        db.Products.Add(new Product { Name = "Example Product", Price = 9.99m });
        db.SaveChanges();

        
        var products = db.Products.ToList();
        foreach (var product in products)
        {
            Console.WriteLine($"Product ID: {product.ProductId}, Name: {product.Name}, Price: {product.Price}");
        }
    }

    private static void EnsureDatabaseCreated()
    {
        using var db = new DBContext();
        db.Database.EnsureCreated();
    }
}