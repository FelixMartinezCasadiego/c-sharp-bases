# Conversions.cs Documentación

Este archivo muestra ejemplos de cómo realizar conversiones de tipos en C#.

## ¿Qué son las conversiones de tipos?

Las conversiones de tipos permiten transformar un valor de un tipo de dato a otro, ya sea de forma implícita, explícita o usando métodos de conversión.

## Ejemplos en el archivo

### Conversión implícita

Ocurre automáticamente cuando no hay riesgo de pérdida de información.

```csharp
int number = 42;
double doubleNumber = number; // Conversión implícita de int a double
```

### Conversión explícita (casting)

Se requiere cuando puede haber pérdida de información.

```csharp
double explicitDoubleNumber = 45.5;
int explicitIntNumber = (int)explicitDoubleNumber; // Conversión explícita de double a int
```

### Métodos Convert y Parse

Permiten convertir cadenas de texto a tipos numéricos y viceversa.

```csharp
string numberString = "123";
int convertedNumber = int.Parse(numberString); // O también: Convert.ToInt32(numberString)
```

### Convertir y redondear números decimales

```csharp
double anotherDecimalNumber = 50.8;
int convertNumber = Convert.ToInt32(anotherDecimalNumber); // Redondea el número
int castedNumber = (int)anotherDecimalNumber; // Trunca la parte decimal
```

## Resumen

Este archivo es útil para aprender cómo convertir entre diferentes tipos de datos en C#, tanto de forma implícita, explícita, como usando métodos de conversión estándar.
