/*
=====================================
Análisis de Ventas con LINQ y Excepciones
=====================================
*/
// 🏆 Ejercicio:
// Desarrollar un sistema para analizar las ventas de una empresa usando colecciones y LINQ.
// Tendrás una clase "Sale" con las siguientes propiedades:
//  - Product (public)
//  - Category (public)
//  - Amount (public)
//
// También una lista con 6 ventas ficticias.
// Lo que tendrás que desarrollar es:
// 1. Filtrar y mostrar las ventas con monto superior a 1000.
// 2. Agrupar las ventas por categoría y calcular el total de ventas por categoría.
// 3. Manejar excepciones en caso de errores al procesar los datos.

partial class Program
{
    static void SalesAnalysis()
    {
        List<Sale> sales = [
            new Sale("Laptop", "Electrónica", 1500),
            new Sale("Teléfono", "Electrónica", 900),
            new Sale("Silla", "Muebles", 1200),
            new Sale("Escritorio", "Muebles", 800),
            new Sale("Tablet", "Electrónica", 1300),
            new Sale("Lámpara", "Iluminación", 400)
        ];

        WriteLine("Ventas con monto superior a 1000:");
        
        try
        {
            var hightValuesSales = sales.Where(sale => sale.Amount > 1000); // Filtrar ventas > 1000

            foreach (var sale in hightValuesSales)
            {
                WriteLine($"Producto: {sale.Product}, Categoría: {sale.Category}, Monto: {sale.Amount}");
            }

            WriteLine("\nTotal de ventas por categoría:");
            var salesBuCategory = sales.GroupBy(sale => sale.Category) // Agrupar por categoría
                                        .Select(group => new
                                        {
                                            Category = group.Key,
                                            TotalAmount = group.Sum(sale => sale.Amount) // Sumar montos por categoría
                                        });

            foreach (var categorySales in salesBuCategory)
            {
                WriteLine($"Categoría: {categorySales.Category}, Total: {categorySales.TotalAmount:C}");
            }
        }
        catch (Exception ex)
        {
            WriteLine($"Error al procesar las ventas: {ex.Message}");
        }
    }
}

class Sale(string product, string category, double amount)
{
    public string? Product { get; set; } = product;
    public string? Category { get; set; } = category;
    public double Amount { get; set; } = amount;
}