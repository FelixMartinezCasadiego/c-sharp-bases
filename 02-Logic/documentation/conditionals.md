# Conditionals.cs Documentación

Este archivo muestra ejemplos de cómo utilizar estructuras condicionales en C# para controlar el flujo de un programa.

## ¿Qué son las condicionales?

Las condicionales permiten ejecutar diferentes bloques de código dependiendo de si una condición es verdadera o falsa.

## Ejemplos en el archivo

### if / else

Permite ejecutar un bloque de código si una condición se cumple y otro si no se cumple.

```csharp
if(age >= 18)
{
    WriteLine("You are an adult.");
}
else
{
    WriteLine("You are a minor.");
}
```

### Operador ternario

Permite asignar un valor dependiendo de una condición en una sola línea.

```csharp
string status = (age >= 18) ? "adult" : "minor";
WriteLine($"You are an {status}!");
```

### if / else if / else

Permite manejar múltiples condiciones.

```csharp
if(temperature > 30)
{
    WriteLine("It's a hot day.");
}
else if(temperature >= 20)
{
    WriteLine("It's a warm day.");
}
else
{
    WriteLine("It's a cold day.");
}
```

### switch statement

Permite ejecutar diferentes bloques de código según el valor de una variable.

```csharp
switch(day) {
    case 1:
        WriteLine("Monday");
        break;
    // ...otros casos...
    default:
        WriteLine("Invalid day");
        break;
}
```

### switch expression

Permite asignar un valor según el valor de una variable de forma más concisa.

```csharp
string dayName = day switch {
    1 => "Monday",
    2 => "Tuesday",
    // ...otros casos...
    _ => "Invalid day"
};
WriteLine(dayName);
```

## Resumen

Este archivo es útil para aprender las diferentes formas de tomar decisiones en C# usando condicionales como if, else, else if, el operador ternario y switch.
