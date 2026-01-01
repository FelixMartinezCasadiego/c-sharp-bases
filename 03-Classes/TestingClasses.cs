partial class Program
{
    static void TestingClass()
    {
        Vehicle toyota = new("Toyota", "Corolla", 2020);
        toyota.ShowInfo();
    }
}

class Vehicle(string brand, string model, int year) // Primary constructor
{
    // Properties
    public string? Brand { get; set; } = brand;
    public string? Model { get; set; } = model;
    public int Year { get; set; } = year;

    // Methods
    public void ShowInfo()
    {
        WriteLine($"Brand: {Brand}, Model: {Model}, Year: {Year}");
    }
}