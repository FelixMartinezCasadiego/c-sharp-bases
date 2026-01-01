partial class Program
{
    static void Methods()
    {
        Car car = new(model: "Toyota", year: 2020);
        car.ShowMessage();
        car.ShowMessage("This is a custom message.");
        WriteLine(car.ShowInfo());
        Car.GeneralInfo();   

        Car anotherCar = new(model: "Honda", year: 2018);
        anotherCar.ChangeModel("Honda Civic");
    }
}

class Car(string model, int year)
{
    public string?  Model { get; set; } = model;
    public int? Year { get; set; } = year;
    public void ChangeModel(string newModel)
    {
        Model = newModel;
    }
    public string ShowInfo()
    {
        return $"Model: {Model}, Year: {Year}";
    }

    // Destroyer (~)
    ~Car()
    {
        WriteLine("Car object is being destroyed.");
    }

    // Overloaded methods
    public void ShowMessage() => WriteLine("This is a car.");
    public void ShowMessage(string message) => WriteLine(message);

    // Static method
    public static void GeneralInfo()
    {
        WriteLine("Cars are vehicles that run on roads.");
    }
}