partial class Program
{
    static void ShowNumericTypes()
    {
        // int integerNumber = int.MaxValue; // Maximum value for int
        int integerNumber = 42; // 32-bit signed integer
        double doubleNumber = 3.1416D; // 64-bit double-precision floating-point number with D suffix
        float floatNumber = 3.14F; // 32-bit single-precision floating-point, less precise than double but use less memory with F suffix
        long longNumber = 123_456_789L; // 64-bit signed integer with L suffix
        decimal decimalType = 19.99M; // 128-bit precise decimal type for financial calculations with M suffix
        var inferredDecimal = 19.99M; // Type inferred as decimal

        Console.WriteLine($"Int: {integerNumber}, Double: {doubleNumber}, Float: {floatNumber}, Long: {longNumber}, Decimal: {decimalType} Inferred Decimal: {inferredDecimal}");
    }
}
