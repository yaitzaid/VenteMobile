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
    public class VendeursController : Controller
    {
        private readonly VenteMobileContext _context;

        public VendeursController(VenteMobileContext context)
        {
            _context = context;
        }

        // GET: Vendeurs
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vendeur.ToListAsync());
        }

        // GET: Vendeurs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendeur = await _context.Vendeur
                .FirstOrDefaultAsync(m => m.VendeurId == id);
            if (vendeur == null)
            {
                return NotFound();
            }

            return View(vendeur);
        }

        // GET: Vendeurs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vendeurs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VendeurId,VendeurNom,VendeurAddress,VendeurNoTel")] Vendeur vendeur)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendeur);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vendeur);
        }

        // GET: Vendeurs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendeur = await _context.Vendeur.FindAsync(id);
            if (vendeur == null)
            {
                return NotFound();
            }
            return View(vendeur);
        }

        // POST: Vendeurs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VendeurId,VendeurNom,VendeurAddress,VendeurNoTel")] Vendeur vendeur)
        {
            if (id != vendeur.VendeurId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendeur);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendeurExists(vendeur.VendeurId))
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
            return View(vendeur);
        }

        // GET: Vendeurs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendeur = await _context.Vendeur
                .FirstOrDefaultAsync(m => m.VendeurId == id);
            if (vendeur == null)
            {
                return NotFound();
            }

            return View(vendeur);
        }

        // POST: Vendeurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vendeur = await _context.Vendeur.FindAsync(id);
            _context.Vendeur.Remove(vendeur);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendeurExists(int id)
        {
            return _context.Vendeur.Any(e => e.VendeurId == id);
        }
    }
}
