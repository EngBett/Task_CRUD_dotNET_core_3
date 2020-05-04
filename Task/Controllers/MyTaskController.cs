using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Task.Models;

namespace Task.Controllers
{
    public class MyTaskController : Controller
    {

        private readonly IMyTaskRepository _myTaskRepository;

        public MyTaskController(IMyTaskRepository myTaskRepository)
        {
            _myTaskRepository = myTaskRepository;
        }
        
        // GET
        public IActionResult Index()
        {
            IEnumerable<MyTask> myTasks = _myTaskRepository.AllTasks;
            return View(myTasks);
        }
        
        //GET
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MyTask task)
        {
            if (ModelState.IsValid)
            {
                _myTaskRepository.CreateTask(task);
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Edit(int id)
        {
            MyTask task = _myTaskRepository.GetTask(id);
            return View(task);
        }

        [HttpPost]
        public IActionResult Update(MyTask task)
        {
            if (ModelState.IsValid)
            {
                _myTaskRepository.UpdateTask(task);
                return RedirectToAction("Index");
            }

            return RedirectToAction("Edit");
        }

        
        public IActionResult Delete(int id)
        {
            MyTask task = _myTaskRepository.GetTask(id);
            _myTaskRepository.DeleteTask(task);
            return RedirectToAction("Index");
        }
        
    }
}