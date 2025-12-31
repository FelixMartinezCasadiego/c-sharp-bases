# Loops.cs Documentación

Este archivo muestra ejemplos de cómo utilizar bucles (loops) en C# para repetir acciones múltiples veces.

## ¿Qué son los bucles?

Los bucles permiten ejecutar un bloque de código varias veces, dependiendo de una condición.

## Ejemplos en el archivo

### while loop

Ejecuta el bloque de código mientras la condición sea verdadera.

```csharp
int count = 1;
while (count <= 5) {
    WriteLine($"While Loop Count: {count}");
    count++; // Incrementa el contador
}
```

### do-while loop

Ejecuta el bloque de código al menos una vez y luego repite mientras la condición sea verdadera.

```csharp
int doCount = 1;
do {
    WriteLine($"Do-While Loop Count: {doCount}");
    doCount++; // Incrementa el contador
} while (doCount < 3);
```

### for loop

Permite ejecutar un bloque de código un número determinado de veces, controlando el inicio, la condición y el incremento/decremento.

```csharp
for (int i = 1; i <= 5; i++) {
    WriteLine($"For Loop Count: {i}");
}
```

#### for con decremento personalizado

```csharp
for (int i = 10; i >= 0; i -= 2) { // Decrementa de 2 en 2
    WriteLine($"For Person Loop Count: {i}");
}
```

### foreach loop

Permite iterar sobre los elementos de una colección (como un array o una lista) de manera sencilla.

#### Iterar sobre un array

```csharp
string[] fruits = [ "Apple", "Banana", "Cherry" ];
foreach (var fruit in fruits) {
    WriteLine($"Fruit: {fruit}");
}
```

#### Iterar sobre una lista

```csharp
List<string> names = ["Luis", "Ana", "Carlos"];
foreach (var name in names) {
    WriteLine($"Name: {name}");
}
```

## Resumen

Este archivo es útil para aprender cómo repetir acciones en C# usando los bucles while y do-while, que permiten controlar el flujo de ejecución según condiciones específicas.

## Control de flujo en bucles

En C#, se pueden usar las sentencias `break`, `continue` y `return` para controlar el flujo dentro de los bucles. También es posible crear bucles infinitos.

### break

Sale completamente del bucle actual.

```csharp
for(int i = 0; i < 10; i++)
{
    if(i == 5)
    {
        break; // Sale del bucle cuando i es 5
    }
    // WriteLine(i);
}
```

### continue

Salta la iteración actual y continúa con la siguiente.

```csharp
for(int i = 0; i < 10; i++)
{
    if(i % 2 == 0)
    {
        continue; // Salta los números pares
    }
    WriteLine(i);
}
```

### return

Sale completamente del método, no solo del bucle.

```csharp
for(int i = 0; i < 10; i++)
{
    if(i == 3)
    {
        return; // Sale del método cuando i es 3
    }
    // WriteLine(i);
}
```

### Bucle infinito

Un bucle que nunca termina a menos que se use break, return o se detenga el programa manualmente.

```csharp
while(true)
{
    WriteLine("Esto se imprimirá para siempre a menos que detengas el programa.");
}
```
