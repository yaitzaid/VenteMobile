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
    public class TelephoneVendeursController : Controller
    {
        private readonly VenteMobileContext _context;

        public TelephoneVendeursController(VenteMobileContext context)
        {
            _context = context;
        }

        // GET: TelephoneVendeurs
        public async Task<IActionResult> Index()
        {
            var venteMobileContext = _context.TelephoneVendeur.Include(t => t.Telephone).Include(t => t.Vendeur);
            return View(await venteMobileContext.ToListAsync());
        }

        // GET: TelephoneVendeurs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var telephoneVendeur = await _context.TelephoneVendeur
                .Include(t => t.Telephone)
                .Include(t => t.Vendeur)
                .FirstOrDefaultAsync(m => m.TelephoneId == id);
            if (telephoneVendeur == null)
            {
                return NotFound();
            }

            return View(telephoneVendeur);
        }

        // GET: TelephoneVendeurs/Create
        public IActionResult Create()
        {
            ViewData["TelephoneId"] = new SelectList(_context.Telephone, "TelephoneId", "TelephoneId");
            ViewData["VendeurId"] = new SelectList(_context.Vendeur, "VendeurId", "VendeurId");
            return View();
        }

        // POST: TelephoneVendeurs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VendeurId,TelephoneId")] TelephoneVendeur telephoneVendeur)
        {
            if (ModelState.IsValid)
            {
                _context.Add(telephoneVendeur);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TelephoneId"] = new SelectList(_context.Telephone, "TelephoneId", "TelephoneId", telephoneVendeur.TelephoneId);
            ViewData["VendeurId"] = new SelectList(_context.Vendeur, "VendeurId", "VendeurId", telephoneVendeur.VendeurId);
            return View(telephoneVendeur);
        }

        // GET: TelephoneVendeurs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var telephoneVendeur = await _context.TelephoneVendeur.FindAsync(id);
            if (telephoneVendeur == null)
            {
                return NotFound();
            }
            ViewData["TelephoneId"] = new SelectList(_context.Telephone, "TelephoneId", "TelephoneId", telephoneVendeur.TelephoneId);
            ViewData["VendeurId"] = new SelectList(_context.Vendeur, "VendeurId", "VendeurId", telephoneVendeur.VendeurId);
            return View(telephoneVendeur);
        }

        // POST: TelephoneVendeurs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VendeurId,TelephoneId")] TelephoneVendeur telephoneVendeur)
        {
            if (id != telephoneVendeur.TelephoneId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(telephoneVendeur);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TelephoneVendeurExists(telephoneVendeur.TelephoneId))
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
            ViewData["TelephoneId"] = new SelectList(_context.Telephone, "TelephoneId", "TelephoneId", telephoneVendeur.TelephoneId);
            ViewData["VendeurId"] = new SelectList(_context.Vendeur, "VendeurId", "VendeurId", telephoneVendeur.VendeurId);
            return View(telephoneVendeur);
        }

        // GET: TelephoneVendeurs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var telephoneVendeur = await _context.TelephoneVendeur
                .Include(t => t.Telephone)
                .Include(t => t.Vendeur)
                .FirstOrDefaultAsync(m => m.TelephoneId == id);
            if (telephoneVendeur == null)
            {
                return NotFound();
            }

            return View(telephoneVendeur);
        }

        // POST: TelephoneVendeurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var telephoneVendeur = await _context.TelephoneVendeur.FindAsync(id);
            _context.TelephoneVendeur.Remove(telephoneVendeur);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TelephoneVendeurExists(int id)
        {
            return _context.TelephoneVendeur.Any(e => e.TelephoneId == id);
        }
    }
}
