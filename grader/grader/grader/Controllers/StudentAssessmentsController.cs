using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using grader.Models;
using Microsoft.AspNetCore.Http;

namespace grader.Controllers
{
    public class StudentAssessmentsController : Controller
    {
        private readonly graderContext _context;

        public StudentAssessmentsController(graderContext context)
        {
            _context = context;
        }

        // GET: StudentAssessments
        public async Task<IActionResult> Index(int? id)
        {
            var getAssessments = (from a in _context.Assessments
                                  where a.courseID.Equals(id)
                                  select a).ToList();
            return View(getAssessments);
        }

        // GET: StudentAssessments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assessment = await _context.Assessments
                .SingleOrDefaultAsync(m => m.assessmentID == id);
            if (assessment == null)
            {
                return NotFound();
            }

            return View(assessment);
        }

        // GET: StudentAssessments/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: StudentAssessments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("assessmentID,courseID,assessmentTotalMark,assessmentWeighting")] Assessment assessment)
        {
            if (ModelState.IsValid)
            {
                _context.Add(assessment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(assessment);
        }

        // GET: StudentAssessments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assessment = await _context.Assessments.SingleOrDefaultAsync(m => m.assessmentID == id);
            if (assessment == null)
            {
                return NotFound();
            }
            return View(assessment);
        }

        // POST: StudentAssessments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("assessmentID,courseID,assessmentTotalMark,assessmentWeighting")] Assessment assessment)
        {
            if (id != assessment.assessmentID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(assessment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AssessmentExists(assessment.assessmentID))
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
            return View(assessment);
        }

        // GET: StudentAssessments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var assessment = await _context.Assessments
                .SingleOrDefaultAsync(m => m.assessmentID == id);
            if (assessment == null)
            {
                return NotFound();
            }

            return View(assessment);
        }

        // POST: StudentAssessments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var assessment = await _context.Assessments.SingleOrDefaultAsync(m => m.assessmentID == id);
            _context.Assessments.Remove(assessment);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AssessmentExists(int id)
        {
            return _context.Assessments.Any(e => e.assessmentID == id);
        }
    }
}
