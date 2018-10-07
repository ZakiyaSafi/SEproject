using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using grader.Models;

namespace grader.Controllers
{
    public class LoginController : Controller
    {

        private readonly graderContext _context;

        public LoginController(graderContext context)
        {
            _context = context;
        }

        public IActionResult Home()
        {
            return View();
        }
        
        public ActionResult Login(IFormCollection Data)
        {
            string password = Data["password"];
            string id = Data["ID"];
            string usertype = Data["usertype"];

            if (usertype == "Student")
            {
                var getStudent = (from c in _context.Students
                                  where c.studentNo == id
                                  select c).SingleOrDefault();
                if (getStudent != null && getStudent.studentPassword == password)
                {
                    return RedirectToAction("Index", "StudentHome");
                }
            }
            else if (usertype == "Course Coordinator")
            {
                var getCC = (from c in _context.CourseCoordinators
                             where c.courseCoordinatorNo == id
                             select c).SingleOrDefault();
                if (getCC != null && getCC.courseCoordinatorPassword == password)
                {
                    return RedirectToAction("Index", "CCHome");
                }
            }
            else if (usertype == "School Admin")
            {
                var getSA = (from c in _context.SchoolAdministrators
                             where c.schoolAdministratorNo == id
                             select c).SingleOrDefault();
                if (getSA != null && getSA.schoolAdministratorPassword == password)
                {
                    return RedirectToAction("Index", "SAHome");
                }
            }

            //popup for incorrect login
            return View("Home");
        }
    }
}