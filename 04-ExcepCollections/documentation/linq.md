# Documentación: LINQ en C# (`Linq.cs`)

## ¿Qué es LINQ?

LINQ (Language Integrated Query) es una característica de C# que permite realizar consultas a colecciones de datos (como listas, arreglos, bases de datos, XML, etc.) utilizando una sintaxis declarativa similar a SQL, integrada directamente en el lenguaje.

## ¿Cuándo usar LINQ?

- Cuando necesitas filtrar, ordenar, agrupar o transformar datos de colecciones de manera sencilla y legible.
- Para evitar bucles anidados y código imperativo complejo al manipular datos.
- Cuando trabajas con fuentes de datos como listas, arrays, diccionarios, bases de datos (LINQ to SQL/Entities), XML, etc.

## Ventajas de LINQ

- Sintaxis clara y concisa para manipular datos.
- Permite escribir consultas complejas de forma legible y mantenible.
- Compatible con múltiples fuentes de datos.
- Facilita la transformación y proyección de datos.

## Ejemplos de uso y formas de filtrar datos con LINQ

LINQ permite realizar consultas sobre colecciones utilizando dos sintaxis principales: **sintaxis de consulta** y **sintaxis de métodos**.

### Filtrar números pares

**Imperativo tradicional:**

```csharp
List<int> numbers = new() { 1,2,3,4,5,6,7,8,9,10 };
List<int> evenNumbers = new();
foreach (var number in numbers)
{
	if (number % 2 == 0)
		evenNumbers.Add(number);
}
```

**Sintaxis de consulta LINQ:**

```csharp
var evenNumbersQuery = from num in numbers
					   where num % 2 == 0
					   select num;
```

**Sintaxis de métodos LINQ:**

```csharp
var evenNumbersMethod = numbers.Where(num => num % 2 == 0);
```

### Consultas sobre objetos

Supongamos una lista de personajes:

```csharp
List<MarvelCharacter> characters = new()
{
	new MarvelCharacter { Name = "Peter Parker", Alias = "Spider-Man", Team = "Avengers" },
	new MarvelCharacter { Name = "Tony Stark", Alias = "Iron Man", Team = "Avengers" },
	// ...otros personajes
};
```

**Filtrar por equipo (Avengers):**

```csharp
// Sintaxis de consulta
var avengersQuery = from character in characters
					where character.Team == "Avengers"
					select $"{character.Alias} ({character.Name})";

// Sintaxis de métodos
var avengersMethods = characters.Where(c => c.Team == "Avengers")
							   .Select(c => $"{c.Alias} ({c.Name})");
```

**Ordenar y proyectar nombres:**

```csharp
var sortedQuery = from c in characters
				  orderby c.Name descending
				  select c.Name;

var sortedMethod = characters.OrderByDescending(c => c.Name).Select(c => c.Name);
```

**Tomar los primeros 3 elementos:**

```csharp
var firstThreeQuery = (from c in characters select c).Take(3);
var firstThreeMethods = characters.Take(3);
```

Estos ejemplos muestran cómo LINQ facilita la obtención de información filtrada, ordenada y proyectada de diferentes maneras, mejorando la legibilidad y reduciendo la cantidad de código necesario.

## Recomendaciones al usar LINQ

- Prefiere LINQ para operaciones de filtrado, ordenamiento, agrupamiento y transformación de datos sobre colecciones.
- Utiliza expresiones lambda para mayor claridad y flexibilidad.
- Recuerda que LINQ no modifica la colección original, sino que devuelve una nueva colección con los resultados.
- Para grandes volúmenes de datos, evalúa el impacto en el rendimiento y considera el uso de métodos como `ToList()` o `ToArray()` para materializar los resultados si es necesario.
- Usa LINQ to Objects para colecciones en memoria y LINQ to Entities/SQL para bases de datos.

## Resumen

LINQ es una herramienta poderosa y flexible para consultar y manipular datos en C#. Su uso adecuado mejora la legibilidad, mantenibilidad y eficiencia del código al trabajar con colecciones y fuentes de datos diversas.

documentacion de metodos de LINQ Oficial: https://learn.microsoft.com/es-mx/dotnet/framework/data/adonet/ef/language-reference/supported-and-unsupported-linq-methods-linq-to-entities
