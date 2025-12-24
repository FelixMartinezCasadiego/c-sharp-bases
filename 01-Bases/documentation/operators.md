# Documentación: Tipos de Operadores en .NET

En .NET (y C#), los operadores son símbolos que permiten realizar operaciones sobre variables y valores. Se agrupan en varias categorías principales:

## 1. Operadores aritméticos

- `+` Suma
- `-` Resta
- `*` Multiplicación
- `/` División
- `%` Módulo (resto)

## 2. Operadores de asignación

- `=` Asignación
- `+=` Suma y asigna
- `-=` Resta y asigna
- `*=` Multiplica y asigna
- `/=` Divide y asigna
- `%=` Módulo y asigna

## 3. Operadores de comparación

- `==` Igual a
- `!=` Distinto de
- `>` Mayor que
- `<` Menor que
- `>=` Mayor o igual que
- `<=` Menor o igual que

## 4. Operadores lógicos

- `&&` AND lógico
- `||` OR lógico
- `!` NOT lógico o negación

## 5. Operadores de incremento y decremento

- `++` Incrementa en uno
- `--` Decrementa en uno

## 6. Operadores de acceso y null

- `.` Acceso a miembros
- `?.` Acceso condicional (null-safe)
- `??` Coalescencia nula
- `??=` Asignación por coalescencia nula

## 7. Operadores bit a bit

- `&` AND bit a bit
- `|` OR bit a bit
- `^` XOR bit a bit
- `~` NOT bit a bit
- `<<` Desplazamiento a la izquierda
- `>>` Desplazamiento a la derecha

## 8. Operador ternario (condicional)

- `? :` Operador condicional (ternario): Permite evaluar una condición y devolver un valor u otro según el resultado.

**Sintaxis:**

```csharp
condición ? valor_si_verdadero : valor_si_falso;
```

**Ejemplo:**

```csharp
int edad = 18;
string mensaje = (edad >= 18) ? "Mayor de edad" : "Menor de edad";
// mensaje será "Mayor de edad"
```

## 9. Otros operadores útiles

- `is` Comprobación de tipo
- `as` Conversión segura de tipo
- `typeof` Obtiene el tipo
- `sizeof` Obtiene el tamaño en bytes
- `new` Crea una nueva instancia
- `=>` Expresiones lambda
- `[]` Índices y arrays
- `()` Llamada a métodos o agrupación

## Ejemplo de uso

```csharp
int a = 5, b = 2;
int suma = a + b; // 7
bool esIgual = a == b; // false
int? x = null;
int resultado = x ?? 10; // 10
```

Esta lista cubre los operadores más comunes en .NET/C#. Para más detalles, consulta la documentación oficial de C#.
**Ejemplo sencillo:**
Puedes ver un ejemplo práctico de la diferencia entre tipos de valor y referencia en el archivo operators.cs.
