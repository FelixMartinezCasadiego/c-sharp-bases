partial class Program
{
    static void EmployeeInformation()
    {
        List<Employee> employees =
        [
            new TeamLeader(name:"Carlos",salary:5000),
            new Developer(name:"Ana", salary:4000),
            new TeamLeader(name:"Laura", salary:6000),
            new Developer(name:"Luis", salary:3500)
        ];

        foreach (var employee in employees)
        {
            employee.ShowInfo();
        }
    }
}

class Employee(string name, double salary, string position)
{
    protected string Name = name;
    protected double Salary = salary;
    protected string Position = position;

    public virtual double CalculateBonus()
    {
        return Salary * 0.05;
    }

    public void ShowInfo()
    {
        WriteLine($"Employee: {Name}, Position: {Position}, Salary: {Salary}, Bonus: {CalculateBonus():C}");
    }
}

class TeamLeader(string name, double salary) : Employee(name, salary, "Team Leader")
{
    
    public override double CalculateBonus()
    {
        return Salary * 0.1;
    }
}

class Developer(string name, double salary) : Employee(name, salary, "Developer")
{
    public override double CalculateBonus()
    {
        return Salary * 0.07;
    }
}