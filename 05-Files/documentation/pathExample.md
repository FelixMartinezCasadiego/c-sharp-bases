# Documentación: PathExample.cs

## ¿Qué es `Path` en C#?

En C#, la clase `System.IO.Path` proporciona métodos estáticos para trabajar con cadenas que contienen información de rutas de archivos y directorios. Permite manipular, combinar, analizar y extraer partes de rutas de manera segura y multiplataforma, sin acceder directamente al sistema de archivos.

## Funcionalidades principales de `Path`

- **Combinar rutas:** Unir varias partes de una ruta de forma segura.
- **Obtener extensiones:** Extraer la extensión de un archivo.
- **Obtener el nombre del archivo o directorio:** Extraer solo el nombre del archivo o carpeta de una ruta completa.
- **Cambiar extensiones:** Modificar la extensión de un archivo.
- **Obtener directorio base:** Extraer la carpeta contenedora de un archivo o subdirectorio.
- **Caracteres inválidos:** Identificar caracteres no permitidos en rutas o nombres de archivos.

## Ejemplo típico de uso (`PathExample.cs`)

```csharp
using System;
using System.IO;

class PathExample
{
    static void Main()
    {
        string folder = "05-Files";
        string file = "Ejemplo.txt";
        string fullPath = Path.Combine(folder, file);
        Console.WriteLine($"Ruta combinada: {fullPath}");

        string extension = Path.GetExtension(fullPath);
        Console.WriteLine($"Extensión: {extension}");

        string fileName = Path.GetFileName(fullPath);
        Console.WriteLine($"Nombre del archivo: {fileName}");

        string directory = Path.GetDirectoryName(fullPath);
        Console.WriteLine($"Directorio: {directory}");
    }
}
```

### Explicación del ejemplo

1. **Path.Combine:** Une de forma segura el nombre de la carpeta y el archivo, evitando errores de separadores.
2. **Path.GetExtension:** Obtiene la extensión del archivo (por ejemplo, `.txt`).
3. **Path.GetFileName:** Extrae solo el nombre del archivo de la ruta completa.
4. **Path.GetDirectoryName:** Obtiene la ruta de la carpeta que contiene el archivo.

## Métodos útiles de la clase `Path`

- `Path.Combine(params string[])`: Combina partes de una ruta.
- `Path.GetExtension(string)`: Devuelve la extensión de un archivo.
- `Path.GetFileName(string)`: Devuelve el nombre del archivo.
- `Path.GetDirectoryName(string)`: Devuelve la carpeta contenedora.
- `Path.ChangeExtension(string, string)`: Cambia la extensión de un archivo.
- `Path.GetInvalidPathChars()`: Devuelve los caracteres no válidos para rutas.

## Resumen

La clase `Path` es fundamental para manipular rutas de archivos y directorios en C#, permitiendo escribir código seguro, limpio y multiplataforma sin preocuparse por los detalles del sistema operativo.
