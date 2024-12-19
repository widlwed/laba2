using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class TaskView
    {
        public void DisplayTasks(List<Task> tasks)
        {
            Console.WriteLine("Current Tasks:");
            foreach (var task in tasks)
            {
                Console.WriteLine($"ID: {task.Id}, Title: {task.Title}, Description: {task.Description}, Completed: {task.IsCompleted}");
            }
        }

        public void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

}
