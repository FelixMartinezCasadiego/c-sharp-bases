# Documentación: Manejo de Excepciones en C# (`HandleException.cs`)

## ¿Qué es una excepción?

Una **excepción** es un evento que ocurre durante la ejecución de un programa y que interrumpe el flujo normal de las instrucciones. Las excepciones suelen indicar errores o condiciones inesperadas, como dividir por cero o ingresar datos en un formato incorrecto.

## ¿Por qué manejar excepciones?

El manejo de excepciones permite que el programa responda de manera controlada ante errores, evitando que se detenga abruptamente y mostrando mensajes útiles al usuario.

## Estructura del manejo de excepciones en C#

Se utiliza el bloque `try-catch`:

- **try:** Contiene el código que puede generar una excepción.
- **catch:** Captura y maneja la excepción si ocurre.
- **finally (opcional):** Se ejecuta siempre, ocurra o no una excepción.

## Explicación del archivo `HandleException.cs`

En este archivo se muestra cómo manejar diferentes tipos de excepciones al intentar convertir una entrada de usuario a número:

- Se solicita al usuario un número para dividir 10.
- Se intenta convertir la entrada a un valor numérico (`double.Parse`).
- Se manejan varias excepciones específicas:
  - **DivideByZeroException:** Ocurre si se intenta dividir por cero (comentado en el ejemplo).
  - **FormatException:** Ocurre si la entrada no es un número válido. Además, se usa una condición para mostrar un mensaje especial si el usuario incluye el símbolo `$`.
  - **Exception:** Captura cualquier otra excepción no prevista, mostrando el mensaje de error.

### Ejemplo de código relevante:

```csharp
try
{
    // Código que puede fallar
}
catch (DivideByZeroException)
{
    // Manejo específico para división por cero
}
catch (FormatException) when (amount?.Contains('$') == true)
{
    // Manejo específico si la entrada contiene '$'
}
catch (Exception ex)
{
    // Manejo general para cualquier otro error
}
```

## Ventajas de este enfoque

- Permite mostrar mensajes claros y personalizados según el tipo de error.
- Evita que el programa termine inesperadamente.
- Mejora la experiencia del usuario y la robustez del código.

## Resumen

El manejo de excepciones es fundamental para crear aplicaciones seguras y confiables. El archivo `HandleException.cs` ejemplifica cómo capturar y tratar distintos errores de entrada de usuario en C# de manera efectiva.
