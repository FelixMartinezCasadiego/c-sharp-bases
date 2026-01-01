partial class Program
{
    static void ProductSalesDemo()
    {
        Inventory inventory = new();
        Product laptop = new(name: "Laptop", price: 999.99, stock: 10);
        Product mouse = new(name: "Mouse", price: 19.99, stock: 50);
        inventory.AddProduct(laptop);
        inventory.AddProduct(mouse);
        inventory.ShowInvetory();
    }
}

class Product(string name, double price, int stock)
{
    public string? Name { get; set; } = name;
    public double Price { get; set; } = price;
    public int Stock { get; set; } = stock;

    public void ShowInfo()
    {
        WriteLine($"Product: {Name}, Price: {Price}, Stock: {Stock}");
    }

    public bool Sell(int quantity)
    {
        if(quantity <= Stock)
        {
            WriteLine($"Sold {quantity} of {Name}");
            Stock -= quantity;
            return true;
        }
        return false;
    }
}

class Inventory
{
    private readonly List<Product> products = [];

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public void ShowInvetory()
    {
        WriteLine("Inventory:");

        foreach (var product in products)
        {
            product.ShowInfo();
        }
    }
}