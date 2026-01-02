# Documentación: Interfaces en C#

## ¿Qué es una interface?

Una **interface** en C# es un contrato que define un conjunto de métodos, propiedades, eventos o indexadores que una clase o struct debe implementar. Las interfaces no contienen implementación, solo la firma de los miembros. Permiten definir comportamientos comunes que pueden ser compartidos por diferentes clases, sin importar su posición en la jerarquía de herencia.

### Características principales:

- No se pueden instanciar directamente.
- No contienen lógica, solo definiciones.
- Una clase puede implementar múltiples interfaces (a diferencia de la herencia simple de clases).
- Obligan a las clases que las implementan a definir todos sus miembros.

## Ejemplo de uso de interfaces (basado en el contexto de Visibility.cs)

Aunque el archivo `Visibility.cs` no contiene una interface explícita, se puede imaginar cómo se aplicaría una interface en este contexto. Por ejemplo, podríamos definir una interface para personajes que usan la Fuerza:

```csharp
interface IForceUser
{
    void UseForce();
    int PowerLevel { get; set; }
}

class Jedi : IForceUser
{
    // Implementación de UseForce y PowerLevel
}

class Sith : Jedi, IForceUser
{
    // Hereda la implementación de Jedi y puede personalizarla
}
```

En este ejemplo:

- `IForceUser` define el contrato: cualquier clase que implemente esta interface debe tener el método `UseForce()` y la propiedad `PowerLevel`.
- `Jedi` y `Sith` implementan la interface, asegurando que ambos tengan el comportamiento definido por el contrato.

## ¿Por qué usar interfaces?

- **Polimorfismo:** Permiten tratar diferentes clases de manera uniforme si implementan la misma interface.
- **Desacoplamiento:** Facilitan la programación orientada a interfaces, permitiendo cambiar implementaciones sin afectar el resto del código.
- **Flexibilidad:** Una clase puede implementar varias interfaces, combinando diferentes comportamientos.

## Resumen

Las interfaces son fundamentales para definir contratos y comportamientos comunes en C#, promoviendo la reutilización, el desacoplamiento y el polimorfismo en el diseño de software orientado a objetos.
