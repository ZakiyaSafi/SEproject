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
    public class StudentMarksController : Controller
    {
        private readonly graderContext _context;

        public StudentMarksController(graderContext context)
        {
            _context = context;
        }

        public ActionResult Approve()
        {
            return View();
        }

        // GET: StudentMarks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Marks.ToListAsync());
        }

        // GET: StudentMarks/Details/5
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

        // GET: StudentMarks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentMarks/Create
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

        // GET: StudentMarks/Edit/5
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

        // POST: StudentMarks/Edit/5
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

        // GET: StudentMarks/Delete/5
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

        // POST: StudentMarks/Delete/5
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
