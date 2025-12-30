# Tabla comparativa: Clase, Struct y Record en C#

| Característica                | Clase           | Struct         | Record           |
| ----------------------------- | --------------- | -------------- | ---------------- |
| **Tipo**                      | Referencia      | Valor          | Referencia       |
| **Inmutabilidad por defecto** | No              | No             | Sí               |
| **Comparación**               | Referencias     | Valores        | Valores          |
| **Ideal para**                | Objetos grandes | Datos pequeños | Datos inmutables |

---

- **Clase:** Tipo de referencia, mutable por defecto, comparación por referencia, ideal para objetos grandes.
- **Struct:** Tipo de valor, mutable por defecto, comparación por valor, ideal para datos pequeños.
- **Record:** Tipo de referencia, inmutable por defecto, comparación por valor, ideal para datos inmutables.

## Ejemplos prácticos en C#

### Clase

```csharp
class User
{
	public string? Name {get;set;}
	public string? Age {get;set;}
	public void Greet()
	{
		Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
	}
}
// Uso:
User pedro = new() { Name = "Pedro", Age = "33" };
pedro.Greet();
```

### Struct

```csharp
struct Point
{
	public int X {get; set;}
	public int Y {get; set;}
}
// Uso:
Point p1 = new() { X = 10, Y = 20 };
Console.WriteLine($"Point coordinates: X={p1.X}, Y={p1.Y}");
```

### Record

```csharp
record CellPhone(string Model, string Year);
// Uso:
CellPhone phone = new("iPhone 13", "2021");
Console.WriteLine($"CellPhone Model: {phone.Model}, Year: {phone.Year}");
```
