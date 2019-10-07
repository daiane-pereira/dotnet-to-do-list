using System.Collections.Generic;
using System.Linq;
using ToDoList.Configuration;
using ToDoList.Models;

namespace ToDoList.Repository
{
    public class TaskRepository : ITaskRepository
    {
        private DataContext context;

        public TaskRepository(DataContext context)
        {
            this.context = context;
        }

        public void Create(Task task)
        {
            context.Task.Add(task);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            context.Task.Remove(GetById(id));
            context.SaveChanges();
        }

        public List<Task> GetAll()
        {
            return context.Task.ToList();
        }

        public Task GetById(int id)
        {
            return context.Task.SingleOrDefault(task => task.id == id);
        }

        public void Update(Task task)
        {
            var objTask = GetById(task.id);
            objTask.name = task.name;
            objTask.priority = task.priority;
            objTask.deadline = task.deadline;
            objTask.percentageCompleted = task.percentageCompleted;
            context.SaveChanges();
        }

        public List<Task> GetTasksCompleted() 
        {
            List<Task> listTasks = this.GetAll();
            List<Task> listTasksCompleted = new List<Task>();
            foreach(var task in listTasks) {
                if(task.percentageCompleted >= 100) {
                    listTasksCompleted.Add(task);
                }
            }
            return listTasksCompleted;
        }

         public List<Task> GetTasksToDo() 
        {
            List<Task> listTasks = this.GetAll();
            List<Task> listTasksToDo = new List<Task>();
            foreach(var task in listTasks) {
                if(task.percentageCompleted < 100) {
                    listTasksToDo.Add(task);
                }
            }
            return listTasksToDo;
        }
    }
}