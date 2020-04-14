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
        public async Task<IActionResult> List(int vendeurId)
        {
            if (vendeurId == 0)
            {
                vendeurId = Convert.ToInt32(TempData["idV"]);
            }
            ViewBag.Vendeurs = await _context.Vendeur.FirstOrDefaultAsync(v => v.VendeurId == vendeurId);
            var venteMobileContext = _context.TelephoneVendeur.Include(v => v.Telephone).Include(v => v.Vendeur).Where(v => v.VendeurId == vendeurId);
            return View(await venteMobileContext.ToListAsync());
        }
        public async Task<IActionResult> AjouterTelephone(int vendeurId)
        {
            ViewBag.VendeurManufacturier = _context.VendeurManufacturier.Include(v => v.Manufacturier).Include(v => v.Vendeur).Where(v => v.VendeurId == vendeurId);
            ViewBag.Telephone = _context.Telephone;
            Vendeur vendeur = await _context.Vendeur.FirstOrDefaultAsync(v => v.VendeurId == vendeurId);
            TempData["idV"] = vendeur.VendeurId;
            return View(vendeur);
        }

        [HttpPost]
        public async Task<IActionResult> AjouterTelephone(int vendeurId, int[] TelephoneIds)
        {
            vendeurId = Convert.ToInt32(TempData["idV"]);
            foreach (int TelId in TelephoneIds)
            {
                TelephoneVendeur telephoneVendeur = await _context.TelephoneVendeur
                .Include(t => t.Telephone)
                .Include(v => v.Vendeur)
                .FirstOrDefaultAsync(m => m.VendeurId == vendeurId && m.TelephoneId == TelId);
                if (telephoneVendeur == null)
                {
                    telephoneVendeur = new TelephoneVendeur
                    {
                        TelephoneId = TelId,
                        VendeurId = vendeurId
                    };
                    _context.TelephoneVendeur.Add(telephoneVendeur);
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction("List", new { id = vendeurId });
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
            ViewData["TelephoneId"] = new SelectList(_context.Telephone, "TelephoneId", "TelephoneModel");
            ViewData["VendeurId"] = new SelectList(_context.Vendeur, "VendeurId", "VendeurNom");
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
            ViewData["TelephoneId"] = new SelectList(_context.Telephone, "TelephoneId", "TelephoneModel", telephoneVendeur.TelephoneId);
            ViewData["VendeurId"] = new SelectList(_context.Vendeur, "VendeurId", "VendeurNom", telephoneVendeur.VendeurId);
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
            ViewData["TelephoneId"] = new SelectList(_context.Telephone, "TelephoneId", "TelephoneModel", telephoneVendeur.TelephoneId);
            ViewData["VendeurId"] = new SelectList(_context.Vendeur, "VendeurId", "VendeurNom", telephoneVendeur.VendeurId);
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
            ViewData["TelephoneId"] = new SelectList(_context.Telephone, "TelephoneId", "TelephoneModel", telephoneVendeur.TelephoneId);
            ViewData["VendeurId"] = new SelectList(_context.Vendeur, "VendeurId", "VendeurNom", telephoneVendeur.VendeurId);
            return View(telephoneVendeur);
        }

        // GET: TelephoneVendeurs/Delete/5
        public async Task<IActionResult> Delete(int? idV, int? idT)
        {
            if (idV == null || idT == null)
            {
                return NotFound();
            }

            var telephoneVendeur = await _context.TelephoneVendeur
                .Include(v => v.Telephone)
                .Include(v => v.Vendeur)
                .FirstOrDefaultAsync(m => m.TelephoneId == idT && m.VendeurId == idV);
            if (telephoneVendeur == null)
            {
                return NotFound();
            }

            TempData["idV"] = idV;
            TempData["idT"] = idT;
            return View(telephoneVendeur);
        }

        // POST: TelephoneVendeurs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int idV, int idT)
        {

            idV = Convert.ToInt32(TempData["idV"]);
            idT = Convert.ToInt32(TempData["idT"]);
            var telephoneVendeur = await _context.TelephoneVendeur
                .Include(v => v.Telephone)
                .Include(v => v.Vendeur)
                .FirstOrDefaultAsync(m => m.TelephoneId == idT && m.VendeurId == idV);
            _context.TelephoneVendeur.Remove(telephoneVendeur);
            await _context.SaveChangesAsync();
            return RedirectToAction("List", new { id = idV });
        }

        private bool TelephoneVendeurExists(int id)
        {
            return _context.TelephoneVendeur.Any(e => e.TelephoneId == id);
        }
    }
}
