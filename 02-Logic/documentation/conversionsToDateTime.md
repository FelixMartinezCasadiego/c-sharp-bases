# ConversionsToDateTime.cs Documentación

Este archivo muestra ejemplos de cómo realizar conversiones a tipos DateTime y cómo formatear datos en C#.

## Conversión de cadenas a DateTime

Puedes convertir una cadena de texto a un objeto DateTime usando el método `DateTime.Parse`. Es importante considerar la cultura (formato de fecha) utilizada.

```csharp
using System.Globalization;
CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("es-ES");
DateTime birthday = DateTime.Parse("2 Marzo 2025");
```

## Conversión de cadenas a tipos numéricos

```csharp
int friends = int.Parse("101");
```

## Formateo de fechas y monedas

Puedes mostrar fechas y valores numéricos en diferentes formatos usando interpolación de cadenas:

```csharp
WriteLine($"Have {friends} friends. Birthday: {birthday:D}"); // Fecha larga
WriteLine($"long date: {birthday}");
WriteLine($"currency: {cost:C}"); // Formato moneda
```

## Resumen

Este archivo es útil para aprender cómo convertir cadenas a fechas y números, y cómo mostrar datos formateados según la cultura en C#.
