# listDictionary.cs Documentación

Este archivo muestra ejemplos básicos de uso de las colecciones `List` y `Dictionary` en C#.

## ¿Qué es una List?

Una **List** en C# es una colección ordenada de elementos del mismo tipo, donde cada elemento tiene una posición (índice) y se accede por ese índice. Es similar a un array, pero con funcionalidades adicionales como agregar, eliminar y buscar elementos de manera sencilla.

## ¿Qué es un Dictionary?

Un **Dictionary** en C# es una colección de pares clave-valor, donde cada elemento se accede usando una clave única. Permite asociar un valor a una clave y acceder rápidamente a los valores mediante sus claves. Es similar a un objeto en JavaScript o un mapa en otros lenguajes.

## Funcionalidad principal

La función `ListDictionary()` demuestra cómo trabajar con listas y diccionarios:

### Uso de List<string>

- **Declaración e inicialización:**
  ```csharp
  List<string> names = ["Ana", "Carlos", "Juan"];
  ```
- **Agregar elementos:**
  ```csharp
  names.Add("Lucia");
  ```
- **Contar elementos:**
  ```csharp
  names.Count
  ```
- **Recorrer la lista:**
  ```csharp
  foreach (var name in names) { ... }
  ```
- **Eliminar elementos:**
  ```csharp
  names.Remove("Ana");
  ```
- **Verificar existencia:**
  ```csharp
  names.Contains("Ana");
  ```

### Uso de Dictionary<int, string>

- **Declaración e inicialización:**
  ```csharp
  Dictionary<int, string> students = new() {
      {1, "Ana"},
      {2, "Felipe"},
      {3, "Elena"}
  };
  ```
- **Acceso por clave:**
  ```csharp
  students[2]; // Devuelve "Felipe"
  ```
- **Recorrer el diccionario:**
  ```csharp
  foreach (var student in students) {
      // student.Key, student.Value
  }
  ```

## Resumen

Este archivo es útil para aprender las operaciones básicas con listas y diccionarios en C#, como agregar, eliminar, buscar y recorrer elementos.
