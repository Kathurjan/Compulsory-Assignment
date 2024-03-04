namespace EF_Compulsory_Assignment.Model;
public class Category
{   
    public int CategoryId  { get; set; }
    public string CName  { get; set; }

    public List<Product> Products { get; set; }
}
    
