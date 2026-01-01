# Herencia en C#

## ¿Qué es la herencia?

La **herencia** es un principio fundamental de la programación orientada a objetos (OOP) que permite crear una nueva clase (llamada clase derivada o hija) a partir de una clase existente (llamada clase base o padre). La clase derivada hereda los miembros (propiedades, métodos, etc.) de la clase base y puede agregar o modificar funcionalidades.

**Ejemplo básico:**

```csharp
class Animal
{
    public void Comer() => Console.WriteLine("El animal come.");
}

class Perro : Animal
{
    public void Ladrar() => Console.WriteLine("El perro ladra.");
}
```

En este ejemplo, `Perro` hereda el método `Comer` de `Animal` y agrega su propio método `Ladrar`.

## Objetivos de la herencia

## ¿Qué es el polimorfismo?

El **polimorfismo** es la capacidad de que diferentes clases derivadas respondan de manera distinta a un mismo método definido en la clase base. Esto se logra usando métodos virtuales y override.

**Ejemplo usando el archivo Inheritance.cs:**

```csharp
class Character
{
    public string? Name { get; set; }
    public virtual void Greet()
    {
        Console.WriteLine($"Hello, I am a {Name} character.");
    }
}

class HogartsStudent : Character
{
    public override void Greet()
    {
        Console.WriteLine($"Hello, I am a student named {Name}.");
    }
}

class HogartsProfessor : Character
{
    public override void Greet()
    {
        Console.WriteLine($"Hello, I am a professor named {Name}.");
    }
}

// Polimorfismo en acción:
Character person1 = new HogartsStudent { Name = "Harry" };
Character person2 = new HogartsProfessor { Name = "Snape" };
person1.Greet(); // Llama al método Greet de HogartsStudent
person2.Greet(); // Llama al método Greet de HogartsProfessor
```

**Ventaja:** Puedes tratar diferentes tipos de personajes como si fueran del mismo tipo base (`Character`), pero cada uno responde con su propio saludo. Esto hace el código más flexible y fácil de extender.

## Resumen

La herencia ayuda a crear estructuras de código más limpias, reutilizables y fáciles de mantener, aprovechando las relaciones naturales entre objetos en el mundo real.
