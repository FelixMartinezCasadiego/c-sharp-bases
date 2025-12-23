# Documentación: StringType.cs

Este archivo contiene ejemplos y explicaciones sobre el uso del tipo de dato `string` en C#.

## Contenido de StringType.cs

La función `ShowStringTypes()` demuestra varias operaciones comunes con cadenas de texto:

- **Declaración de cadenas:**
  ```csharp
  string name = "Jhon Doe";
  ```
- **Concatenación de cadenas:**
  ```csharp
  string message = "Hello, " + name + "!";
  ```
- **Interpolación de cadenas:**
  ```csharp
  string interpolatedMessage = $"Welcome, {name}!";
  ```
- **Conversión de números a string:**
  ```csharp
  int number = 42;
  number.ToString();
  ```
- **Propiedades y métodos útiles:**
  - `name.Length`: Obtiene la longitud de la cadena.
  - `name.ToUpper()`: Convierte la cadena a mayúsculas.
  - `name.ToLower()`: Convierte la cadena a minúsculas.

## Ejemplo de salida

```
Name: Jhon Doe
Message: Hello, Jhon Doe!
Interpolated Message: Welcome, Jhon Doe!
Length of name: 8
Uppercase name: JHON DOE
Lowercase name: jhon doe
```

## Resumen

Este archivo es útil para comprender las operaciones básicas con cadenas en C#, incluyendo declaración, concatenación, interpolación y manipulación de texto.
Se puede ver todos los métodos de String en la documentacion: https://learn.microsoft.com/es-mx/dotnet/api/system.string?view=net-9.0
