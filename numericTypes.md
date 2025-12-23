# Tipos Numéricos en C#

En C#, existen varios tipos numéricos primitivos que se utilizan para representar diferentes rangos y precisiones de números. A continuación se muestra un ejemplo de cómo declarar y utilizar estos tipos:

```csharp
partial class Program
{
    static void ShowNumericTypes()
    {
        // int integerNumber = int.MaxValue; // Valor máximo para int
        int integerNumber = 42; // Entero con signo de 32 bits
        double doubleNumber = 3.1416D; // Número de punto flotante de doble precisión (64 bits), sufijo D
        float floatNumber = 3.14F; // Número de punto flotante de precisión simple (32 bits), sufijo F
        long longNumber = 123_456_789L; // Entero largo con signo de 64 bits, sufijo L
        decimal decimalType = 19.99M; // Tipo decimal de 128 bits para cálculos financieros, sufijo M
        var inferredDecimal = 19.99M; // Tipo inferido como decimal

        Console.WriteLine($"Int: {integerNumber}, Double: {doubleNumber}, Float: {floatNumber}, Long: {longNumber}, Decimal: {decimalType}, Inferred Decimal: {inferredDecimal}");
    }
}
```

**Descripción de los tipos:**

- `int`: Entero con signo de 32 bits. Rango aproximado: -2,147,483,648 a 2,147,483,647.
- `double`: Número de punto flotante de doble precisión (64 bits). Útil para cálculos científicos.
- `float`: Número de punto flotante de precisión simple (32 bits). Menor precisión y uso de memoria que double.
- `long`: Entero largo con signo de 64 bits. Rango mucho mayor que int.
- `decimal`: Tipo decimal de 128 bits, ideal para cálculos financieros por su alta precisión.

**Inferencia de tipos con `var`:**

En C#, la palabra clave `var` permite que el compilador infiera el tipo de la variable a partir del valor asignado. Por ejemplo:

```csharp
var inferredDecimal = 19.99M; // El tipo es inferido como decimal
```

Esto es útil para simplificar el código, pero el tipo real sigue siendo fuerte y determinado en tiempo de compilación.
