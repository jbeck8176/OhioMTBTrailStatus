using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OhioMTBTrailStatus.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			var test = new Data.Repositories.StatusRepository();
			var all = test.FindAll();
            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
