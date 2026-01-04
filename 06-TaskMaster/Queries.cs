using BetterConsoles.Tables; // Requiere instalar el paquete BetterConsoles.Tables
using BetterConsoles.Tables.Configuration; // Requiere instalar el paquete BetterConsoles.Tables

namespace TaskMaster
{
  public class Queries(List<Task> _tasks)
  {
    private readonly List<Task> Tasks = _tasks;
    
    public void ListTasks()
        {
            ForegroundColor = ConsoleColor.DarkBlue;
            WriteLine("------Lista de Tareas------");

            // foreach (var task in Tasks)
            // {
            //     WriteLine("\n{0,-8} {1,-35} {2,-15}","Id", "Descripción", "Completado");
            //     WriteLine(new string('-',58));
            //     WriteLine("\n{0,-8} {1,-35} {2,-15}",task.Id, task.Description, task.Completed);
            // }

            Table  table = new("Id", "Descripción", "Completado");
            foreach (var task in Tasks)
            {
            table.AddRow(task.Id, task.Description, task.Completed ? "Completada" : "Pendiente");
            }
            table.Config = TableConfig.Unicode();

            Write(table.ToString());
            ReadKey();
        }

        public List<Task> AddTask()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("------Agregar Nueva Tarea------");
                Write("Ingrese la descripción de la tarea: ");
                var description = ReadLine()!;
                Task newTask = new(Utils.GenerateId(), description);
                Tasks.Add(newTask);
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea agregada exitosamente.");
                ResetColor();
                return Tasks;
            }
            catch (Exception ex)
            {
                
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error al agregar la tarea: {ex.Message}");
                return Tasks;
            }
        }

        public List<Task> MarkAsCompleted()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("------MMarcar tarea como completada------");
                Write("Ingrese el id de la tarea a marcar como completada: ");
                var id = ReadLine()!;
                
                Task task = Tasks.Find(t => t.Id == id)!;
                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"Error al marcar la tarea como completada: La tarea con id {id} no existe.");ResetColor();
                    return Tasks;
                }

                task.Completed = true;
                task.ModifiedAt = DateTime.Now;
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea marcada como completada exitosamente.");
                ResetColor();
                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error al marcar la tarea como completada: {ex.Message}");
                return Tasks;
            }
        }

        public List<Task> EditTask()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("------Editar tarea------");
                Write("Ingrese el id de la tarea a editar: ");
                var id = ReadLine()!;
                
                Task task = Tasks.Find(t => t.Id == id)!;
                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"Error al editar la tarea: La tarea con id {id} no existe.");ResetColor();
                    return Tasks;
                }

                WriteLine("Ingrese la nueva descripción de la tarea: ");
                var newDescription = ReadLine()!;
                task.Description = newDescription;
                task.ModifiedAt = DateTime.Now;
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea editada exitosamente.");
                ResetColor();
                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error al editar la tarea: {ex.Message}");
                return Tasks;
            }
        }

        public List<Task> RemoveTask()
        {
            try
            {
                ResetColor();
                Clear();
                WriteLine("------Eliminar tarea------");
                Write("Ingrese el id de la tarea a eliminar: ");
                var id = ReadLine()!;
                
                Task task = Tasks.Find(t => t.Id == id)!;
                if (task == null)
                {
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine($"Error al eliminar la tarea: La tarea con id {id} no existe.");ResetColor();
                    return Tasks;
                }

                Tasks.Remove(task);
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Tarea eliminada exitosamente.");
                ResetColor();
                return Tasks;
            }
            catch (Exception ex)
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine($"Error al eliminar la tarea: {ex.Message}");
                return Tasks;
            }
        }

    }
}
