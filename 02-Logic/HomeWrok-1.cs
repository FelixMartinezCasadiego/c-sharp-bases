partial class Program
{
    static void FizzBuzz()
    {
        int count = 1;
        
        while (count <= 100)
        {

            string output = count switch
            {
                _ when count % 3 == 0 && count % 5 == 0 => "FizzBuzz",
                _ when count % 3 == 0 => "Fizz",
                _ when count % 5 == 0 => "Buzz",
                _ => count.ToString()   
            };

            WriteLine(output);
            count++;
        }
    }
}