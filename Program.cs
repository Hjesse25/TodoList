var tasks = new List<string>();
var completeTasks = new List<string>();

DisplayMenu();

void DisplayMenu()
{
    bool isMenu = true;

    Console.WriteLine("--------------- Todo List App ---------------");
    do
    {
        Console.WriteLine("Select a option:");
        Console.WriteLine("1. Add Task");
        Console.WriteLine("2. Remove Task");
        Console.WriteLine("3. Display Tasks");
        Console.WriteLine("4. Mark Task as Complete");
        Console.WriteLine("5. Exit");

        string? option = Console.ReadLine();

        switch (option.Trim())
        {
            case "1":
                AddTask();
                break;
            case "2":
                RemoveTask();
                break;
            case "3":
                DisplayTasks();
                break;
            case "4":
                MarkComplete();
                break;
            case "5":
                isMenu = false;
                Console.WriteLine("Goodbye");
                Environment.Exit(1);
                break;
            default:
                Console.WriteLine("Invalid input");
                break;
        }

        Console.WriteLine("Press any key to continue");
        Console.ReadLine();
        Console.Clear();
    } while (isMenu);
}

void AddTask()
{
    Console.WriteLine("Enter your task:");
    string? input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Input cannot be empty");
    }
    else
    {
        tasks.Add(input);
        Console.WriteLine();
        Console.WriteLine($"Your task \"{input}\" has been added.");
    }
}

void DisplayTasks()
{
    Console.WriteLine("Pending Tasks:");

    foreach (var task in tasks)
    {
        Console.WriteLine($"- {task}");
    }

    Console.WriteLine();
    Console.WriteLine("Complete Tasks:");

    foreach (var task in completeTasks)
    {
        Console.WriteLine(task);
    }
}

void RemoveTask()
{
    Console.WriteLine("Select a task to remove:");
    ListTasks();

    string? input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Input cannot be empty");
    }
    else
    {
        tasks.Remove(input);
        Console.WriteLine();
        Console.WriteLine("Task has been removed.");
    }
}

void MarkComplete()
{
    Console.WriteLine("Select a task to complete:");
    ListTasks();

    string? input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Input cannot be empty");
    }
    else
    {
        completeTasks.Add($"- {DateTime.Now}: {input}");
        Console.WriteLine();
        Console.WriteLine($"Task \"{input}\" complete");
    }
}

void ListTasks()
{
    foreach (var task in tasks)
    {
        Console.WriteLine(task);
    }
}