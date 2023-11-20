using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ForensicBones3.Models;

namespace ForensicBones3.Controllers
{
    public class InventariosCranioController : Controller
    {
        private readonly AppDbContext _context;

        public InventariosCranioController(AppDbContext context)
        {
            _context = context;
        }

        // GET: InventariosCranio
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.InventariosCranio.Include(i => i.InventarioEsqueleto);
            return View(await appDbContext.ToListAsync());
        }

        // GET: InventariosCranio/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.InventariosCranio == null)
            {
                return NotFound();
            }

            var inventarioCranio = await _context.InventariosCranio
                .Include(i => i.InventarioEsqueleto)
                .FirstOrDefaultAsync(m => m.InventarioCranioId == id);
            if (inventarioCranio == null)
            {
                return NotFound();
            }

            return View(inventarioCranio);
        }

        // GET: InventariosCranio/Create
        public IActionResult Create()
        {
            ViewData["InventarioCranioId"] = new SelectList(_context.InventariosEsqueletos, "InventarioEsqueletoId", "InventarioEsqueletoId");
            return View();
        }

        // POST: InventariosCranio/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InventarioCranioId,InventarioEsqueletoId,FotoCranio,Frontal,Ocipital,Esfenoide,Maxilar,Vomer,ParietalEsq,TemporalEsq,ConchaNasalEsq,EtmoideEsq,LacrimalEsq,NasalEsq,ZigomaticoEsq,ParietalDir,TemporalDir,ConchaNasalDir,EtmoideDir,LacrimalDir,ZigomaticoDir,Hioide,CartilagemTireoide,Mandibula,Observacoes")] InventarioCranio inventarioCranio)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inventarioCranio);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InventarioCranioId"] = new SelectList(_context.InventariosEsqueletos, "InventarioEsqueletoId", "InventarioEsqueletoId", inventarioCranio.InventarioCranioId);
            return View(inventarioCranio);
        }

        // GET: InventariosCranio/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.InventariosCranio == null)
            {
                return NotFound();
            }

            var inventarioCranio = await _context.InventariosCranio.FindAsync(id);
            if (inventarioCranio == null)
            {
                return NotFound();
            }
            ViewData["InventarioCranioId"] = new SelectList(_context.InventariosEsqueletos, "InventarioEsqueletoId", "InventarioEsqueletoId", inventarioCranio.InventarioCranioId);
            return View(inventarioCranio);
        }

        // POST: InventariosCranio/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InventarioCranioId,InventarioEsqueletoId,FotoCranio,Frontal,Ocipital,Esfenoide,Maxilar,Vomer,ParietalEsq,TemporalEsq,ConchaNasalEsq,EtmoideEsq,LacrimalEsq,NasalEsq,ZigomaticoEsq,ParietalDir,TemporalDir,ConchaNasalDir,EtmoideDir,LacrimalDir,ZigomaticoDir,Hioide,CartilagemTireoide,Mandibula,Observacoes")] InventarioCranio inventarioCranio)
        {
            if (id != inventarioCranio.InventarioCranioId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventarioCranio);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventarioCranioExists(inventarioCranio.InventarioCranioId))
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
            ViewData["InventarioCranioId"] = new SelectList(_context.InventariosEsqueletos, "InventarioEsqueletoId", "InventarioEsqueletoId", inventarioCranio.InventarioCranioId);
            return View(inventarioCranio);
        }

        // GET: InventariosCranio/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.InventariosCranio == null)
            {
                return NotFound();
            }

            var inventarioCranio = await _context.InventariosCranio
                .Include(i => i.InventarioEsqueleto)
                .FirstOrDefaultAsync(m => m.InventarioCranioId == id);
            if (inventarioCranio == null)
            {
                return NotFound();
            }

            return View(inventarioCranio);
        }

        // POST: InventariosCranio/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.InventariosCranio == null)
            {
                return Problem("Entity set 'AppDbContext.InventariosCranio'  is null.");
            }
            var inventarioCranio = await _context.InventariosCranio.FindAsync(id);
            if (inventarioCranio != null)
            {
                _context.InventariosCranio.Remove(inventarioCranio);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventarioCranioExists(int id)
        {
          return _context.InventariosCranio.Any(e => e.InventarioCranioId == id);
        }
    }
}
