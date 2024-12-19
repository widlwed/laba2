using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public interface ITaskRepository
    {
        void AddTask(Task task);
        List<Task> GetAllTasks();
        Task GetTaskById(int id);
        void UpdateTask(Task task);
        void DeleteTask(int id);
    }

    public class TaskRepository : ITaskRepository
    {
        private readonly List<Task> _tasks = new List<Task>();

        public void AddTask(Task task) => _tasks.Add(task);

        public List<Task> GetAllTasks() => _tasks;

        public Task GetTaskById(int id) => _tasks.Find(t => t.Id == id);

        public void UpdateTask(Task task)
        {
            var existingTask = GetTaskById(task.Id);
            if (existingTask != null)
            {
                existingTask.Title = task.Title;
                existingTask.Description = task.Description;
                existingTask.IsCompleted = task.IsCompleted;
            }
        }

        public void DeleteTask(int id) => _tasks.RemoveAll(t => t.Id == id);
    }

}
