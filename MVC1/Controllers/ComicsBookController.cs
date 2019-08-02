using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MVC1.Controllers
{
    public class ComicsBookController : Controller
    {
        public ActionResult Hello()
        {
            if (DateTime.Today.DayOfWeek == DayOfWeek.Thursday)
            {
                return Redirect("/");
            }
            return Content ("Hello World!!!");
        
            
        }
    }
}
