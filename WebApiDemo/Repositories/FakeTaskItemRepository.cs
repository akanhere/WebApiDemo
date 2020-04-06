using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Contracts;
using WebApiDemo.Models;

namespace WebApiDemo.Repositories
{
    public class FakeTaskItemRepository : ITaskRepository
    {
        public Task<TaskItem> Add(TaskItem taskItem)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Exists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TaskItem> Find(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TaskItem> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TaskItem> Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TaskItem> Update(TaskItem taskItem)
        {
            throw new NotImplementedException();
        }
    }
}
