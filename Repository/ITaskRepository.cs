using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Repository
{
    public interface ITaskRepository
    {
        void Create(Task task);

        void Update(Task task);

        void Delete(int id);

        Task GetById(int id);

        List<Task> GetAll();
       
        List<Task> GetTasksCompleted();
        
        List<Task> GetTasksToDo();
    }
}