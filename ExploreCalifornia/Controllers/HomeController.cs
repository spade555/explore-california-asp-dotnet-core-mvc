using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ExploreCalifornia.Controllers
{
    public class HomeController 
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return new ContentResult { Content = "In the previous case ASP.NET Core MVC converted our string into a ContentResult." };
            // return "The controllers do not need to be derived from Controller class at all.";
        }
    }
}
