using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class TaskController
    {
        private readonly TaskServise _taskServise;
        private readonly TaskView _view;

        public TaskController(TaskServise taskService, TaskView view)
        {
            _taskServise = taskService;
            _view = view;
        }

        public void AddTask(string title, string description)
        {
            _taskServise.AddTask(title, description);
            _view.DisplayMessage("Task added successfully.");
        }

        public void ShowTasks()
        {
            var tasks = _taskServise.GetTasks();
            _view.DisplayTasks(tasks);
        }

        public void EditTask(int id, string title, string description)
        {
            _taskServise.UpdateTask(id, title, description);
            _view.DisplayMessage("Task updated successfully.");
        }

        public void DeleteTask(int id)
        {
            _taskServise.DeleteTask(id);
            _view.DisplayMessage("Task deleted successfully.");
        }

        public void CompleteTask(int id)
        {
            _taskServise.MarkTaskAsCompleted(id);
            _view.DisplayMessage("Task marked as completed.");
        }
    }

}
