partial class Program
{
    static void HandleNullables()
    {
        // No nulls allowed
        string firstName = "Carlos";

        // Nullable string
        string? lastName = null; // Can hold null but with ?

        if (lastName != null)
        {
            Console.WriteLine($"Full name: {firstName} {lastName}");
        } else
        {
            Console.WriteLine("Last name is not provided.");
        }
        
        // C# 8.0 null-coalescing assignment operator ??
        Console.WriteLine($"LastName: {lastName ?? "No last name"}");
        
        // Null access operator ?.
        string? text = null;
        Console.WriteLine($"Text length: {text?.Length ?? 0}");
    }
}