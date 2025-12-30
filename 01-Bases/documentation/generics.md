# Generics.cs Documentación

Este archivo muestra cómo utilizar métodos genéricos en C# y la diferencia entre métodos específicos y genéricos.

## ¿Qué son los genéricos?

Los **genéricos** permiten definir métodos, clases o estructuras que funcionan con cualquier tipo de dato, aumentando la reutilización y flexibilidad del código.

## Clases genéricas en C#

Además de métodos genéricos, en C# se pueden crear **clases genéricas**. Estas clases permiten trabajar con cualquier tipo de dato, definido en el momento de la instanciación.

### Ejemplo de clase genérica

```csharp
class Box<T>
{
	public T Value { get; set; }
	public Box(T value)
	{
		Value = value;
	}
}

// Uso:
Box<int> intBox = new Box<int>(10);
Box<string> strBox = new Box<string>("Hola");
Console.WriteLine(intBox.Value); // 10
Console.WriteLine(strBox.Value); // Hola
```

Las clases genéricas son útiles para crear estructuras de datos reutilizables y seguras en cuanto a tipos.

## Ejemplo en el archivo

La función `Generics()` compara el uso de métodos específicos y genéricos para obtener la longitud de un arreglo:

### Métodos sin genéricos

- `GetIntArrayLength(int[] array)`: Solo acepta arreglos de enteros.
- `GetStringArrayLength(string[] array)`: Solo acepta arreglos de cadenas.

### Método genérico

- `GetArrayLength<T>(T[] array)`: Acepta arreglos de cualquier tipo (`T`), ya sean enteros, cadenas, etc.

### Uso en el archivo

```csharp
string[] names = ["Juan","Luis", "Diana"];
int[] numbers = [1, 2, 3, 4, 5];
Console.WriteLine($" Without Generics {GetStringArrayLength(names)}");
Console.WriteLine($" Without Generics {GetIntArrayLength(numbers)}");
Console.WriteLine($" With Generics {GetArrayLength(names)}");
Console.WriteLine($" With Generics {GetArrayLength(numbers)}");
```

## Ventajas de los genéricos

- Permiten escribir menos código repetitivo.
- Mejoran la reutilización y el mantenimiento.
- Evitan errores de tipo en tiempo de compilación.

## Resumen

Este archivo es útil para entender cómo los genéricos simplifican el código y permiten trabajar con diferentes tipos de datos usando un solo método.
