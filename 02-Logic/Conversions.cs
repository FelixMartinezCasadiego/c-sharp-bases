partial class Program
{
    static void Conversions()
    {
        int number = 42;
        double doubleNumber = number; // Implicit conversion from int to double
        // Console.WriteLine($"Implicit conversion: int {number} to double {doubleNumber}");
        
        double explicitDoubleNumber = 45.5;
        int explicitIntNumber = (int)explicitDoubleNumber; // Explicit conversion from double to int
        // Console.WriteLine($"Explicit conversion: double {explicitDoubleNumber} to int {explicitIntNumber}");

        // Convert and Parse method
        string numberString = "123";
        // int convertedNumber = Convert.ToInt32(numberString);
        int convertedNumber = int.Parse(numberString);
        WriteLine($"Convert method: string \"{numberString}\" to int {convertedNumber}");

        double anotherDecimalNumber = 50.8;
        int convertNumber = Convert.ToInt32(anotherDecimalNumber); // Rounds the number
        WriteLine($"Convert method: double {anotherDecimalNumber} to int {convertNumber}");
        int castedNumber = (int)anotherDecimalNumber; // Truncates the decimal part
        WriteLine($"Casting: double {anotherDecimalNumber} to int {castedNumber}");
    }
}