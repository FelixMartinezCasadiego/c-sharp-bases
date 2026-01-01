# Métodos en C#

## ¿Qué es un método?

Un **método** en C# es un bloque de código que realiza una tarea específica, puede recibir parámetros y devolver un valor. Los métodos ayudan a organizar el código, reutilizar lógica y mejorar la legibilidad de los programas.

**Ejemplo básico:**

```csharp
public void Saludar()
{
    Console.WriteLine("¡Hola!");
}
```

## Métodos Estáticos

Un **método estático** pertenece a la clase y no a una instancia específica. Se invoca usando el nombre de la clase, no de un objeto. Son útiles para operaciones que no dependen de los datos de una instancia.

**Ejemplo:**

```csharp
public static void MostrarInfoGeneral()
{
    Console.WriteLine("Los autos son vehículos que circulan por carreteras.");
}

// Uso:
Car.MostrarInfoGeneral();
```

## Métodos Sobrecargados (Overloads)

La **sobrecarga de métodos** permite definir varios métodos con el mismo nombre pero diferentes parámetros (tipo, número o ambos). Esto facilita el uso de un mismo método para diferentes situaciones.

**Ejemplo:**

```csharp
public void MostrarMensaje()
{
    Console.WriteLine("Este es un auto.");
}

public void MostrarMensaje(string mensaje)
{
    Console.WriteLine(mensaje);
}
```

En el archivo `Methods.cs` se ejemplifican estos conceptos con la clase `Car`, que tiene métodos normales, estáticos y sobrecargados.

## Destructores (~)

Un **destructor** en C# es un método especial que se define usando el símbolo `~` seguido del nombre de la clase. Se ejecuta automáticamente cuando el recolector de basura elimina un objeto de la memoria. Su propósito principal es liberar recursos no administrados (como archivos, conexiones, etc.) antes de que el objeto sea destruido.

**Ejemplo:**

```csharp
~Car()
{
    Console.WriteLine("Car object is being destroyed.");
}
```

### Pros

- Permite liberar recursos no administrados automáticamente.
- Útil para registrar o limpiar acciones al destruir un objeto.

### Contras

- No se puede controlar exactamente cuándo se ejecuta el destructor (depende del recolector de basura).
- Puede afectar el rendimiento si se abusa de ellos.
- No se recomienda para liberar recursos administrados (usar `IDisposable` y `Dispose()` en su lugar).

**Nota:** En la mayoría de los casos modernos, es preferible implementar la interfaz `IDisposable` para liberar recursos de manera más predecible.

**Resumen:**

- Un método es una función dentro de una clase.
- Los métodos estáticos se llaman desde la clase, no desde un objeto.
- Los métodos sobrecargados permiten múltiples versiones de un método con diferentes parámetros.
