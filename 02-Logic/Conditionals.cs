partial class Program
{
    static void Conditionals()
    {
        int age = 19;

        if(age >= 18)
        {
            WriteLine("You are an adult.");
        }
        else
        {
            WriteLine("You are a minor.");
        }

        // Using ternary operator
        string status = (age >= 18) ? "adult" : "minor";
        WriteLine($"You are an {status}!");

        // Multiple conditions
        int temperature = 30;

        if(temperature > 30)
        {
            WriteLine("It's a hot day.");
        }
        else if(temperature >= 20)
        {
            WriteLine("It's a warm day.");
        }
        else
        {
            WriteLine("It's a cold day.");
        }

        // Switch statement example
        int day = 3;
        switch(day) {
            case 1:
                WriteLine("Monday");
                break;
            case 2:
                WriteLine("Tuesday");
                break;
            case 3:
                WriteLine("Wednesday");
                break;
            case 4:
                WriteLine("Thursday");
                break;
            case 5:
                WriteLine("Friday");
                break;
            case 6:
                WriteLine("Saturday");
                break;
            case 7:
                WriteLine("Sunday");
                break;
            default:
                WriteLine("Invalid day");
                break;          
        };

        // Switch expression example
        string dayName = day switch {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "Invalid day"
        };
        WriteLine(dayName);
    }
}