using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System;

namespace TodoApp.Controllers
{
    public class TodoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Details(int id)
        {
            return Ok("you have entered id: " + id);
        }
    }
}
