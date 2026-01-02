partial class Program
{
    static void AbstractClasses()
    {
        HomeAppliance myWasher = new WashingMachine()
        {
            Brand = "LG"
        };
        HomeAppliance myMicrowave = new Microwave()
        {
            Brand = "Samsung"
        };
        myWasher.ShowBrand();
        myWasher.TurnOn();
        myMicrowave.ShowBrand();
        myMicrowave.TurnOn();
    }
}

abstract class HomeAppliance
{
    public string? Brand { get; set; }
    public abstract void TurnOn(); // * abstract method has no body
    public void ShowBrand()
    {
        WriteLine($"This appliance is made by {Brand}.");
    }
}

class WashingMachine: HomeAppliance
{
    public override void TurnOn() // * must override abstract method
    {
        WriteLine("The washing machine is now ON.");
    }
}

class Microwave: HomeAppliance
{
    public override void TurnOn() // * must override abstract method
    {
        WriteLine("The microwave is now ON.");
    }
}