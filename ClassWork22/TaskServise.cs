using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class TaskServise
    {
        private readonly ITaskRepository _repository;

        public TaskServise(ITaskRepository repository)
        {
            _repository = repository;
        }

        public void AddTask(string title, string description)
        {
            int newId = _repository.GetAllTasks().Count + 1;
            var task = new Task(newId, title, description);
            _repository.AddTask(task);
        }

        public List<Task> GetTasks()
        {
            return _repository.GetAllTasks();
        }

        public void UpdateTask(int id, string title, string description)
        {
            var task = _repository.GetTaskById(id);
            if (task != null)
            {
                task.Title = title;
                task.Description = description;
                _repository.UpdateTask(task);
            }
        }

        public void DeleteTask(int id)
        {
            _repository.DeleteTask(id);
        }

        public void MarkTaskAsCompleted(int id)
        {
            var task = _repository.GetTaskById(id);
            if (task != null)
            {
                task.IsCompleted = true;
                _repository.UpdateTask(task);
            }
        }
    }

}
