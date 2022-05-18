#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PoliceInspectorate.Context;
using Police_Inspectorate.Models;
using Microsoft.AspNetCore.Authorization;

namespace Police_Inspectorate.Controllers
{
    [Authorize]
    public class SuspectsController : Controller
    {
        private readonly PoliceInspectorateContext _context;

        public SuspectsController(PoliceInspectorateContext context)
        {
            _context = context;
        }

        // GET: Suspects

        public async Task<IActionResult> Index()
        {
            return View(await _context.Suspects.ToListAsync());
        }

        // GET: Suspects/Details/5

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suspect = await _context.Suspects
                .FirstOrDefaultAsync(m => m.Id == id);
            if (suspect == null)
            {
                return NotFound();
            }

            return View(suspect);
        }

        // GET: Suspects/Create

        public IActionResult Create()
        {
            return View();
        }

        // POST: Suspects/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,Age,Record,Address")] Suspect suspect)
        {
            if (ModelState.IsValid)
            {
                suspect.Id = Guid.NewGuid();
                _context.Add(suspect);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(suspect);
        }

        // GET: Suspects/Edit/5

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suspect = await _context.Suspects.FindAsync(id);
            if (suspect == null)
            {
                return NotFound();
            }
            return View(suspect);
        }

        // POST: Suspects/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(Guid id, [Bind("Id,FirstName,LastName,Age,Record,Address")] Suspect suspect)
        {
            if (id != suspect.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(suspect);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SuspectExists(suspect.Id))
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
            return View(suspect);
        }

        // GET: Suspects/Delete/5

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var suspect = await _context.Suspects
                .FirstOrDefaultAsync(m => m.Id == id);
            if (suspect == null)
            {
                return NotFound();
            }

            return View(suspect);
        }

        // POST: Suspects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var suspect = await _context.Suspects.FindAsync(id);
            _context.Suspects.Remove(suspect);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SuspectExists(Guid id)
        {
            return _context.Suspects.Any(e => e.Id == id);
        }
    }
}
