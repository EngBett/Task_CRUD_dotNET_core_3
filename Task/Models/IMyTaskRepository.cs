using System.Collections.Generic;

namespace Task.Models
{
    public interface IMyTaskRepository
    {
        IEnumerable<MyTask> AllTasks { get; }
        bool CreateTask(MyTask task);
        MyTask GetTask(int id);
        bool UpdateTask(MyTask task);
        bool DeleteTask(MyTask task);
    }
}