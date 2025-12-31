using System.Globalization; // For CultureInfo

partial class Program
{
    static void ConversionsToDateTime()
    {
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-ES");

        int friends = int.Parse("101");
        double cost = 25.50;
        DateTime birthday = DateTime.Parse("2 Marzo 2025");
        WriteLine($"Have {friends} friends. Birthday: {birthday:D}");
        WriteLine($"long date: {birthday}");
        WriteLine($"currency: {cost:C}");
    }
}