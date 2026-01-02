partial class Program
{
    static void Collections()
    {
        List<string> names = ["Alice", "Bob", "Charlie"]; // Collection initializer
        names.Add("Diana"); // Adding an element
        ShowNames(names);
        names.Remove("Bob"); // Removing an element
        
        Dictionary<int, string> students = new() {
            {1, "John"},
            {2, "Jane"},
            {3, "Jim"}
        }; // Dictionary initializer
        students.Add(4, "Jill"); // Adding a key-value pair
        students.Remove(2); // Removing a key-value pair
        ShowStudents(students);
        
        HashSet<string> uniqueNames = ["Alice", "Bob", "Charlie"]; // HashSet initializer
        uniqueNames.Add("Alice"); // Attempting to add a duplicate
        uniqueNames.Add("Diana"); // Adding a new unique element
        foreach (var name in uniqueNames)
        {
            Console.WriteLine(name);
        }
        uniqueNames.Remove("Bob"); // Removing an element
    }

    private static void ShowNames(List<string> names)
    {
        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }

    private static void ShowStudents(Dictionary<int, string> students)
    {
        foreach (var student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
        }
    }
}