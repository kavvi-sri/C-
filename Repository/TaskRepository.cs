using Protofolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Protofolio.Repository
{
    public interface TaskRepository
    {
        Task CreateTask(Task task);

        Task GetTaskById(int id);

        List<Task> GetAllTasks();

        Task UpdateTask(Task task, int id);

        String DeleteTask(int id);

        int taskCount();

    }
}