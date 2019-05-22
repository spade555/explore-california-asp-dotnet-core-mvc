using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.ViewComponents
{
    // to create a ViewCompononent we need 1 of these 3: suffix, decorator, base class.
    [ViewComponent]
    public class MonthlySpecialsViewComponent : ViewComponent
    {
        public string Invoke()
        {
            return "TODO: monthly specials";
        }
    }
}
