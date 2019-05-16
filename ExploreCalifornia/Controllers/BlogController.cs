using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return new ContentResult
            {
                Content = "In ASP.NET MVC every controller action returns an ActionResult."
            };
        }

        public IActionResult Post(int id)
        {
            return new ContentResult
            {
                Content = "The action parameters are extracted based on their name. Now Id is " + id + "."
            };
        }
    }
}