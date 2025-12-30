# Documentación: Simplified Console Usings en HelloApp.csproj

En el archivo `HelloApp.csproj` se ha implementado la siguiente sección:

```xml
<ItemGroup Label="Simplified Console Usings">
    <Using Include="System.Console" Static="true" />
</ItemGroup>
```

## ¿Qué significa esto?

Esta configuración permite que todos los archivos del proyecto puedan usar los métodos estáticos de la clase `System.Console` (como `WriteLine`, `ReadLine`, etc.) sin necesidad de escribir `Console.` antes de cada método.

### Ejemplo antes:

```csharp
Console.WriteLine("Hola mundo");
```

### Ejemplo después:

```csharp
WriteLine("Hola mundo");
```

## Ventajas

- Hace el código más limpio y legible.
- Reduce la repetición de `Console.` en todo el proyecto.
- Es útil en proyectos educativos o de ejemplo donde se usa mucho la consola.

## ¿Cómo funciona?

La línea `<Using Include="System.Console" Static="true" />` agrega un using global y estático para `System.Console`, habilitando el acceso directo a sus métodos en todo el proyecto.

---

Esta característica es posible gracias a las capacidades de usings globales y estáticos introducidas en versiones recientes de C# y .NET.
