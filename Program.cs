namespace Project_W68342
{
    using System;
    using System.Collections.Generic;

    class TaskManager
    {
     
        private List<string> tasks = new List<string>();

      
        public void AddTask(string task)
        {
            tasks.Add(task);
            Console.WriteLine("Task added");
        }

      
        public void RemoveTask(int index)
        {
            if (index >= 0 && index < tasks.Count)
            {
                tasks.RemoveAt(index);
                Console.WriteLine("Task deleted");
            }
            else
            {
                Console.WriteLine("Incorrect index, not found");
            }
        }

     
        public void DisplayTasks()
        {
            if (tasks.Count == 0)
            {
                Console.WriteLine("Task index is empty");
            }
            else
            {
                Console.WriteLine("List of task:");
                for (int i = 0; i < tasks.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            TaskManager taskManager = new TaskManager();

            while (true)
            {
                
                Console.Clear();
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Delete Task");
                Console.WriteLine("3. Show all task");
                Console.WriteLine("4. Exit from program");
                Console.Write("Choice action: ");

              
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.Write("Enter description of  task: ");
                        string task = Console.ReadLine();
                        taskManager.AddTask(task);
                        break;

                    case "2":
                        Console.Write("Enter the number for deletting task : ");
                        if (int.TryParse(Console.ReadLine(), out int taskIndex))
                        {
                            taskManager.RemoveTask(taskIndex - 1); 
                        }
                        else
                        {
                            Console.WriteLine("Incorrect number");
                        }
                        break;

                    case "3":
                        taskManager.DisplayTasks();
                        break;

                    case "4":
                        Console.WriteLine("Bye bye");
                        return;

                    default:
                        Console.WriteLine("Incorrect choice. Try again");
                        break;
                }

                
                Console.WriteLine("\nEnter any keyboards for continue...");
                Console.ReadKey();
            }
        }
    }

}