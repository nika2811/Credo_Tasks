namespace WarehouseManagement.Models;

internal class Warehouse
{
    public List<Product> Products { get; set; }

    public Warehouse()
    {
        Products = new List<Product>();
    }

    public void Add(string name, string category, decimal price, double quantity)
    {
        var product = new Product(name, category, price, quantity);
        Products.Add(product);
    }


    public void Update(string name, decimal price, double quantity)
    {
        var product = FindByName(name);
        if (product == null) return;
        product.Price = price;
        product.Quantity = quantity;
    }

    public void Delete(string name)
    {
        var product = FindByName(name);
        if(product == null) return;
        Products.Remove(product);
    }

    public void ShowAll()
    {
        foreach (var product in Products)
        { 
            Console.WriteLine(product.ToString());
        }
    }

    private Product? FindByName(string name)
    {
        for (var i = 0; i < Products.Count; i++)
        {
            var product = Products[i];
            if (product.Name.ToLower() == name.ToLower()) return product;
        }

        return null;
    }
}