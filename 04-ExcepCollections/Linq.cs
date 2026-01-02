partial class Program
{
    static void Linq()
    {
        List<int> numbers = [1,2,3,4,5,6,7,8,9,10];
        List<int> evenNumbers = []; 

        foreach (var number in numbers)
        {
            if (number % 2 == 0)
            {
                evenNumbers.Add(number);
            }
        }

        // Consult sintax with LINQ
        var evenNumbersQuery = from num in numbers // Data source
                               where num % 2 == 0 // Filter condition
                               select num;       // Projection

        // Method sintax with LINQ
        var evenNumbersMethod = numbers.Where(num => num % 2 == 0); // Using Lambda expression

        // * Simples queries
        List<MarvelCharacter> characters =
        [
            new MarvelCharacter { Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
            new MarvelCharacter { Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
            new MarvelCharacter { Name = "Steve Rogers", Alias = "Captain America", Team = "Avengers" },
            new MarvelCharacter { Name = "Natasha Romanoff", Alias = "Black Widow", Team = "Avengers" },
            new MarvelCharacter { Name = "T'Challa", Alias = "Black Panther", Team = "Wakanda" },
            new MarvelCharacter { Name = "Stephen Strange", Alias = "Doctor Strange", Team = "Defenders" }
        ];

        WriteLine("Characters in Avengers:");
        var avengersQuery = from character in characters
                            where character.Team == "Avengers"
                            select $"{character.Alias} ({character.Name})";

        var avengersMethods = characters.Where(c => c.Team == "Avengers")
                                        .Select(c => $"{c.Alias} ({c.Name})");
    
        foreach (var character in avengersMethods)
        {
            WriteLine(character);
        }

        var sortedQuery = from c in characters // Data source
                          orderby c.Name descending // Sorting
                          select c.Name;       // Projection

        var sortedMethod = characters.OrderByDescending(c => c.Name).Select(c => c.Name); // Using Lambda expression

        var firstThreeQuery = (from c in characters select c).Take(3); // Take first 3 elements
        var firstThreeMethods = characters.Take(3); // Using Lambda expression
    }
}

class MarvelCharacter
{
    public string? Name { get; set; }
    public string? Alias { get; set; }
    public string? Team { get; set; }
}