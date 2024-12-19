using System;
using System.Collections.Generic;

namespace laba2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var tasks = new List<Task>();
            while (true)
            {
                Console.WriteLine("\nTask Manager");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Show Tasks");
                Console.WriteLine("3. Delete Task");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");

                if (!int.TryParse(Console.ReadLine(), out int option))
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        Console.Write("Enter Task Title: ");
                        string title = Console.ReadLine() ?? "Untitled Task";
                        tasks.Add(new Task { Id = tasks.Count + 1, Title = title });
                        Console.WriteLine("Task added.");
                        break;
                    case 2:
                        Console.WriteLine("\nTasks:");
                        foreach (var task in tasks)
                        {
                            Console.WriteLine($"ID: {task.Id}, Title: {task.Title}");
                        }
                        break;
                    case 3:
                        Console.Write("Enter Task ID to delete: ");
                        if (int.TryParse(Console.ReadLine(), out int idToDelete))
                        {
                            var taskToRemove = tasks.Find(t => t.Id == idToDelete);
                            if (taskToRemove != null)
                            {
                                tasks.Remove(taskToRemove);
                                Console.WriteLine("Task deleted.");
                            }
                            else
                            {
                                Console.WriteLine("Task not found.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Task ID.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose a number between 1 and 4.");
                        break;
                }
            }
        }
    }
}
