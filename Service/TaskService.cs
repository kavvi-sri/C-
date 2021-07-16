using Protofolio.Models;
using Protofolio.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Protofolio.Service
{
   
    public class TaskService
    {
        private TaskRepository taskRepo;
        public TaskService()
        {
            taskRepo = new TaskRepositoryImpl();

        }
        public Task CreateTask(Task task)
        {
            return taskRepo.CreateTask(task);
        }

        public Task FindTaskById(int id)
        {
            return taskRepo.GetTaskById(id);
        }
        
        public List<Task> GetAllTask()
        {
            return taskRepo.GetAllTasks();
        }

        public string removeTask(int id)
        {
            return taskRepo.DeleteTask(id);
        }
    }
}