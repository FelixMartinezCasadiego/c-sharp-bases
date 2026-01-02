partial class Program
{
    static string? amount;
    static void HandleException()
    {
        try
        {    
            // int number = 10;
            // int result = number / 0;
            Write("Enter a number to divide 10 by: ");
            amount = ReadLine();
            if( string.IsNullOrEmpty(amount) ) return;

            // double amountValue = double.Parse(amount);
            if (double.TryParse(amount, out double amountValue)) // Safer parsing
            {    
                WriteLine($"The amount entered is {amountValue:C}");
            } else
            {
                throw new FormatException("Input string was not in a correct format."); // Manually throw exception for demonstration
            }
        }
        catch (DivideByZeroException) // when (number == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Error: Division by zero is not allowed.");
        }
        catch(FormatException) when (amount?.Contains('$') == true) // Specific condition for FormatException
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine("Error: Please do not include currency symbols.");
        }
        catch(Exception ex) // General exception handler
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine($"An error occurred: {ex.Message}");
        } finally
        {
            ForegroundColor = ConsoleColor.White;
            WriteLine("Execution completed. Thank you!");
        }
    }
}