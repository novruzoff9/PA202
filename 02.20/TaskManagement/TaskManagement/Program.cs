using TaskManagement.Enums;
using TaskManagement.Helpers;
using TaskManagement.Models;
using TaskManagement.Services;

MyTask myTask = new();
myTask.Title = "First task";
myTask.Description = "My task description";
myTask.DeadLine = DateTime.Now.AddDays(7);
myTask.Status = MyTaskStatus.ToDo;

MyTask myTask2 = new();
myTask2.Title = "First task";
myTask2.Description = "My second task description";
myTask2.DeadLine = DateTime.Now.AddDays(7);
myTask2.Status = MyTaskStatus.ToDo;

MyTask myTask3 = new()
{
    Title = "Third task",
    Description = "My third task description",
    DeadLine = DateTime.Now.AddDays(7),
    Status = MyTaskStatus.Done
};

try
{
    ITaskService taskService = new TaskService();
    taskService.AddTask(myTask);
    taskService.AddTask(myTask2);
    taskService.AddTask(myTask3);

    var foundedTasks = taskService.GetByStatus("ToDo");

    foreach (var item in foundedTasks)
    {
        Console.WriteLine(item);
    }
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

myTask3.UntillEnd();