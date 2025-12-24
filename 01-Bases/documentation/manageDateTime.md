# ManageDateTime.cs Documentation

Este archivo contiene ejemplos de cómo trabajar con fechas y horas en C# utilizando la clase `DateTime`.

## Funcionalidad principal

La función `ShowTime()` demuestra cómo obtener y manipular fechas y horas:

- **Obtener la fecha y hora actual:**

  ```csharp
  DateTime now = DateTime.Now;
  ```

  Devuelve la fecha y hora actual del sistema.

- **Obtener solo la fecha actual (sin hora):**

  ```csharp
  DateTime today = DateTime.Today;
  ```

  Devuelve la fecha actual con la hora establecida en 00:00:00.

- **Obtener la fecha y hora de hace una semana:**

  ```csharp
  DateTime oneWeekAgo = now.AddDays(-7);
  ```

  Resta 7 días a la fecha y hora actual.

- **Crear una fecha personalizada:**

  ```csharp
  DateTime customDate = new(2023, 12, 25);
  ```

  Crea una instancia de `DateTime` para el 25 de diciembre de 2023.

- **Obtener el día de la semana:**

  ```csharp
  DayOfWeek dayOfWeek = now.DayOfWeek;
  ```

  Devuelve el día de la semana correspondiente a la fecha actual.

- **Imprimir resultados:**
  ```csharp
  Console.WriteLine($"Now: {now} \nToday: {today} \nOne Week Ago: {oneWeekAgo} \nCustom Date: {customDate} \nDay of the Week: {dayOfWeek}");
  ```
  Muestra en consola los valores calculados.

## Resumen

Este archivo es útil para aprender las operaciones básicas con fechas y horas en C#, como obtener la fecha actual, manipular fechas y mostrar información relevante en consola.
