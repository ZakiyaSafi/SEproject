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
    public class OffencesController : Controller
    {
        private readonly graderContext _context;

        public OffencesController(graderContext context)
        {
            _context = context;
        }

        // GET: Offences
        public async Task<IActionResult> Index()
        {
            var getOffences = (from r in _context.ReportQueries
                               where r.reportQueryNature == "offence"
                               select r).ToList();
            return View(getOffences);
        }

        // GET: Offences/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportQuery = await _context.ReportQueries
                .SingleOrDefaultAsync(m => m.reportQueryID == id);
            if (reportQuery == null)
            {
                return NotFound();
            }

            return View(reportQuery);
        }

        // GET: Offences/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Offences/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("reportQueryID,studentID,reportQueryNature,reportQueryReason,reportQueryValid")] ReportQuery reportQuery)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reportQuery);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reportQuery);
        }

        // GET: Offences/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportQuery = await _context.ReportQueries.SingleOrDefaultAsync(m => m.reportQueryID == id);
            if (reportQuery == null)
            {
                return NotFound();
            }
            return View(reportQuery);
        }

        // POST: Offences/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("reportQueryID,studentID,reportQueryNature,reportQueryReason,reportQueryValid")] ReportQuery reportQuery)
        {
            if (id != reportQuery.reportQueryID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reportQuery);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportQueryExists(reportQuery.reportQueryID))
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
            return View(reportQuery);
        }

        // GET: Offences/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportQuery = await _context.ReportQueries
                .SingleOrDefaultAsync(m => m.reportQueryID == id);
            if (reportQuery == null)
            {
                return NotFound();
            }

            return View(reportQuery);
        }

        // POST: Offences/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reportQuery = await _context.ReportQueries.SingleOrDefaultAsync(m => m.reportQueryID == id);
            _context.ReportQueries.Remove(reportQuery);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportQueryExists(int id)
        {
            return _context.ReportQueries.Any(e => e.reportQueryID == id);
        }
    }
}
