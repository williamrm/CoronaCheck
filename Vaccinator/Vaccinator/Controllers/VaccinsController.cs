using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcVaccin.Data;
using MvcVaccin.Models;

namespace Vaccinator.Controllers
{
    public class VaccinsController : Controller
    {
        private readonly MvcVaccinContext _context;

        public VaccinsController(MvcVaccinContext context)
        {
            _context = context;
        }

        // GET: Vaccins
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vaccin.ToListAsync());
        }

        // GET: Vaccins/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccin = await _context.Vaccin
                .FirstOrDefaultAsync(m => m.idVaccin == id);
            if (vaccin == null)
            {
                return NotFound();
            }

            return View(vaccin);
        }

        // GET: Vaccins/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vaccins/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idVaccin,marque,num_lot")] Vaccin vaccin)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vaccin);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vaccin);
        }

        // GET: Vaccins/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccin = await _context.Vaccin.FindAsync(id);
            if (vaccin == null)
            {
                return NotFound();
            }
            return View(vaccin);
        }

        // POST: Vaccins/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idVaccin,marque,num_lot")] Vaccin vaccin)
        {
            if (id != vaccin.idVaccin)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vaccin);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VaccinExists(vaccin.idVaccin))
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
            return View(vaccin);
        }

        // GET: Vaccins/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vaccin = await _context.Vaccin
                .FirstOrDefaultAsync(m => m.idVaccin == id);
            if (vaccin == null)
            {
                return NotFound();
            }

            return View(vaccin);
        }

        // POST: Vaccins/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vaccin = await _context.Vaccin.FindAsync(id);
            _context.Vaccin.Remove(vaccin);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VaccinExists(int id)
        {
            return _context.Vaccin.Any(e => e.idVaccin == id);
        }
    }
}
