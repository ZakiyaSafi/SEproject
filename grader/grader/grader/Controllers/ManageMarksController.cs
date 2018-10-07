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
    public class ManageMarksController : Controller
    {
        private readonly graderContext _context;

        public ManageMarksController(graderContext context)
        {
            _context = context;
        }

        // GET: ManageMarks
        public async Task<IActionResult> Index(int? id)
        {
            var getMarks = (from m in _context.Marks
                            where m.assessmentID == id
                            select m).ToList();
            return View(getMarks);
        }

        // GET: ManageMarks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mark = await _context.Marks
                .SingleOrDefaultAsync(m => m.markID == id);
            if (mark == null)
            {
                return NotFound();
            }

            return View(mark);
        }

        // GET: ManageMarks/Create
        public IActionResult Create()
        {
            var assessments = (from c in _context.Assessments
                           where c.courseID == 1
                           select c.assessmentID).ToList();
            List<Mark> marks = new List<Mark>();
            for (int i = 0; i < assessments.Count; i++)
            {
                var temp = (from m in _context.Marks
                            where m.assessmentID == assessments[i]
                            select m).SingleOrDefault();
                marks.Add(temp);
            }
            return View(marks);
        }

        public ActionResult Approve()
        {
            return View();
        }

        public ActionResult Marks()
        {
            var assessments = (from c in _context.Assessments
                               where c.courseID == 1
                               select c.assessmentID).ToList();
            List<Mark> marks = new List<Mark>();
            for (int i = 0; i < assessments.Count; i++)
            {
                var temp = (from m in _context.Marks
                            where m.assessmentID == assessments[i]
                            select m).SingleOrDefault();
                marks.Add(temp);
            }
            return View(marks);
        }

        // POST: ManageMarks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("markID,studentID,assessmentID,markAchieved")] Mark mark)
        {
            if (ModelState.IsValid)
            {
                _context.Add(mark);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(mark);
        }

        // GET: ManageMarks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mark = await _context.Marks.SingleOrDefaultAsync(m => m.markID == id);
            if (mark == null)
            {
                return NotFound();
            }
            return View(mark);
        }

        // POST: ManageMarks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("markID,studentID,assessmentID,markAchieved")] Mark mark)
        {
            if (id != mark.markID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mark);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarkExists(mark.markID))
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
            return View(mark);
        }

        // GET: ManageMarks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mark = await _context.Marks
                .SingleOrDefaultAsync(m => m.markID == id);
            if (mark == null)
            {
                return NotFound();
            }

            return View(mark);
        }

        // POST: ManageMarks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mark = await _context.Marks.SingleOrDefaultAsync(m => m.markID == id);
            _context.Marks.Remove(mark);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarkExists(int id)
        {
            return _context.Marks.Any(e => e.markID == id);
        }
    }
}
