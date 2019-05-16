using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return new ContentResult
            {
                Content = "In ASP.NET MVC every controller action returns an ActionResult."
            };
        }

        [Route("{year:min(2012)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            return new ContentResult
            {
                Content = $"Year: {year}, Month: {month}, Key: {key}"
            };
        }
    }
}