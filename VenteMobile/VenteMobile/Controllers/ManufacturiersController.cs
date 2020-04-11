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
    public class ManufacturiersController : Controller
    {
        private readonly VenteMobileContext _context;

        public ManufacturiersController(VenteMobileContext context)
        {
            _context = context;
        }

        // GET: Manufacturiers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Manufacturier.ToListAsync());
        }

        // GET: Manufacturiers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manufacturier = await _context.Manufacturier
                .FirstOrDefaultAsync(m => m.ManufacturierId == id);
            if (manufacturier == null)
            {
                return NotFound();
            }

            return View(manufacturier);
        }

        // GET: Manufacturiers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Manufacturiers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ManufacturierId,ManufacturierMarque,ManufacturierSiteWeb,ManufacturierOrigine")] Manufacturier manufacturier)
        {
            if (ModelState.IsValid)
            {
                _context.Add(manufacturier);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(manufacturier);
        }

        // GET: Manufacturiers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manufacturier = await _context.Manufacturier.FindAsync(id);
            if (manufacturier == null)
            {
                return NotFound();
            }
            return View(manufacturier);
        }

        // POST: Manufacturiers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ManufacturierId,ManufacturierMarque,ManufacturierSiteWeb,ManufacturierOrigine")] Manufacturier manufacturier)
        {
            if (id != manufacturier.ManufacturierId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(manufacturier);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ManufacturierExists(manufacturier.ManufacturierId))
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
            return View(manufacturier);
        }

        // GET: Manufacturiers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var manufacturier = await _context.Manufacturier
                .FirstOrDefaultAsync(m => m.ManufacturierId == id);
            if (manufacturier == null)
            {
                return NotFound();
            }

            return View(manufacturier);
        }

        // POST: Manufacturiers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var manufacturier = await _context.Manufacturier.FindAsync(id);
            _context.Manufacturier.Remove(manufacturier);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ManufacturierExists(int id)
        {
            return _context.Manufacturier.Any(e => e.ManufacturierId == id);
        }
    }
}
