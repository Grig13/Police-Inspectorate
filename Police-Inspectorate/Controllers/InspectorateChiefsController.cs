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
    public class InspectorateChiefsController : Controller
    {
        private readonly PoliceInspectorateContext _context;

        public InspectorateChiefsController(PoliceInspectorateContext context)
        {
            _context = context;
        }

        [Authorize(Roles = "Admin, User")]
        // GET: InspectorateChiefs
        public async Task<IActionResult> Index()
        {
            return View(await _context.InspectorateChief.ToListAsync());
        }

        // GET: InspectorateChiefs/Details/5
        [Authorize(Roles = "Admin, User")]
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.InspectorateChief == null)
            {
                return NotFound();
            }

            var inspectorateChief = await _context.InspectorateChief
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inspectorateChief == null)
            {
                return NotFound();
            }

            return View(inspectorateChief);
        }

        // GET: InspectorateChiefs/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: InspectorateChiefs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("Id,UserName,FirstName,LastName,Age")] InspectorateChief inspectorateChief)
        {
            if (ModelState.IsValid)
            {
                inspectorateChief.Id = Guid.NewGuid();
                _context.Add(inspectorateChief);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(inspectorateChief);
        }

        // GET: InspectorateChiefs/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.InspectorateChief == null)
            {
                return NotFound();
            }

            var inspectorateChief = await _context.InspectorateChief.FindAsync(id);
            if (inspectorateChief == null)
            {
                return NotFound();
            }
            return View(inspectorateChief);
        }

        // POST: InspectorateChiefs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,UserName,FirstName,LastName,Age")] InspectorateChief inspectorateChief)
        {
            if (id != inspectorateChief.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inspectorateChief);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InspectorateChiefExists(inspectorateChief.Id))
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
            return View(inspectorateChief);
        }

        // GET: InspectorateChiefs/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.InspectorateChief == null)
            {
                return NotFound();
            }

            var inspectorateChief = await _context.InspectorateChief
                .FirstOrDefaultAsync(m => m.Id == id);
            if (inspectorateChief == null)
            {
                return NotFound();
            }

            return View(inspectorateChief);
        }

        // POST: InspectorateChiefs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.InspectorateChief == null)
            {
                return Problem("Entity set 'PoliceInspectorateContext.InspectorateChief'  is null.");
            }
            var inspectorateChief = await _context.InspectorateChief.FindAsync(id);
            if (inspectorateChief != null)
            {
                _context.InspectorateChief.Remove(inspectorateChief);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InspectorateChiefExists(Guid id)
        {
          return (_context.InspectorateChief?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
