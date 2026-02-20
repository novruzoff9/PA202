using TaskManagement.Enums;

namespace TaskManagement.Models;

public class MyTask
{
    private static int _id;
    public int Id { get; }
    public string Title { get; set; }
    public string Description { get; set; }
    public DateTime Created { get; init; }
    public DateTime DeadLine { get; set; }
    public MyTaskStatus Status { get; set; }

    public MyTask()
    {
        _id++;
        Id = _id;
        Created = DateTime.Now;
    }

    public override string ToString()
    {
        return $"Id: {Id}, Title: {Title}, Description: {Description}, Created: {Created}, DeadLine: {DeadLine}, Status: {Status}";
    }
}
