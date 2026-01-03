# Documentación: WriteFileExample.cs

## ¿Qué es `StreamWriter` en C#?

`StreamWriter` es una clase de la biblioteca `System.IO` en C# que permite escribir texto en archivos de manera eficiente. Proporciona métodos para escribir líneas o cadenas completas y es ideal para la manipulación de archivos de texto.

## Uso de `StreamWriter` con el parámetro `append`

El constructor de `StreamWriter` puede recibir un parámetro booleano llamado `append`:

- **append: true** — Si el archivo existe, el texto se agrega al final del archivo (no se borra el contenido anterior).
- **append: false** — Si el archivo existe, el contenido anterior se sobrescribe (se borra y se reemplaza por el nuevo texto).

### Ejemplo de uso

```csharp
using System.IO;

class WriteFileExample
{
    static void Main()
    {
        string path = "05-Files/Ejemplo.txt";
        // Escribir sobrescribiendo el archivo
        using (StreamWriter writer = new StreamWriter(path, append: false))
        {
            writer.WriteLine("Este texto reemplaza el contenido anterior.");
        }

        // Escribir agregando al final del archivo
        using (StreamWriter writer = new StreamWriter(path, append: true))
        {
            writer.WriteLine("Este texto se agrega al final.");
        }
    }
}
```

### Explicación del ejemplo

1. **append: false** — El archivo se abre y su contenido se reemplaza por la nueva línea.
2. **append: true** — El archivo se abre y la nueva línea se agrega al final, conservando el contenido anterior.

## Métodos útiles de `StreamWriter`

- `Write(string)`: Escribe una cadena sin salto de línea.
- `WriteLine(string)`: Escribe una cadena seguida de un salto de línea.
- `Flush()`: Fuerza la escritura de los datos en el archivo.
- `Close()`: Cierra el flujo y libera recursos (se recomienda usar `using` para cerrar automáticamente).

## Resumen

`StreamWriter` es la herramienta recomendada para escribir archivos de texto en C#. El parámetro `append` permite controlar si se sobrescribe el archivo o se agrega contenido al final, facilitando la gestión de archivos según la necesidad de la aplicación.
