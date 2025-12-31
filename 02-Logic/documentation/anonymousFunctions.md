# Funciones Anónimas y Lambdas en C#

## ¿Qué es una función anónima?

Una **función anónima** es una función que no tiene nombre y se define directamente en el lugar donde se necesita, generalmente para ser asignada a un delegado o pasada como argumento a otro método. Son útiles para operaciones simples y temporales, evitando la necesidad de declarar un método separado.

Ejemplo en el archivo `AnonymousFunctions.cs`:

```csharp
static readonly Func<int, int> square = delegate (int number)
{
    return number * number;
};
```

## ¿Qué es una expresión lambda?

Una **lambda** es una forma concisa de escribir funciones anónimas usando la sintaxis `=>`. Permite definir funciones de manera más compacta y legible, especialmente útil en operaciones con colecciones y delegados.

Ejemplo en el archivo:

```csharp
static readonly Func<int,int> lambdSquare = x => x * x;
```

## Diferencia entre función y método

- **Función:** Es un bloque de código que realiza una tarea y puede devolver un valor. En C#, las funciones suelen estar asociadas a clases, pero el término se usa para referirse a cualquier bloque reutilizable de código que puede ser llamado.
- **Método:** Es una función que está definida dentro de una clase o estructura. En C#, todos los métodos son funciones, pero no todas las funciones son necesariamente métodos (por ejemplo, funciones locales o anónimas).

En resumen, en C# la diferencia principal es que un método siempre pertenece a una clase o estructura, mientras que una función puede ser cualquier bloque de código reutilizable, incluyendo métodos, funciones anónimas y lambdas.

## Resumen del archivo `AnonymousFunctions.cs`

Este archivo muestra cómo declarar y utilizar funciones anónimas y expresiones lambda en C#, asignándolas a delegados para su uso posterior.

## ¿Qué es un delegate? (Explicación sencilla)

Un **delegate** en C# es como una variable que puede guardar una función. Así, puedes pasar funciones como si fueran datos, guardarlas en variables o enviarlas a otros métodos.

Por ejemplo:

Imagina que tienes una caja (delegate) donde puedes guardar una función que suma dos números. Luego, puedes usar esa caja para llamar a la función cuando la necesites.

Esto permite que tu código sea más flexible, porque puedes cambiar qué función usas en cada momento, solo cambiando lo que guardas en el delegate.

Ejemplo concreto:

```csharp
delegate int Operacion(int a, int b);
Operacion suma = (a, b) => a + b;
int resultado = suma(2, 3); // resultado = 5
```

**delegate** int Operacion(int a, int b); no es una variable, es una declaración de un tipo, parecido a cómo defines una clase o una interfaz. Aquí defines un "molde" para funciones que reciben dos int y devuelven un int.

Luego, cuando escribes:
Operacion suma = (a, b) => a + b;

estás creando una variable llamada suma de ese tipo delegate, y le asignas una función lambda (anónima) que suma dos números. Así, suma es una variable que guarda una función lambda compatible con el delegate Operacion.

El tipo Operacion solo puede usarse en el archivo (o ámbito) donde fue declarado. Si lo declaras dentro de un archivo o clase, solo estará disponible ahí.
