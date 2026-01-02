# Documentación: Manejo de Archivos en C# (`FileExample.cs`)

## ¿Qué es File en C#?

En C#, la clase `File` forma parte del espacio de nombres `System.IO` y proporciona métodos estáticos para crear, copiar, eliminar, mover y abrir archivos, así como para leer y escribir en ellos. Es una herramienta fundamental para la manipulación de archivos en disco.

## Operaciones comunes con la clase File

- **Crear archivos:** `File.Create(path)`
- **Leer archivos:** `File.ReadAllText(path)`, `File.ReadAllLines(path)`
- **Escribir archivos:** `File.WriteAllText(path)`, `File.WriteAllLines(path)`
- **Copiar archivos:** `File.Copy(sourcePath, destPath)`
- **Eliminar archivos:** `File.Delete(path)`
- **Verificar existencia:** `File.Exists(path)`

## ¿Cuándo usar la clase File?

Utiliza la clase `File` cuando necesitas realizar operaciones directas sobre archivos, como guardar datos, leer configuraciones, procesar información almacenada en disco, o manipular archivos en general.

## Ejemplo básico de uso

```csharp
string path = "datos.txt";
// Escribir texto en un archivo
File.WriteAllText(path, "Hola, mundo!");
// Leer texto de un archivo
string contenido = File.ReadAllText(path);
```

## Recomendaciones

- Siempre verifica si el archivo existe antes de leer o eliminar usando `File.Exists(path)`.
- Maneja excepciones como `IOException` y `UnauthorizedAccessException` para evitar errores inesperados.
- Prefiere rutas absolutas para evitar confusiones con la ubicación de los archivos.
- Para operaciones avanzadas, considera otras clases como `FileStream`, `StreamReader` y `StreamWriter`.

## Resumen

La clase `File` en C# simplifica la manipulación de archivos mediante métodos estáticos fáciles de usar. Es ideal para tareas comunes de lectura, escritura y gestión de archivos en aplicaciones de consola, escritorio o servicios.
