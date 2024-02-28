namespace EF_Compulsory_Assignment.Model;
public class Product
{   
    public int ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public int CategoryId_FK { get; set; }

    public Category Category { get; set; }
}

