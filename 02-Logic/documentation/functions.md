# Functions.cs Documentación

Este archivo muestra ejemplos de cómo definir y utilizar funciones (métodos) en C#.

## ¿Qué es una función?

Una función (o método) es un bloque de código reutilizable que realiza una tarea específica y puede devolver un valor.

## ¿Qué significa static?

El modificador `static` indica que la función pertenece a la clase y no a una instancia específica de la clase. Esto significa que puedes llamar a la función sin crear un objeto de la clase. Por ejemplo, puedes llamar a `CalculateArea` directamente desde otro método estático dentro de la misma clase.

**Ejemplo:**

```csharp
static void Saludar()
{
    WriteLine("¡Hola!");
}

// Se puede llamar así, sin crear un objeto:
Saludar();
```

Las funciones estáticas son útiles para operaciones que no dependen de datos de un objeto específico.

## Ejemplos en el archivo

### Definir una función que retorna un valor

```csharp
static double CalculateArea(double width, double height)
{
    return width * height;
}
```

### Definir una función que evalúa un número

```csharp
static string EvaluateNumber(int number)
{
    if(number > 0)
        return "Positive";
    else if(number < 0)
        return "Negative";
    else
        return "Zero";
}
```

### Llamar funciones desde otro método

```csharp
var area = CalculateArea(4.5, 2.3);
WriteLine($"Area: {area}");

var evaluation = EvaluateNumber(10);
WriteLine($"The number is: {evaluation}");
```

## Resumen

Este archivo es útil para aprender cómo declarar, definir y utilizar funciones en C#, incluyendo el retorno de valores y la reutilización de lógica.
