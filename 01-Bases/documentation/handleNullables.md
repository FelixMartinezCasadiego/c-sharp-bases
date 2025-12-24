# Documentación: HandleNullables.cs

Este archivo muestra cómo trabajar con tipos anulables (nullable) en C# y cómo manejar valores nulos de forma segura.

## Conceptos principales

- **Tipos anulables:**

  - En C#, los tipos de referencia como `string` pueden ser declarados como anulables usando el sufijo `?` (por ejemplo, `string?`). Esto permite que la variable almacene un valor nulo (`null`).
  - Ejemplo: `string? lastName = null;`

- **Operador de coalescencia nula (`??`):**

  - Permite proporcionar un valor alternativo si la variable es nula.
  - Ejemplo: `lastName ?? "No last name"` devuelve el valor de `lastName` si no es nulo, o la cadena "No last name" si lo es.

- **Operador de acceso condicional (`?.`):**
  - Permite acceder a miembros de un objeto solo si no es nulo, evitando excepciones.
  - Ejemplo: `text?.Length` devuelve la longitud de `text` si no es nulo, o `null` si lo es.

## Ejemplo de uso

```csharp
string? lastName = null;
Console.WriteLine(lastName ?? "No last name"); // Imprime: No last name

string? text = null;
Console.WriteLine(text?.Length ?? 0); // Imprime: 0
```

## Resumen

- Usar tipos anulables ayuda a evitar errores por referencias nulas.
- Los operadores `??` y `?.` facilitan el manejo seguro de valores nulos en C#.
