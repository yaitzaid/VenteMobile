using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VenteMobile.Data;
using VenteMobile.Models;

namespace VenteMobile.Controllers
{
    public class CritiquesController : Controller
    {
        private readonly VenteMobileContext _context;

        public CritiquesController(VenteMobileContext context)
        {
            _context = context;
        }

        // GET: Critiques
        public async Task<IActionResult> Index()
        {
            var venteMobileContext = _context.Critique.Include(c => c.Telephone);
            return View(await venteMobileContext.ToListAsync());
        }

        // GET: Critiques/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var critique = await _context.Critique
                .Include(c => c.Telephone)
                .FirstOrDefaultAsync(m => m.CritiqueId == id);
            if (critique == null)
            {
                return NotFound();
            }

            return View(critique);
        }

        // GET: Critiques/Create
        public IActionResult Create(int id)
        {
            //ViewData["TelephoneId"] = new SelectList(_context.Set<Telephone>(), "TelephoneId", "TelephoneModel");
            ViewData["TelephoneId"] = id;
            return View();
        }

        // POST: Critiques/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CritiqueId,CritiqueText,CritiqueEtoiles,CritiqueNom,TelephoneId")] Critique critique)
        {
            if (ModelState.IsValid)
            {
                _context.Add(critique);
                await _context.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Details", "Telephones", new { id = critique.TelephoneId });
            }
            //ViewData["TelephoneId"] = new SelectList(_context.Set<Telephone>(), "TelephoneId", "TelephoneModel", critique.TelephoneId);
            return View(critique);
        }

        // GET: Critiques/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var critique = await _context.Critique.FindAsync(id);
            if (critique == null)
            {
                return NotFound();
            }
            ViewData["TelephoneId"] = new SelectList(_context.Set<Telephone>(), "TelephoneId", "TelephoneModel", critique.TelephoneId);
            return View(critique);
        }

        // POST: Critiques/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CritiqueId,CritiqueText,CritiqueEtoiles,CritiqueNom,TelephoneId")] Critique critique)
        {
            if (id != critique.CritiqueId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(critique);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CritiqueExists(critique.CritiqueId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "Telephones", new { id = critique.TelephoneId });
            }
            ViewData["TelephoneId"] = new SelectList(_context.Set<Telephone>(), "TelephoneId", "TelephoneModel", critique.TelephoneId);
            return View(critique);
        }

        // GET: Critiques/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var critique = await _context.Critique
                .Include(c => c.Telephone)
                .FirstOrDefaultAsync(m => m.CritiqueId == id);
            if (critique == null)
            {
                return NotFound();
            }

            return View(critique);
        }

        // POST: Critiques/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var critique = await _context.Critique.FindAsync(id);
            _context.Critique.Remove(critique);
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "Telephones", new { id = critique.TelephoneId });
        }

        private bool CritiqueExists(int id)
        {
            return _context.Critique.Any(e => e.CritiqueId == id);
        }
    }
}
