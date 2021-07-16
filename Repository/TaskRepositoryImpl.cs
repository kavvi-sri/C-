using Protofolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Protofolio.Repository
{
    public class TaskRepositoryImpl : TaskRepository
    {
        public Task CreateTask(Task task)
        {
            Task theTask = new Task();
            theTask.Id = 101;
            theTask.Description = "Learn C#";
            theTask.StartDate = new DateTime();
            theTask.EndDate = new DateTime();
            theTask.Status = "completed";
            theTask.AssignedBy = "sri";
            return theTask;
        }

        public List<Task> GetAllTasks()
        {
            List<Task> listTask = new List<Task>();
            Task theTask = new Task();
            theTask.Id = 102;
            theTask.Description = "Learn Angular";
            theTask.StartDate = new DateTime();
            theTask.EndDate = new DateTime();
            theTask.Status = "completed";
            theTask.AssignedBy = "abc";
            listTask.Add(theTask);

            Task theTask1 = new Task();
            theTask1.Id = 102;
            theTask1.Description = "Learn DotNet";
            theTask1.StartDate = new DateTime();
            theTask1.EndDate = new DateTime();
            theTask1.Status = "completed";
            theTask1.AssignedBy = "xyz";
            listTask.Add(theTask1);
            return listTask; ;
        }

        public Task GetTaskById(int id)
        {
            Task theTask = new Task();
            theTask.Id = 101;
            theTask.Description = "Learn C#";
            theTask.StartDate = new DateTime();
            theTask.EndDate = new DateTime();
            theTask.Status = "completed";
            theTask.AssignedBy = "sri";
            return theTask;
        }

        public int taskCount()
        {
            throw new NotImplementedException();
        }

        public Task UpdateTask(Task task, int id)
        {
            throw new NotImplementedException();
        }

        public String DeleteTask(int id)
        {
            return "Delete Successfully";
        }

    }
}