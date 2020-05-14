using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
namespace AspNetCoreTodo.Controllers
{
    public class TodoController : Controller
    {
        //ACTIONS: These are routes handled by controllers. Here https://localhost:5000/Todo  - since the url has Todo at the end, program knows to use the TodoController.
        public IActionResult Index()
        {
            // Get to-do items from database
            // Put items into a model
            // Render view using the model
        }

    }
}

