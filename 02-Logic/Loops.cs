partial class Program
{
    static void Loops()
    {
        // while loop
        int count = 1;
        while (count <= 5) {
            WriteLine($"While Loop Count: {count}");
            count++; // Increment the counter
        }

        // do-while loop
        int doCount = 1;
        do {
            WriteLine($"Do-While Loop Count: {doCount}");
            doCount++; // Increment the counter
        } while (doCount < 3);

        // for loop
        for (int i = 1; i <= 5; i++) {
            WriteLine($"For Loop Count: {i}");
        }

        // for person loop
        for (int i = 10; i >= 0; i -= 2) { // Decrement by 2
            WriteLine($"For Person Loop Count: {i}");
        }

        // foreach loop
        // Iterate over an array of strings
        string[] fruits = [ "Apple", "Banana", "Cherry" ];
        foreach (var fruit in fruits) {
            WriteLine($"Fruit: {fruit}");
        }

        // List iteration
        List<string> names =["Luis", "Ana", "Carlos"];
        foreach (var name in names) {
            WriteLine($"Name: {name}"); 
        }
    }
}