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

    static void BusFleet()
    {
        Fleet fleet = new();
        Bus bus1 = new(brand: "Volvo", model: "7700", year: 2015, price: 120000, totalKilometers: 150000);
        Bus bus2 = new(brand: "Mercedes", model: "Citaro", year: 2018, price: 150000, totalKilometers: 80000);
        fleet.AddBus(bus1);
        fleet.AddBus(bus2);
        bus1.Drive(500);
        fleet.ShowFleet();
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

class Bus(string brand, string model,int year, double price, int totalKilometers)
{
    public string? Brand { get; set; } = brand;
    public string? Model { get; set; } = model;
    public int Year { get; set; } = year;
    public double Price { get; set; } = price;
    public int TotalKilometers { get; set; } = totalKilometers;

    public void Drive(int kilometers)
    {
        TotalKilometers += kilometers;
    }

    public double ShowPrice() {
        return Price;
    }
}

class Fleet
{
    private readonly List<Bus> buses = [];

    public void AddBus(Bus bus)
    {
        buses.Add(bus);
    }
    
    public void ShowFleet()
    {
        WriteLine("Fleet:");

        foreach (var bus in buses)
        {
            WriteLine($"Bus: {bus.Brand} {bus.Model}, Year: {bus.Year}, Price: {bus.Price}, Total Kilometers: {bus.TotalKilometers}");
        }
    }
}