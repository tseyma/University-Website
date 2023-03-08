using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using duzce_uni.Data;
using duzce_uni.Models;
using Microsoft.AspNetCore.Authorization;

namespace duzce_uni.Controllers
{
    [Authorize]
    public class DuyurularController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DuyurularController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Duyurular
        public async Task<IActionResult> Index()
        {
              return View(await _context.duyurulars.ToListAsync());
        }

        // GET: Duyurular/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.duyurulars == null)
            {
                return NotFound();
            }

            var duyurular = await _context.duyurulars
                .FirstOrDefaultAsync(m => m.Id == id);
            if (duyurular == null)
            {
                return NotFound();
            }

            return View(duyurular);
        }

        // GET: Duyurular/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Duyurular/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,duyuruBaslik,duyuruTur,duyuruTarih,duyuruIcerik1,duyuruIcerik2,duyuruIcerik3,duyuruGorsel1,duyuruGorsel2,duyuruGorsel3,duyuruGorsel4,duyuruGorsel5")] duyurular duyurular)
        {
            if (ModelState.IsValid)
            {
                _context.Add(duyurular);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(duyurular);
        }

        // GET: Duyurular/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.duyurulars == null)
            {
                return NotFound();
            }

            var duyurular = await _context.duyurulars.FindAsync(id);
            if (duyurular == null)
            {
                return NotFound();
            }
            return View(duyurular);
        }

        // POST: Duyurular/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,duyuruBaslik,duyuruTur,duyuruTarih,duyuruIcerik1,duyuruIcerik2,duyuruIcerik3,duyuruGorsel1,duyuruGorsel2,duyuruGorsel3,duyuruGorsel4,duyuruGorsel5")] duyurular duyurular)
        {
            if (id != duyurular.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(duyurular);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!duyurularExists(duyurular.Id))
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
            return View(duyurular);
        }

        // GET: Duyurular/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.duyurulars == null)
            {
                return NotFound();
            }

            var duyurular = await _context.duyurulars
                .FirstOrDefaultAsync(m => m.Id == id);
            if (duyurular == null)
            {
                return NotFound();
            }

            return View(duyurular);
        }

        // POST: Duyurular/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.duyurulars == null)
            {
                return Problem("Entity set 'ApplicationDbContext.duyurulars'  is null.");
            }
            var duyurular = await _context.duyurulars.FindAsync(id);
            if (duyurular != null)
            {
                _context.duyurulars.Remove(duyurular);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool duyurularExists(int id)
        {
          return _context.duyurulars.Any(e => e.Id == id);
        }
    }
}
