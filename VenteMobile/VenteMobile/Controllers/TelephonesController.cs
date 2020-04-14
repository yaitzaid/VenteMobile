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
    public class TelephonesController : Controller
    {
        private readonly VenteMobileContext _context;

        public TelephonesController(VenteMobileContext context)
        {
            _context = context;
        }

        // GET: Telephones
        public async Task<IActionResult> Index()
        {
            var venteMobileContext = _context.Telephone.Include(t => t.Manufacturier);
            return View(await venteMobileContext.ToListAsync());
        }

        // GET: Telephones/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var telephone = await _context.Telephone
                .Include(t => t.Manufacturier).Include(c => c.Critiques)
                .FirstOrDefaultAsync(m => m.TelephoneId == id);
            if (telephone == null)
            {
                return NotFound();
            }

            return View(telephone);
        }

        public async Task<IActionResult> Detail(int? idT, int? idV)
        {
            ViewBag.Vendeur = await _context.Vendeur.FirstOrDefaultAsync(v => v.VendeurId == idV);
            if (idT == null)
            {
                return NotFound();
            }

            var telephone = await _context.Telephone
             .Include(t => t.Manufacturier).Include(c => c.Critiques)
                .FirstOrDefaultAsync(m => m.TelephoneId == idT);
            if (telephone == null)
            {
                return NotFound();
            }

            return View(telephone);
        }

        // GET: Telephones/Create
        public IActionResult Create()
        {
            ViewData["ManufacturierId"] = new SelectList(_context.Manufacturier, "ManufacturierId", "ManufacturierMarque");
            return View();
        }

        // POST: Telephones/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TelephoneId,TelephoneModel,TelephoneCout,TelephoneCouleur,ManufacturierId,ManufacturierMarque")] Telephone telephone)
        {
            if (ModelState.IsValid)
            {
                _context.Add(telephone);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ManufacturierId"] = new SelectList(_context.Manufacturier, "ManufacturierId", "ManufacturierMarque", telephone.ManufacturierId);
            return View(telephone);
        }

        // GET: Telephones/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var telephone = await _context.Telephone.FindAsync(id);
            if (telephone == null)
            {
                return NotFound();
            }
            ViewData["ManufacturierId"] = new SelectList(_context.Manufacturier, "ManufacturierId", "ManufacturierMarque", telephone.ManufacturierId);
            return View(telephone);
        }

        // POST: Telephones/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TelephoneId,TelephoneModel,TelephoneCout,TelephoneCouleur,ManufacturierId")] Telephone telephone)
        {
            if (id != telephone.TelephoneId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(telephone);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TelephoneExists(telephone.TelephoneId))
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
            ViewData["ManufacturierId"] = new SelectList(_context.Manufacturier, "ManufacturierId", "ManufacturierMarque", telephone.ManufacturierId);
            return View(telephone);
        }

        // GET: Telephones/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var telephone = await _context.Telephone
                .Include(t => t.Manufacturier)
                .FirstOrDefaultAsync(m => m.TelephoneId == id);
            if (telephone == null)
            {
                return NotFound();
            }

            return View(telephone);
        }

        // POST: Telephones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var telephone = await _context.Telephone.FindAsync(id);
            _context.Telephone.Remove(telephone);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TelephoneExists(int id)
        {
            return _context.Telephone.Any(e => e.TelephoneId == id);
        }
    }
}
