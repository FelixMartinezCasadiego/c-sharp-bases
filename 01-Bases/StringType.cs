partial class Program
{
    static void ShowStringTypes()
    {
        string name = "Jhon Doe"; // Regular string
        string message = "Hello, " + name + "!"; // String concatenation
        string interpolatedMessage = $"Welcome, {name}!"; // String interpolation
        int number = 42;
        number.ToString(); // Convert number to string

        Console.WriteLine($"Name: {name} \nMessage: {message} \nInterpolated Message: {interpolatedMessage}");
        Console.WriteLine("Length of name: " + name.Length); // String length
        Console.WriteLine("Uppercase name: " + name.ToUpper()); // Convert to uppercase
        Console.WriteLine("Lowercase name: " + name.ToLower()); // Convert to lowercase
    }
}
