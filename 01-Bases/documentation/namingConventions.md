# Naming Conventions in C#

| Element  | Convention |
| -------- | ---------- |
| Variable | camelCase  |
| Method   | PascalCase |
| Class    | PascalCase |

# Tipos de Valor y Referencia en .NET

| Tipo           | Ejemplos                                                  | Características principales                                                                                                                                                                                    |
| -------------- | --------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Valor**      | (Primitivos como: int, double, bool, ... ) y struct, enum | Se almacenan directamente en la pila (stack). Cada variable tiene su propia copia del dato (Copias independientes).                                                                                            |
| **Referencia** | string, object, arrays, class                             | Se almacenan en el heap (en el monton de memoria). Las variables almacenan una referencia (puntero) al objeto real. Varias variables pueden apuntar al mismo objeto, y si se modifica el objeto, todos lo ven. |

**Notas:**

- Los tipos de valor contienen directamente sus datos. Al asignar uno a otra variable, se copia el valor.
- Los tipos de referencia almacenan una referencia al objeto. Al asignar uno a otra variable, ambas apuntan al mismo objeto en memoria.

**Ejemplo sencillo:**
Puedes ver un ejemplo práctico de la diferencia entre tipos de valor y referencia en el archivo TypeDifference.cs.
