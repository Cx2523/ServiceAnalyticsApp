using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//models
using ServiceAnalyticsApp.Models;

namespace ServiceAnalyticsApp.Controllers
{
    public class TaskController : Controller
    {
        // GET: Task
        public ActionResult TaskManagement()
        {
            TaskModel Task = new TaskModel();
            return View(Task);
        }

        [HttpPost]
        public ActionResult AddTask()
        {
            return View("TaskManagement");
        }
    }
}