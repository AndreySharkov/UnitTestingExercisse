using System.Collections.Generic;
using System.Threading.Tasks;
using TaskBoard.Models;

namespace TaskBoard.Services
{
    public interface ITaskService
    {
        Task<IEnumerable<TaskBoard.Models.Task>> GetAllTasksAsync();
        Task<string> CreateTaskAsync(TaskBoard.Models.Task task);
    }
}
