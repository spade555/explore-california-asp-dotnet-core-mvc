using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.Models;

namespace ExploreCalifornia.ViewComponents
{
    // to create a ViewCompononent we need 1 of these 3: suffix, decorator, base class.
    [ViewComponent]
    public class MonthlySpecialsViewComponent : ViewComponent
    {
        private readonly BlogDataContext _db;

        public MonthlySpecialsViewComponent(BlogDataContext db)
        {
            this._db = db;
        }

        public IViewComponentResult Invoke()
        {
            var specials = _db.MonthlySpecials.ToArray();
            return View(specials);
        }
    }
}
