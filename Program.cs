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


    // Desarrollado por Programador Rolando 

    public static void marcarHecho(List<TodoItem> todoList) // marcar como completado
    {
        Console.WriteLine("Escribe el ID de la tarea que quieres marcar como completado");
        string? taskIdInput = Console.ReadLine();

        if (!int.TryParse(taskIdInput, out int taskId)) // Intenta parsear la entrada a un entero
        {
            Console.WriteLine("No es un numero valido");
            return;
        }

        if (taskId < 0 || taskId >= todoList.Count) // Verifica si el ID está fuera de rango
        {
            Console.WriteLine("El numero no corresponde a algun ID");
            return;
        }

        todoList[taskId].Completed = true;
        Console.WriteLine($"Task ({taskId}) HECHO");
    }

    public static void Main(string[] args)
    {
        // Inicializa la lista de tareas
        List<TodoItem> todoList = new List<TodoItem>();

        while (true)
        {
            Console.WriteLine("========================");
            Console.WriteLine("¿Qué es lo que quieres hacer? :");
            Console.WriteLine("(1) Mostrar tareas");
            Console.WriteLine("(2) Anadir nueva tarea");
            Console.WriteLine("(3) Marcar como hecho");
            Console.WriteLine("(4) Exit"); 
            Console.Write("Elije un opcion: "); 

            string? line = Console.ReadLine();
            string? trimmedLine = line?.Trim(); 

            switch (trimmedLine)
            {
                case "1":
                    mostrarTareas(todoList);
                    break;
                case "2":
                    crearTarea(todoList);
                    break;
                case "3":
                    marcarHecho(todoList);
                    break;
                case "4":
                    Console.WriteLine("Saliendo de la aplicacion ...");
                    return;
                default:
                    Console.WriteLine("No es una opcion valida.");
                    break;
            }
        }
    }




}

