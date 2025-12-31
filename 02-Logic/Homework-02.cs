partial class Program
{
    static void PrintFactorialTable(int number)
    {
        
        for (int i = 1; i <= number; i++)
        {
            long factorial = 1;
            for (int j = 1; j <= i; j++)
            {
                factorial *= j;
            }
            WriteLine($"Factorial of {i} is {factorial}");
        }
    }
}