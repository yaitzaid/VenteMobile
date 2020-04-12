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
        public ActionResult CreateVendeurManufacturiers()
        {
          ViewBag.ManufacturierId= new SelectList(_context.Manufacturier, "ManufacturierId", "ManufacturierMarque");
            ViewBag.Vendeurs = _context.Vendeur;
            return View();
        }

        [HttpPost]
        public ActionResult CreateVendeurManufacturiers(int ManufacturierId,int[] VendeurId)
        {
            foreach (int VendId in VendeurId)
            {
                VendeurManufacturier VendManufacturier = new VendeurManufacturier();
                VendManufacturier = _context.VendeurManufacturier.Find(ManufacturierId,VendId);    
                if (VendManufacturier == null)
                {
                    VendManufacturier.ManufacturierId = ManufacturierId;
                    VendManufacturier.VendeurId = VendId;
                    _context.VendeurManufacturier.Add(VendManufacturier);
                    _context.SaveChanges();
                }               
            }
            return RedirectToAction("Index");
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
            ViewData["VendeurId"] = new SelectList(_context.Vendeur, "VendeurId", "VendeurNom");
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
            ViewData["VendeurId"] = new SelectList(_context.Vendeur, "VendeurId", "VendeurNom", vendeurManufacturier.VendeurId);
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
            ViewData["VendeurId"] = new SelectList(_context.Vendeur, "VendeurId", "VendeurNom", vendeurManufacturier.VendeurId);
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
            ViewData["VendeurId"] = new SelectList(_context.Vendeur, "VendeurId", "VendeurNom", vendeurManufacturier.VendeurId);
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
           
            return View(vendeurManufacturier);
        }

        // POST: VendeurManufacturiers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int idV, int idM)
        {
         
            var vendeurManufacturier = await _context.VendeurManufacturier.FindAsync(idV,idM);
            _context.VendeurManufacturier.Remove(vendeurManufacturier);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VendeurManufacturierExists(int id)
        {
            return _context.VendeurManufacturier.Any(e => e.ManufacturierId == id);
        }
    }
}
