# Tuplas en C#

## ¿Qué es una tupla?

Una **tupla** es una estructura de datos que permite almacenar un conjunto de elementos de diferentes tipos en una sola variable. A diferencia de las clases o estructuras, las tuplas son ligeras y se utilizan principalmente para agrupar datos relacionados de manera temporal, sin necesidad de definir un tipo específico para ellos. Son útiles cuando se desea devolver múltiples valores desde un método o función.

En C#, las tuplas pueden ser anónimas (sin nombres de campos) o con nombres de campos, lo que mejora la legibilidad del código.

## Ejemplo de uso en Tuples.cs

El archivo `Tuples.cs` contiene ejemplos prácticos de cómo declarar, inicializar y utilizar tuplas en C#:

- Declaración de una tupla anónima:

  ```csharp
  (int, string) myTuple = (42, "Hello World");
  WriteLine($"Item1: {myTuple.Item1}, Item2: {myTuple.Item2}");
  ```

- Declaración de una tupla con nombres de campos:

  ```csharp
  (int Number, string Text) myOtherTuple = (42, "Hello World");
  WriteLine($"Number: {myOtherTuple.Number}, Text: {myOtherTuple.Text}");
  ```

- Uso de tuplas como valor de retorno en funciones:

  ```csharp
  static (int Sum, int Subtractions) Operations(int a, int b)
  {
      return (a + b, a - b);
  }
  var result = Operations(10, 5);
  WriteLine($"Sum: {result.Sum}, Subtractions: {result.Subtractions}");
  ```

Las tuplas facilitan la agrupación y el manejo de datos relacionados de forma sencilla y eficiente, mejorando la claridad y reduciendo la necesidad de estructuras adicionales cuando no son necesarias.
