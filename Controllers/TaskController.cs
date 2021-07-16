using Protofolio.Models;
using Protofolio.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Protofolio.Controllers
{
   
    public class TaskController : ApiController
    {
        private TaskService taskService;
        public TaskController()
        {
            taskService = new TaskService();
        }
        [HttpPost]
        [Route("api/insert/task")]
        public Task insertTask(Task task)
        {
            
            return taskService.CreateTask(task);
        }
        [HttpGet]
        [Route("api/task/{id}")]
        public Task GetTaskById(int id)
        {
            return this.taskService.FindTaskById(id);
        }

        [HttpGet]
        [Route("api/task/findall")]
        public List<Task> FindAllTask()
        {
            return this.taskService.GetAllTask();
        }

        [HttpDelete]
        [Route("api/task/{id}")]
        public string DeleteById(int id)
        {
            return this.taskService.removeTask(id);
        }

    }
}
