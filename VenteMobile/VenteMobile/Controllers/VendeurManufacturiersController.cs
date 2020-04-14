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
    public class VendeurManufacturiersController : Controller
    {
        private readonly VenteMobileContext _context;

        public VendeurManufacturiersController(VenteMobileContext context)
        {
            _context = context;
        }

        // GET: VendeurManufacturiers
        public async Task<IActionResult> Index()
        {
            var venteMobileContext = _context.VendeurManufacturier.Include(v => v.Manufacturier).Include(v => v.Vendeur);
            return View(await venteMobileContext.ToListAsync());
        }
        public async Task<IActionResult> List(int vendeurId)
        {
            if (vendeurId == 0)
            {
                vendeurId = Convert.ToInt32(TempData["idV"]);
            }
            ViewBag.Vendeurs = await _context.Vendeur.FirstOrDefaultAsync(v => v.VendeurId == vendeurId);
            var venteMobileContext = _context.VendeurManufacturier.Include(v => v.Manufacturier).Include(v => v.Vendeur).Where(v => v.VendeurId == vendeurId);
            return View(await venteMobileContext.ToListAsync());
        }

        public async Task<IActionResult> CreateVendeurManufacturierss(int vendeurId)
        {
            ViewBag.Manufacturier = _context.Manufacturier;
            Vendeur vendeur = await _context.Vendeur.FirstOrDefaultAsync(v => v.VendeurId == vendeurId);
            TempData["idV"] = vendeur.VendeurId;
            return View(vendeur);
        }

        [HttpPost]
        public async Task<IActionResult> CreateVendeurManufacturierss(int vendeurId, int[] ManufacturierIds)
        {
            vendeurId = Convert.ToInt32(TempData["idV"]);
            foreach (int ManufId in ManufacturierIds)
            {
                VendeurManufacturier vendeurManufacturier = await _context.VendeurManufacturier
                .Include(v => v.Manufacturier)
                .Include(v => v.Vendeur)
                .FirstOrDefaultAsync(m => m.VendeurId == vendeurId && m.ManufacturierId == ManufId);
                if (vendeurManufacturier == null)
                {
                    vendeurManufacturier = new VendeurManufacturier
                    {
                        ManufacturierId = ManufId,
                        VendeurId = vendeurId
                    };
                    _context.VendeurManufacturier.Add(vendeurManufacturier);
                    await _context.SaveChangesAsync();
                }
            }
            return RedirectToAction("List", new { id = vendeurId });
        }


        // GET: VendeurManufacturiers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendeurManufacturier = await _context.VendeurManufacturier
                .Include(v => v.Manufacturier)
                .Include(v => v.Vendeur)
                .FirstOrDefaultAsync(m => m.ManufacturierId == id);
            if (vendeurManufacturier == null)
            {
                return NotFound();
            }

            return View(vendeurManufacturier);
        }

        // GET: VendeurManufacturiers/Create
        public IActionResult Create()
        {
            ViewData["ManufacturierId"] = new SelectList(_context.Manufacturier, "ManufacturierId", "ManufacturierMarque");
            ViewData["idV"] = new SelectList(_context.Vendeur, "VendeurId", "VendeurNom");
            return View();
        }

        // POST: VendeurManufacturiers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VendeurId,ManufacturierId")] VendeurManufacturier vendeurManufacturier)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vendeurManufacturier);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ManufacturierId"] = new SelectList(_context.Manufacturier, "ManufacturierId", "ManufacturierMarque", vendeurManufacturier.ManufacturierId);
            ViewData["idV"] = new SelectList(_context.Vendeur, "VendeurId", "VendeurNom", vendeurManufacturier.VendeurId);
            return View(vendeurManufacturier);
        }

        // GET: VendeurManufacturiers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vendeurManufacturier = await _context.VendeurManufacturier.FindAsync(id);
            if (vendeurManufacturier == null)
            {
                return NotFound();
            }
            ViewData["ManufacturierId"] = new SelectList(_context.Manufacturier, "ManufacturierId", "ManufacturierMarque", vendeurManufacturier.ManufacturierId);
            ViewData["idV"] = new SelectList(_context.Vendeur, "VendeurId", "VendeurNom", vendeurManufacturier.VendeurId);
            return View(vendeurManufacturier);
        }

        // POST: VendeurManufacturiers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VendeurId,ManufacturierId")] VendeurManufacturier vendeurManufacturier)
        {
            if (id != vendeurManufacturier.ManufacturierId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vendeurManufacturier);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VendeurManufacturierExists(vendeurManufacturier.ManufacturierId))
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
            ViewData["ManufacturierId"] = new SelectList(_context.Manufacturier, "ManufacturierId", "ManufacturierMarque", vendeurManufacturier.ManufacturierId);
            ViewData["idV"] = new SelectList(_context.Vendeur, "VendeurId", "VendeurNom", vendeurManufacturier.VendeurId);
            return View(vendeurManufacturier);
        }

        // GET: VendeurManufacturiers/Delete/5
        public async Task<IActionResult> Delete(int? idV, int? idM)
        {
            if (idV == null || idM == null)
            {
                return NotFound();
            }

            var vendeurManufacturier = await _context.VendeurManufacturier
                .Include(v => v.Manufacturier)
                .Include(v => v.Vendeur)
                .FirstOrDefaultAsync(m => m.ManufacturierId == idM && m.VendeurId == idV);
            if (vendeurManufacturier == null)
            {
                return NotFound();
            }

            TempData["idV"] = idV;
            TempData["idM"] = idM;
            return View(vendeurManufacturier);
        }

        // POST: VendeurManufacturiers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int idV, int idM)
        {

            idV = Convert.ToInt32(TempData["idV"]);
            idM = Convert.ToInt32(TempData["idM"]);
            var vendeurManufacturier = await _context.VendeurManufacturier
                .Include(v => v.Manufacturier)
                .Include(v => v.Vendeur)
                .FirstOrDefaultAsync(m => m.ManufacturierId == idM && m.VendeurId == idV);
            _context.VendeurManufacturier.Remove(vendeurManufacturier);
            await _context.SaveChangesAsync();
            return RedirectToAction("List", new { id = idV });
        }

        private bool VendeurManufacturierExists(int id)
        {
            return _context.VendeurManufacturier.Any(e => e.ManufacturierId == id);
        }
    }
}
