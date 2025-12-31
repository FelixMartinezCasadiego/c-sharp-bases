partial class Program
{
    static void LoopControlExamples()
    {
        for(int i = 0; i < 10; i++)
        {
            if(i == 5)
            {
                break; // exits the loop entirely
            }
            // WriteLine(i);
        }

        for(int i = 0; i < 10; i++)
        {
            if(i % 2 == 0)
            {
                continue; // skips the current iteration for even numbers
            }
            WriteLine(i);
        }
        
        for(int i = 0; i < 10; i++)
        {
            if(i == 3)
            {
                return; // exits the method entirely
            }
            // WriteLine(i);
        }

        // infinite loop example

        while(true)
        {
            // WriteLine("This will print forever unless you stop the program.");
        }
    }
}