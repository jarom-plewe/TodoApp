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
            string todaysDate = DateTime.Now.ToShortDateString();
            return Ok(todaysDate);
        }
    }
}
