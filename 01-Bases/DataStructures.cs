partial class Program
{
    static void DataStructures()
    {
        User pedro = new() { Name = "Pedro", Age = "33" };
        pedro.Greet();
        Point p1 = new() { X = 10, Y = 20 };
        Console.WriteLine($"Point coordinates: X={p1.X}, Y={p1.Y}");
        CellPhone phone = new("iPhone 13", "2021");
        Console.WriteLine($"CellPhone Model: {phone.Model}, Year: {phone.Year}");
    }
}

class User
{ 
    public string? Name {get;set;}
    public string? Age {get;set;}
    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}

struct Point
{
    public int X {get; set;}
    public int Y {get; set;}
}

record CellPhone(string Model, string Year);