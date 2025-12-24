partial class Program
{
    static void Operators()
    {
        int number = 15;
        bool isEven = number % 2 == 0; // Equality operator ==
        bool isOdd = number % 2 != 0;  // Inequality operator !=
        bool isGreaterThanTen = number > 10; // Greater than operator >
        bool isLessThanTwenty = number < 20; // Less than operator <
        bool isBetweenTenAndTwenty = isGreaterThanTen && isLessThanTwenty; // Logical AND operator &&
        bool isOutsideRange = isGreaterThanTen || isLessThanTwenty; // Logical OR operator ||

        // ternary operator
        string result = isEven ? "Even" : "Odd";
        Console.WriteLine($"Number: {number}, Result: {result}");
    }
}