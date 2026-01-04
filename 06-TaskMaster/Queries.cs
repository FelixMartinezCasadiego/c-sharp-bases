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

    }
}
