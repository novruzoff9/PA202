using TaskManagement.Enums;
using TaskManagement.Models;

namespace TaskManagement.Services;

public interface ITaskService
{
    void AddTask(MyTask task);
    MyTask GetTask(string title);
    MyTask[] GetByStatus(string status);
    void Remove(int id);
}
