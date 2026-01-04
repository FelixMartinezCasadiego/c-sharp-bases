# Cómo agregar paquetes en C# usando NuGet

NuGet es el sistema de gestión de paquetes para proyectos .NET y C#. Permite agregar, actualizar y eliminar bibliotecas externas de manera sencilla.

## 1. Usando la línea de comandos (CLI)

**¿Qué es CLI?**
CLI significa "Command Line Interface" o "Interfaz de Línea de Comandos". Es una forma de interactuar con el sistema operativo o herramientas como .NET mediante comandos escritos en la terminal o consola, en lugar de usar una interfaz gráfica. Por ejemplo, los comandos que empiezan con `dotnet` se ejecutan en la terminal.

### a) Instalar un paquete

Abre una terminal en la raíz de tu proyecto y ejecuta:

```
dotnet add package <NombreDelPaquete>
```

Por ejemplo, para instalar Newtonsoft.Json:

```
dotnet add package Newtonsoft.Json
```

### b) Listar paquetes instalados

```
dotnet list package
```

### c) Actualizar un paquete

```
dotnet add package <NombreDelPaquete> --version <VersiónNueva>
```

O usa:

```
dotnet list package --outdated
```

## 2. Usando Visual Studio

1. Haz clic derecho sobre el proyecto en el Explorador de soluciones.
2. Selecciona "Administrar paquetes NuGet".
3. Busca el paquete que deseas instalar.
4. Haz clic en "Instalar".

## 3. Archivos involucrados

- El archivo `.csproj` de tu proyecto se actualizará automáticamente para incluir el paquete.

## 4. Recursos útiles

- [Documentación oficial de NuGet](https://learn.microsoft.com/es-es/nuget/)
- [Comandos de la CLI de dotnet](https://learn.microsoft.com/es-es/dotnet/core/tools/dotnet-add-package)
- [Pagina oficial de NuGet](https://www.nuget.org/)

---

> **Nota:** Siempre revisa la compatibilidad del paquete con la versión de .NET que usas.
