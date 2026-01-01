partial class Program
{
    static void Inheritance()
    {
        HogartsStudent student = new()
        {
            Name = "Harry Potter",
            House = "Gryffindor"
        };
        student.Greet();
        student.ShowHouse();
        HogartsProfessor professor = new()
        {
            Name = "Severus Snape",
            Subject = "Potions"
        };
        professor.Greet();
        professor.MySubject();
    }
}

class Character
{
    public string? Name { get; set; }
    public virtual void Greet() // * virtual allows overriding
    {
        WriteLine($"Hello, I am a {Name} character.");
    }
}

class HogartsStudent: Character
{
    public string? House { get; set; }

    public override void Greet() // * override changes base class method
    {
        WriteLine($"Hello, I am a student named {Name}.");
    }

    public void ShowHouse()
    {
        WriteLine($"I belong to the {House} house.");
    }
}

class HogartsProfessor: Character
{
    public string? Subject { get; set; }

    public void MySubject()
    {
        WriteLine($"I belong to the {Subject} subject.");
    }
}

