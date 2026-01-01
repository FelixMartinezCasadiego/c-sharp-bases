# Documentación de Properties.cs

Este archivo muestra el uso de **propiedades** en C#, incluyendo propiedades automáticas, de solo lectura y con lógica personalizada en el método set.

## Clases Definidas

### Animal

- **Definición:**

  ```csharp
  class Animal(string habitat)
  ```

  Utiliza un **constructor primario** para inicializar la propiedad `Habitat`.

- **Propiedades:**

  - `Species` (string): Propiedad automática con valor por defecto "Unknown". Puede ser leída y modificada.
  - `Category` (string): Propiedad de solo lectura, inicializada como "Vertebrate".
  - `Age` (int): Propiedad con lógica personalizada en el set. Lanza una excepción si el valor es negativo.
  - `Habitat` (string): Propiedad de solo lectura, inicializada desde el constructor primario.

- **Ejemplo de uso:**
  En el método `Properties` de la clase parcial `Program`:
  ```csharp
  Animal lion = new("Savannah")
  {
      Species = "Lion",
      Age = 5
  };
  WriteLine($"Species: {lion.Species}, Category: {lion.Category}, Age: {lion.Age}, Habitat: {lion.Habitat}");
  ```
  Se crea un objeto `Animal`, se asignan valores a sus propiedades y se imprime su información.

## Conceptos demostrados

- **Propiedades automáticas**: Permiten definir getters y setters de forma concisa.
- **Propiedades de solo lectura**: Solo tienen getter y se inicializan en el constructor o inline.
- **Propiedades con lógica personalizada**: El setter de `Age` valida que el valor no sea negativo.
- **Inicialización de objetos**: Uso de inicializadores de objetos para asignar valores a las propiedades tras la creación.
- **Constructor primario**: Uso de parámetros en la declaración de la clase para inicializar propiedades.

---

**Ubicación:** 03-Classes/Properties.cs
