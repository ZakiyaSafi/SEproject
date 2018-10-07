using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace grader.Controllers
{
    public class ReportsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult SAReports()
        {
            return View();
        }

        public ActionResult CCReports()
        {
            return View();
        }

    }
}