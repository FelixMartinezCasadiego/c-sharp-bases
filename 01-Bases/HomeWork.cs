partial class Program
{
    static void SalesReport()
    {
        string product = "Laptop";
        int quantitySold = 3;
        double pricePerUnit = 799.99;
        double totalSales = quantitySold * pricePerUnit;
        
        Console.WriteLine($"Product: {product}, Quantity Sold: {quantitySold}, Price per Unit: {pricePerUnit:C}, Total Sales: {totalSales:C}");
        // :C is used to format numbers as currency based on the current culture settings.
    }
    static void SalaryCalculator()
    {
        string employeeName = "Teddy";
        double hourlyWage = 12;
        int hoursWorked = 160;
        double totalSalary = hourlyWage * hoursWorked;
        
        Console.WriteLine($"Employee: {employeeName}, Hourly Wage: {hourlyWage:C}, Hours Worked: {hoursWorked}, Total Salary: {totalSalary:C}");
    }
}
