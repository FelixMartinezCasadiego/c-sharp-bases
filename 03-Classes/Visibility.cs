partial class Program
{
    static void Visibility()
    {
        Jedi jedi = new()
        {
            PowerLevel = 500,
            LightsaberColor = "Blue"
        };

        jedi.UseForce();
        WriteLine(jedi.PublicField); // Accessible from anywhere

        // WriteLine(jedi.PrivateField); // Not accessible - Uncommenting this line will cause a compilation error
        // WriteLine(jedi.ProtectedField); // Not accessible - Uncommenting this line will cause a compilation error
        jedi.RevealSecrets(); // Accessible - method within the same class

        Sith sith = new()
        {
            PowerLevel = 800,
            LightsaberColor = "Red"
        };
        sith.ShowProtected(); // Accessible - method within derived class
    }
}

class Jedi
{
    public string PublicField = "I'm a Jedi and my power is public."; // Accessible from anywhere
    private readonly string PrivateField = "My thoughts are private."; // Accessible only within this class
    protected string ProtectedField = "The dark side don't have to know my secrets."; // Accessible in derived classes

    public int PowerLevel {get; set;}
    public string? LightsaberColor {get; set;}

    public void UseForce()
    {
        WriteLine($"I'm a jedi using a lightsaber of color {LightsaberColor} with power level {PowerLevel}.");
    }

    private static void Meditate()
    {
        WriteLine("Meditating to increase my power level.");
    }

    protected static void Train()
    {
        WriteLine("Training to become stronger in the Force.");
    }

    public void RevealSecrets()
    {
        WriteLine(PrivateField); // Accessible because it's within the same class
        Meditate(); // Accessible because it's within the same class
    }
}

class Sith : Jedi
{
    public void ShowProtected()
    {
        WriteLine(ProtectedField); // Accessible because Sith inherits from Jedi
        Train(); // Accessible because Train is protected
    }
}