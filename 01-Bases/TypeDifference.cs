using System.Globalization;

partial class Program
{
    static void TypeDifference()
    {
        // Demonstrating value type behavior Value Types
        int x = 5;
        int y = x;
        y = 15;
        Console.WriteLine($"x: {x}, y: {y}"); // x remains 5, y is now 15

        Person person1 = new() { Name = "Carlos" };
        Person person2 = person1;
        person2.Name = "Ana";
        Console.WriteLine($"person1.Name: {person1.Name}, person2.Name: {person2.Name}"); // Both person1.Name and person2.Name are "Ana"
    }
}
 

// Demonstrating reference type behavior Reference Types
class Person
{
    public string? Name { get; set; }    
}