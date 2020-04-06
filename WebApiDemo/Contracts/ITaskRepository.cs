using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiDemo.Models;

namespace WebApiDemo.Contracts
{
    public interface ITaskRepository
    {
        Task<TaskItem> Add(TaskItem taskItem);
        IEnumerable<TaskItem> GetAll();

        Task<TaskItem> Find(int id);
        Task<TaskItem> Update(TaskItem taskItem);
        Task<TaskItem> Remove(int id);

        Task<bool> Exists(int id);

    }
}
