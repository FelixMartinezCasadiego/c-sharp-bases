partial class Program
{
    static void Tuples()
    {
        (int, string) myTuple = (42, "Hello World");
        WriteLine($"Item1: {myTuple.Item1}, Item2: {myTuple.Item2}");
        
        (int Number, string Text) myOtherTuple = (42, "Hello World");
        WriteLine($"Number: {myOtherTuple.Number}, Text: {myOtherTuple.Text}");

        static (int Sum, int Subtractions) Operations(int a, int b)
        {
            return (a + b, a - b);
        }
        var result = Operations(10, 5);
        WriteLine($"Sum: {result.Sum}, Subtractions: {result.Subtractions}");
    }
}