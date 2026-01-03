# Documentación: ManageJsonFile.cs

## ¿Qué es un JSON?

JSON (JavaScript Object Notation) es un formato ligero de intercambio de datos, fácil de leer y escribir para humanos y sencillo de analizar y generar para las máquinas. Se utiliza ampliamente para almacenar y transferir datos estructurados, especialmente en aplicaciones web y APIs.

Ejemplo de un objeto JSON:

```json
{
  "Id": 1,
  "Name": "Peter Parker",
  "Alias": "Spider",
  "Team": "Avengers"
}
```

## Serialización y deserialización en C#

En C#, la serialización es el proceso de convertir un objeto en una cadena JSON. La deserialización es el proceso inverso: convertir una cadena JSON en un objeto C#.

La clase principal para trabajar con JSON en C# es `System.Text.Json.JsonSerializer`.

### Métodos más comunes de `JsonSerializer`

- `Serialize(obj)`: Convierte un objeto C# a una cadena JSON.
- `Serialize(obj, options)`: Igual que el anterior, pero permite personalizar la salida (por ejemplo, formato legible o manejo de caracteres especiales).
- `Deserialize<T>(json)`: Convierte una cadena JSON a un objeto del tipo especificado.

## Explicación del archivo ManageJsonFile.cs

Este archivo muestra cómo serializar una lista de objetos a JSON, guardar el resultado en un archivo, leerlo y deserializarlo de nuevo a objetos C#.

### Pasos principales del código

1. **Definición de la clase Character:**
   - Representa la estructura de los datos que se almacenarán en JSON.
2. **Creación de una lista de personajes:**
   - Se crea una lista de objetos `Character` con datos de ejemplo.
3. **Serialización a JSON:**
   - `JsonSerializer.Serialize(characters, options)` convierte la lista a una cadena JSON con formato legible y sin escapar caracteres Unicode.
4. **Guardar el JSON en un archivo:**
   - `File.WriteAllText` escribe la cadena JSON en un archivo.
5. **Lectura del archivo JSON:**
   - `File.ReadAllText` lee el contenido del archivo JSON.
6. **Deserialización desde JSON:**
   - `JsonSerializer.Deserialize<List<Character>>(characterFromFile)` convierte la cadena JSON de vuelta a una lista de objetos `Character`.
7. **Impresión de los datos:**
   - Se recorre la lista deserializada y se imprime cada personaje.

### Fragmento clave del código

```csharp
var charactersJson = JsonSerializer.Serialize(characters, new JsonSerializerOptions { WriteIndented = true, Encoder= System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping });
File.WriteAllText("./05-Files/characters.json", charactersJson);

var characterFromFile = File.ReadAllText("./05-Files/characters.json");
var charactersFromJson = JsonSerializer.Deserialize<List<Character>>(characterFromFile);
```

## Resumen

- **JSON** es un formato estándar para almacenar y transferir datos.
- En C#, la clase `JsonSerializer` permite serializar (convertir objetos a JSON) y deserializar (convertir JSON a objetos) de forma sencilla.
- El ejemplo muestra cómo guardar y recuperar datos estructurados usando JSON y archivos de texto.
