using TaskManagement.Models;

namespace TaskManagement.Helpers;

internal static class TaskHelper
{
    extension(MyTask task)
    {
        public TimeSpan UntillEnd()
        {
            return task.DeadLine - DateTime.Now;
        }

        public TimeSpan TotalTime(int days)
        {
            return TimeSpan.FromDays(days);
        }
    }
}
