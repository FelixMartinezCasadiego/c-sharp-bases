partial class Program
{
    static void Properties()
    {
        Animal lion = new("Savannah")
        {
            Species = "Lion",
            Age = 5
        };
        WriteLine($"Species: {lion.Species}, Category: {lion.Category}, Age: {lion.Age}, Habitat: {lion.Habitat}");
    }
}

class Animal(string habitat)
{
    public string Species { get; set; }= "Unknown";
    public string Category {get;} = "Vertebrate";
    private int age;

    public int Age
    {
        get {return age;}
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Age cannot be negative.");
            }
            else
            {
                age = value;
            }
        }
    }

    public string Habitat { get; } = habitat;
}