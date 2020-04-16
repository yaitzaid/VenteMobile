using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VenteMobile.Data;
using VenteMobile.Models;
using PagedList;
using System.Web;


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
        public async Task<IActionResult> Index(int? page, string sortOrder, string searchString, string currentFilter)
        {
            ViewBag.CurrentSort = sortOrder;

            ViewBag.CurrentSort = sortOrder;
            ViewBag.NomSortParm = string.IsNullOrEmpty(sortOrder) ? "nom_desc" : "";

            ViewBag.AdresseSortParm = sortOrder == "Adresse" ? "adresse_desc" : "Adresse";
            ViewBag.NoTelSortParm = sortOrder == "NoTel" ? "noTel_desc" : "NoTel";

            if (searchString != null)
            {
                page = 1;
            }
            else
            {
                searchString = currentFilter;
            }
            var Vendeurs = await Task.Run(() => _context.Vendeur.Select(x => x));
            if (!string.IsNullOrEmpty(searchString))
            {
                Vendeurs = await Task.Run(() =>
                _context.Vendeur.Where(s => s.VendeurNom.Contains(searchString)));

            }

            switch (sortOrder)
            {
                case "nom_desc":
                    Vendeurs = await Task.Run(() => Vendeurs.OrderByDescending(s => s.VendeurNom));
                    break;
                case "prenom_desc":
                    Vendeurs = await Task.Run(() => Vendeurs.OrderByDescending(s => s.VendeurAddress));
                    break;
                case "adresse_desc":
                    Vendeurs = await Task.Run(() => Vendeurs.OrderByDescending(s => s.VendeurNoTel));
                    break;

                default:
                    Vendeurs = await Task.Run(() => Vendeurs.OrderBy(s => s.VendeurNom));
                    break;
            }


            ViewBag.CurrentFilter = searchString;

            int pageSize = 50;
            int pageNumber = (page ?? 1);
            return View(Vendeurs.ToPagedList(pageNumber, pageSize));

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
