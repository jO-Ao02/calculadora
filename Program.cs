// desarrollado por juann
using todoapp.TodoItem;
public class TodoApp
{
    public static void mostrarTareas(List<TodoItem> todoList) //Mostrar tareas usando foreach
    {
        Console.WriteLine("========================");
        Console.WriteLine("Lista de Tareas: ");
        for (int i = 0; i < todoList.Count; i++)
        {
            if (todoList[i].Completed)
            {
                Console.WriteLine($"({i}) {todoList[i].Task} [HECHO]");
            }
            else
            {
                Console.WriteLine($"({i}) {todoList[i].Task}");
            }
        }
    }

    public static void crearTarea(List<TodoItem> todoList) // crear una tarea usando bucle
    {
        Console.WriteLine("========================");
        while (true)
        {
            Console.WriteLine("Ingresa tu nueva tarea (escribe \"stop\" para volver):");
            string? line = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(line))
            {
                Console.WriteLine("No puede haber una tarea vacia, Ingresa una tarea:");
                continue;
            }

            string trimmedLine = line.Trim(); // considera los espacios vacios

            if (trimmedLine.Equals("stop", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            TodoItem todoItem = new TodoItem { Task = trimmedLine, Completed = false };
            todoList.Add(todoItem);
        }
    }


}
