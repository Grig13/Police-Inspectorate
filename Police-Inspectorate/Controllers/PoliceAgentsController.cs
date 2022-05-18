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
    public class PoliceAgentsController : Controller
    {
        private readonly PoliceInspectorateContext _context;

        public PoliceAgentsController(PoliceInspectorateContext context)
        {
            _context = context;
        }

        // GET: PoliceAgents

        public async Task<IActionResult> Index()
        {
            return View(await _context.PoliceAgents.ToListAsync());
        }

        // GET: PoliceAgents/Details/5

        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var policeAgent = await _context.PoliceAgents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (policeAgent == null)
            {
                return NotFound();
            }

            return View(policeAgent);
        }


        // GET: PoliceAgents/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PoliceAgents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UserName,StationNumber,FirstName,LastName,Age,StationChief")] PoliceAgent policeAgent)
        {
            if (ModelState.IsValid)
            {
                policeAgent.Id = Guid.NewGuid();
                _context.Add(policeAgent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(policeAgent);
        }

        // GET: PoliceAgents/Edit/5

        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var policeAgent = await _context.PoliceAgents.FindAsync(id);
            if (policeAgent == null)
            {
                return NotFound();
            }
            return View(policeAgent);
        }

        // POST: PoliceAgents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(Guid id, [Bind("Id,UserName,StationNumber,FirstName,LastName,Age,StationChief")] PoliceAgent policeAgent)
        {
            if (id != policeAgent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(policeAgent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PoliceAgentExists(policeAgent.Id))
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
            return View(policeAgent);
        }

        // GET: PoliceAgents/Delete/5

        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var policeAgent = await _context.PoliceAgents
                .FirstOrDefaultAsync(m => m.Id == id);
            if (policeAgent == null)
            {
                return NotFound();
            }

            return View(policeAgent);
        }

        // POST: PoliceAgents/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var policeAgent = await _context.PoliceAgents.FindAsync(id);
            _context.PoliceAgents.Remove(policeAgent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PoliceAgentExists(Guid id)
        {
            return _context.PoliceAgents.Any(e => e.Id == id);
        }
    }
}
