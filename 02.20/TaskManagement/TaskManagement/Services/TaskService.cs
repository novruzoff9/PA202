using TaskManagement.Enums;
using TaskManagement.Exceptions;
using TaskManagement.Models;

namespace TaskManagement.Services;

internal class TaskService : ITaskService
{
    public static MyTask[] _Tasks = [];
    public void AddTask(MyTask task)
    {
        foreach (var item in _Tasks)
        {
            if (item.Title == task.Title)
                throw new ConflictException($"'{task.Title}' basliqli task movcuddur");
        }
        Array.Resize(ref _Tasks, _Tasks.Length + 1);
        _Tasks[^1] = task;
    }

    public MyTask[] GetByStatus(string statusStr)
    {
        MyTask[] foundedTasks = [];
        MyTaskStatus status;
        if (!Enum.TryParse(statusStr, out status))
        {
            Console.WriteLine("Cevrilme mumkun olmadi");
            return [];
        }
        foreach (var item in _Tasks)
        {
            if (item.Status == status)
            {
                Array.Resize(ref foundedTasks, foundedTasks.Length + 1);
                foundedTasks[^1] = item;
            }
        }
        return foundedTasks;
    }

    public MyTask GetTask(string title)
    {
        throw new NotImplementedException();
    }

    public void Remove(int id)
    {
        throw new NotImplementedException();
    }
}
