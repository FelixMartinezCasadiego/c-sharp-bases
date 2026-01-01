# Documentación de TestingClasses.cs

Este archivo contiene ejemplos de definición y uso de clases en C# utilizando constructores primarios y propiedades automáticas.

## ¿Qué es una clase?

Una **clase** en C# es una plantilla o modelo que define las características (propiedades) y comportamientos (métodos) de un objeto. Permite crear múltiples instancias (objetos) con los mismos atributos y funcionalidades.

## ¿Qué es un constructor primario?

Un **constructor primario** es una característica introducida en C# 12 que permite definir los parámetros del constructor directamente en la declaración de la clase. Esto simplifica la inicialización de propiedades y reduce el código repetitivo.

**Ejemplo con constructor primario:**

```csharp
class Vehicle(string brand, string model, int year)
{
  public string? Brand { get; set; } = brand;
  public string? Model { get; set; } = model;
  public int Year { get; set; } = year;
}
```

## ¿Cómo se hacía antes sin constructor primario?

Antes de C# 12, los constructores se definían explícitamente dentro del cuerpo de la clase. Por ejemplo:

```csharp
class Vehicle
{
  public string? Brand { get; set; }
  public string? Model { get; set; }
  public int Year { get; set; }

  public Vehicle(string brand, string model, int year)
  {
    Brand = brand;
    Model = model;
    Year = year;
  }
}
```

Esto requería más líneas de código y era más propenso a errores de inicialización.

## Clases Definidas

### Vehicle

- **Definición:**

  ```csharp
  class Vehicle(string brand, string model, int year)
  ```

  Utiliza un **constructor primario** para inicializar las propiedades.

- **Propiedades:**

  - `Brand` (string?): Marca del vehículo.
  - `Model` (string?): Modelo del vehículo.
  - `Year` (int): Año del vehículo.

- **Métodos:**
  - `ShowInfo()`: Muestra la información del vehículo en consola usando interpolación de cadenas.

### Uso de la clase

En el método `TestingClass` de la clase parcial `Program`:

```csharp
static void TestingClass()
{
    Vehicle toyota = new("Toyota", "Corolla", 2020);
    toyota.ShowInfo();
}
```

- Se crea una instancia de `Vehicle` y se llama al método `ShowInfo` para mostrar sus datos.

## Conceptos demostrados

- **Constructores primarios** (C# 12+)
- **Propiedades automáticas**
- **Métodos de instancia**
- **Interpolación de cadenas**

---

**Ubicación:** 03-Classes/TestingClasses.cs
