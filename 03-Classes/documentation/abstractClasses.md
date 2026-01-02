# Documentación: Uso de Clases Abstractas en C#

## ¿Qué es una clase abstracta?

Una **clase abstracta** en C# es una clase que no puede ser instanciada directamente. Sirve como una plantilla para otras clases y puede contener métodos con o sin implementación. Los métodos sin implementación se denominan **métodos abstractos** y deben ser implementados obligatoriamente por las clases derivadas.

### Características principales:

- No se puede crear un objeto directamente de una clase abstracta.
- Puede contener métodos abstractos (sin cuerpo) y métodos concretos (con cuerpo).
- Obliga a las clases hijas a implementar los métodos abstractos.

## ¿Por qué se usan las clases abstractas?

Las clases abstractas se utilizan para definir una estructura común para un grupo de clases relacionadas, asegurando que todas las clases derivadas implementen ciertos comportamientos. Son útiles cuando se quiere compartir código base y, al mismo tiempo, forzar la implementación de métodos específicos en las subclases.

## Ejemplo en el archivo `AbstracClassExamles.cs`

En el archivo, se define la clase abstracta `HomeAppliance` que representa un electrodoméstico genérico. Esta clase tiene:

- Una propiedad `Brand` (marca).
- Un método abstracto `TurnOn()` que debe ser implementado por cada electrodoméstico específico.
- Un método concreto `ShowBrand()` que muestra la marca del electrodoméstico.

Luego, se crean dos clases que heredan de `HomeAppliance`:

- `WashingMachine` (lavadora)
- `Microwave` (microondas)

Ambas implementan el método `TurnOn()` de manera diferente, mostrando un mensaje específico para cada tipo de electrodoméstico.

### Ventajas de este enfoque

- **Reutilización de código:** El método `ShowBrand()` se define una sola vez y es compartido por todas las subclases.
- **Consistencia:** Todas las subclases deben implementar el método `TurnOn()`, asegurando que cada electrodoméstico tenga una forma de encenderse.

## Resumen

Las clases abstractas permiten definir comportamientos comunes y forzar la implementación de métodos clave en las subclases, facilitando la organización y el mantenimiento del código en aplicaciones orientadas a objetos.
