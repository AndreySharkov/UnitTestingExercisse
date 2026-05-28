using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TaskBoard.Models;
using TaskBoard.Services;

namespace TaskBoard.Controllers
{
    public class TasksController : Controller
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        public async Task<IActionResult> Index()
        {
            var tasks = await _taskService.GetAllTasksAsync();
            return View(tasks);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TaskBoard.Models.Task task)
        {
            if (ModelState.IsValid)
            {
                var result = await _taskService.CreateTaskAsync(task);
                if (result == "Success")
                {
                    return RedirectToAction(nameof(Index));
                }
                ModelState.AddModelError("", result);
            }
            return View(task);
        }
    }
}
