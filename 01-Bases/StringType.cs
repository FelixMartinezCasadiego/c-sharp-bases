partial class Program
{
    static void ShowStringTypes()
    {
        string name = "Jhon Doe"; // Regular string
        string message = "Hello, " + name + "!"; // String concatenation
        string interpolatedMessage = $"Welcome, {name}!"; // String interpolation

        Console.WriteLine($"Name: {name} \nMessage: {message} \nInterpolated Message: {interpolatedMessage}");
    }
}
