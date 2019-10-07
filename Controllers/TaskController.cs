using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using ToDoList.Repository;
using Task = ToDoList.Models.Task;

namespace ToDoList.Controllers
{
    public class TaskController : Controller
    {
        private ITaskRepository taskRepository;

        public TaskController(ITaskRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var listTask = taskRepository.GetTasksToDo();
            return View(listTask);
        }

        [HttpGet]
        public IActionResult ViewCompletedTasks()
        {
            var listTask = taskRepository.GetTasksCompleted();
            return View(listTask);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Task task)
        {
            taskRepository.Create(task);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var task = taskRepository.GetById(id);
            return View(task);
        }

        [HttpPost]
        public IActionResult Edit(Task task)
        {
            taskRepository.Update(task);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            taskRepository.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
