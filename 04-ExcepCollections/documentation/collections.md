# Documentación: Tipos de Colecciones en C#

En C#, las colecciones permiten almacenar, organizar y manipular conjuntos de datos de manera eficiente. A continuación se describen los tipos de colecciones más comunes y sus usos principales:

| Tipo de colección            | Descripción                                           | Usos comunes                                                                                                             |
| ---------------------------- | ----------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------ |
| **List<T>**                  | Lista dinámica de elementos.                          | Almacenar y manipular listas de datos ordenados, como una lista de nombres o productos.                                  |
| **Dictionary<TKey, TValue>** | Almacena pares clave-valor.                           | Búsqueda rápida de valores por clave, como un diccionario de configuraciones o un mapeo de nombres a edades.             |
| **HashSet<T>**               | Conjunto de elementos únicos.                         | Almacenar elementos sin duplicados, como una lista de identificadores únicos o palabras en un diccionario.               |
| **Queue<T>**                 | Colección FIFO (primero en entrar, primero en salir). | Procesar elementos en orden de llegada, como tareas en una cola de impresión.                                            |
| **Stack<T>**                 | Colección LIFO (último en entrar, primero en salir).  | Gestionar operaciones reversibles, como el historial de acciones o deshacer/rehacer.                                     |
| **SortedList<TKey, TValue>** | Lista ordenada de pares clave-valor.                  | Almacenar datos que requieren acceso rápido y ordenado por clave.                                                        |
| **LinkedList<T>**            | Lista doblemente enlazada.                            | Insertar y eliminar elementos eficientemente en cualquier posición de la lista.                                          |
| **ObservableCollection<T>**  | Lista que notifica cambios.                           | Escenarios donde se requiere notificar a la interfaz de usuario sobre cambios en la colección, como en aplicaciones WPF. |

## Resumen de los tipos principales

- **List<T>:** Para listas ordenadas y dinámicas.
- **Dictionary<TKey, TValue>:** Para búsquedas rápidas por clave.
- **HashSet<T>:** Para conjuntos sin duplicados.
- **Queue<T> y Stack<T>:** Para estructuras de datos con orden de procesamiento específico.
- **SortedList<TKey, TValue> y LinkedList<T>:** Para necesidades de ordenamiento o inserciones/eliminaciones frecuentes.
- **ObservableCollection<T>:** Para colecciones que deben notificar cambios.

Estas colecciones forman parte del espacio de nombres `System.Collections.Generic` y son ampliamente utilizadas en el desarrollo de aplicaciones C#.
