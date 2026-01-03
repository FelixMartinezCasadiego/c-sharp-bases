# Documentación: DirectoryExample.cs

## ¿Qué es un directorio en C#?

En C#, un **directorio** es una estructura del sistema de archivos que permite organizar archivos y otros directorios (subdirectorios) de manera jerárquica. Los directorios ayudan a mantener los archivos ordenados y facilitan su acceso y gestión dentro de una aplicación.

La clase principal para trabajar con directorios en C# es `System.IO.Directory`. Esta clase proporciona métodos estáticos para crear, mover, eliminar y consultar directorios.

## Explicación del archivo DirectoryExample.cs

El archivo `DirectoryExample.cs` contiene un ejemplo práctico de cómo crear y eliminar un directorio usando C#.

### Código principal

```csharp
static void DirectoryExample()
{
    var directoryPath = "./05-Files/";
    Directory.CreateDirectory($"{directoryPath}/DirExample");

    if (Directory.Exists($"{directoryPath}/DirExample"))
    {
        WriteLine("The directory was created successfully.");
    }

    Directory.Delete($"{directoryPath}/DirExample", recursive: true);
}
```

### Explicación paso a paso

1. **Definir la ruta del directorio:**
   - Se establece la ruta base donde se creará el nuevo directorio.
2. **Crear un directorio:**
   - `Directory.CreateDirectory` crea un directorio llamado `DirExample` dentro de la ruta especificada. Si el directorio ya existe, no ocurre ningún error.
3. **Verificar si el directorio existe:**
   - `Directory.Exists` comprueba si el directorio fue creado correctamente.
   - Si existe, se muestra un mensaje de éxito.
4. **Eliminar el directorio:**
   - `Directory.Delete` elimina el directorio creado. El parámetro `recursive: true` indica que, si el directorio contiene archivos o subdirectorios, también serán eliminados.

### Métodos útiles de la clase Directory

- `CreateDirectory(path)`: Crea un nuevo directorio.
- `Exists(path)`: Verifica si un directorio existe.
- `Delete(path, recursive)`: Elimina un directorio, con opción recursiva.
- `GetFiles(path)`: Obtiene los archivos de un directorio.
- `GetDirectories(path)`: Obtiene los subdirectorios de un directorio.

## Resumen

Trabajar con directorios en C# es sencillo gracias a la clase `Directory`. Permite crear, verificar y eliminar carpetas de forma eficiente, facilitando la organización de archivos en las aplicaciones.
