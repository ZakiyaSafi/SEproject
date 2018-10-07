using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using grader.Models;

namespace grader.Controllers
{
    public class StudentHomeController : Controller
    {
        private readonly graderContext _context;

        public StudentHomeController(graderContext context)
        {
            _context = context;
        }

        // GET: StudentHome
        public async Task<IActionResult> Index()
        {
            int tempStudentID = 1;
            var getStudentCourses = (from s in _context.StudentCourses
                                     where s.studentID.Equals(tempStudentID)
                                     select s.courseID).ToList();
            List<Course> courseList = new List<Course>();
            for (int i = 0; i < getStudentCourses.Count(); i++)
            {
                var getCourse = (from c in _context.Courses
                                 where c.courseID == getStudentCourses[i]
                                 select c).SingleOrDefault();
                courseList.Add(getCourse);
            }
            return View(courseList);
        }

        // GET: StudentHome/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .SingleOrDefaultAsync(m => m.courseID == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // GET: StudentHome/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentHome/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("courseID,courseName,courseCode,courseCoordinatorID,schoolAdministratorID")] Course course)
        {
            if (ModelState.IsValid)
            {
                _context.Add(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        // GET: StudentHome/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses.SingleOrDefaultAsync(m => m.courseID == id);
            if (course == null)
            {
                return NotFound();
            }
            return View(course);
        }

        // POST: StudentHome/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("courseID,courseName,courseCode,courseCoordinatorID,schoolAdministratorID")] Course course)
        {
            if (id != course.courseID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(course);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(course.courseID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(course);
        }

        // GET: StudentHome/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var course = await _context.Courses
                .SingleOrDefaultAsync(m => m.courseID == id);
            if (course == null)
            {
                return NotFound();
            }

            return View(course);
        }

        // POST: StudentHome/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var course = await _context.Courses.SingleOrDefaultAsync(m => m.courseID == id);
            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CourseExists(int id)
        {
            return _context.Courses.Any(e => e.courseID == id);
        }
    }
}
