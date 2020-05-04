using System.Collections.Generic;
using System.Linq;

namespace Task.Models
{
    public class MyTaskRepository : IMyTaskRepository
    {
        private readonly AppDbContext _appDbContext;
        public MyTaskRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<MyTask> AllTasks => _appDbContext.Tasks;

        public bool CreateTask(MyTask task)
        {
            _appDbContext.Tasks.Add(task);

            return _appDbContext.SaveChanges() > 0;
        }

        public MyTask GetTask(int id) => _appDbContext.Tasks.FirstOrDefault(t => t.MyTaskId == id);

        public bool UpdateTask(MyTask task)
        {
            _appDbContext.Tasks.Update(task);
            return _appDbContext.SaveChanges() > 0;
        }

        public bool DeleteTask(MyTask task)
        {
            _appDbContext.Tasks.Remove(task);
            return _appDbContext.SaveChanges() > 0;
        }
    }
}