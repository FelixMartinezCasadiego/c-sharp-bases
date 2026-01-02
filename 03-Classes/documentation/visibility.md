# Documentación: Modificadores de Visibilidad en C#

## ¿Qué son los modificadores de visibilidad?

Los **modificadores de visibilidad** (o de acceso) en C# determinan desde dónde se puede acceder a los miembros (campos, métodos, propiedades) de una clase. Los más comunes son:

- **public**
- **private**
- **protected**

A continuación, se explica cada uno y cómo se usan en el archivo `Visibility.cs`.

---

## 1. public

- **Descripción:** Permite el acceso desde cualquier parte del código, incluso desde otras clases y ensamblados.
- **Ejemplo en el archivo:**
  - `public string PublicField` en la clase `Jedi`.
  - `public void UseForce()` y `public void RevealSecrets()`.
- **Uso típico:** Para miembros que deben ser accesibles desde cualquier lugar.

---

## 2. private

- **Descripción:** Solo es accesible dentro de la misma clase donde se declara. No puede ser accedido desde clases derivadas ni desde fuera de la clase.
- **Ejemplo en el archivo:**
  - `private readonly string PrivateField` en la clase `Jedi`.
  - `private static void Meditate()`.
- **Uso típico:** Para ocultar detalles internos de implementación que no deben ser visibles fuera de la clase.

---

## 3. protected

- **Descripción:** Es accesible solo dentro de la misma clase y en las clases derivadas (herencia), pero no desde fuera de ellas.
- **Ejemplo en el archivo:**
  - `protected string ProtectedField` en la clase `Jedi`.
  - `protected static void Train()`.
  - Acceso a `ProtectedField` y `Train()` desde la clase `Sith`, que hereda de `Jedi`.
- **Uso típico:** Para permitir que las subclases accedan a ciertos miembros, pero mantenerlos ocultos para el resto del código.

---

## Resumen del archivo `Visibility.cs`

El archivo muestra cómo los diferentes modificadores de visibilidad afectan el acceso a los campos y métodos de la clase `Jedi`:

- Los campos y métodos `public` pueden ser accedidos desde cualquier parte.
- Los campos y métodos `private` solo pueden ser usados dentro de la propia clase `Jedi`.
- Los campos y métodos `protected` pueden ser usados dentro de `Jedi` y cualquier clase que herede de ella, como `Sith`.

Esto ayuda a controlar la encapsulación y la seguridad del código, permitiendo exponer solo lo necesario y ocultar los detalles internos.
