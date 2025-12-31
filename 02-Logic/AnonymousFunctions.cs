partial class Program
{
    static void AnonymousFunctions()
    {
        WriteLine("Anonymous Functions");
        WriteLine(square(5));  
    }

    static readonly Func<int, int> square = delegate (int number)
    {
        return number * number;
    };

    static readonly Func<int,int> lambdSquare = x => x * x;
}