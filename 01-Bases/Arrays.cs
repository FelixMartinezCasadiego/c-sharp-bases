partial class Program
{
    static void Arrays()
    {
        int[] numbers = new int[2]; // Declaration and allocation
        numbers[0] = 10;
        numbers[1] = 20;

        // Direct initialization
        int[] moreNumbers = [5,10,15,20,25,30];

        // Accessing elements (indexing starts at 0)
        Console.WriteLine($"First number: {numbers[0]}");
        // Console.WriteLine($"Second number: {moreNumbers[1]}");

        // Size of the array
        Console.WriteLine($"Size of numbers array: {numbers.Length}");

        // Since the last element
        Console.WriteLine($"Last number in moreNumbers: {moreNumbers[moreNumbers.Length - 1]}");
        Console.WriteLine($"Last number in moreNumbers Using ^ operator: {moreNumbers[^1]}"); // Using ^ operator
        Console.WriteLine($"Penultimate number in moreNumbers Using ^ operator: {moreNumbers[^2]}"); // Using ^ operator

        // Ranges to obtening subarrays
        int[] firstThree = moreNumbers[..3]; // From index 0 to 2
        int[] fromIndexTwo = moreNumbers[2..]; // From index 2 to the end
        int[] middleSegment = moreNumbers[2..5]; // From index 2 to 4

        foreach (var num in middleSegment)
        {
        Console.WriteLine(num);
        }
        
    }
}