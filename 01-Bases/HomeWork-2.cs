using System.Globalization;

partial class Program
{
    static void DatesOfLife()
    {
        DateTime birthDate = new(1990, 3, 10);
        TimeSpan difference = DateTime.Now - birthDate; // Calculate the difference between now and the birth date

        Console.WriteLine($"Birth Date: {birthDate:d}");
        Console.WriteLine($"Days Lived: {difference.Days}");
    }

    static void DaysUntilNextBirthday()
    {
        Console.WriteLine("Enter your birth date (dd/MM/yyyy): ");
        string birthDateString = Console.ReadLine()!;
        // cultureInfo.InvariantCulture to ensure consistent parsing regardless of system locale
        DateTime birthDate = DateTime.ParseExact(birthDateString, "dd/MM/yyyy", CultureInfo.InvariantCulture); 
        DateTime nextBirthday = new(DateTime.Now.Year, birthDate.Month, birthDate.Day);
        
        // If the birthday has already occurred this year, set to next year
        if (nextBirthday < DateTime.Now)
        {
            nextBirthday = nextBirthday.AddYears(1);
        }

        TimeSpan timeUntilBirthday = nextBirthday - DateTime.Now;
        Console.WriteLine($"Days until next birthday: {timeUntilBirthday.Days}");
    }
}
 