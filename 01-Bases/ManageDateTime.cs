partial class Program
{
    static void ShowTime()
    {
        DateTime now = DateTime.Now; // Current date and time
        DateTime today = DateTime.Today; // Current date with time set to 00:00:00
        DateTime oneWeekAgo = now.AddDays(-7); // Date and time one week ago
        DateTime customDate = new(2023, 12, 25); // Custom date and time
        
        DayOfWeek dayOfWeek = now.DayOfWeek; // Day of the week

        Console.WriteLine($"Now: {now} \nToday: {today} \nOne Week Ago: {oneWeekAgo} \nCustom Date: {customDate} \nDay of the Week: {dayOfWeek}");
    }
}
