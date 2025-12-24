partial class Program
{
    static void InventoryManager()
    {
        string[] products = ["Monitor", "Keyboard", "Mouse", "Printer", "Desk"];
        int[] stock = [15, 30, 25, 10, 5];
        double[] prices = [199.99, 49.99, 29.99, 149.99, 89.99];

        Console.WriteLine("Inventory List:");
        Console.WriteLine("-------------------------------");
        for(int i=0; i <products.Length; i++)
        {
            Console.WriteLine($"{products[i]} | Stock: {stock[i]} | Price: ${prices[i]}");
        }

        Console.WriteLine("\nEnter product do you want to buy: ");
        string? searchedProduct = Console.ReadLine();
        Console.WriteLine("Enter quantity: ");
        int quantity = int.Parse(Console.ReadLine() ?? "0");

        for(int i=0; i< products.Length; i++)
        {
            if (products[i].Equals(searchedProduct, StringComparison.OrdinalIgnoreCase))
            {
                if (quantity <= stock[i])
                {
                     double total = quantity * prices[i];
                    Console.WriteLine($"Total price for {quantity} {products[i]}(s): ${total}");
                } else
                {
                    Console.WriteLine($"Insufficient stock for {products[i]}. Available stock: {stock[i]}");
                }
            }
        }
    }
}