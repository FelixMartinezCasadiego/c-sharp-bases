partial class Program
{
    static void ListDictionary()
    {
        // List<string> names = new List<string>{"Ana", "Carlos", "Juan"};
        List<string> names = ["Ana", "Carlos", "Juan"];
        
        names.Add("Lucia");
        Console.WriteLine($"Names count: {names.Count}");

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }

        names.Remove("Ana");
        bool isPresent = names.Contains("Ana");
        Console.WriteLine($"Is Ana present? {isPresent}");

        // Dictionary
        Dictionary<int,string> students = new()
        {
            {1, "Ana" },
            {2, "Felipe" },
            {3, "Elena" }
        };

        Console.WriteLine($"Student with key 2: {students[2]}");

        foreach (var student in students)
        {
            Console.WriteLine($"Student: {student}");
            Console.WriteLine($"Key: {student.Key}, Value: {student.Value}");
        }
    }
}